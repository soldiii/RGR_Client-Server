using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using MySql.Data.MySqlClient;
using System.Globalization;

namespace heheru
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void AddVacSpec(int idVacany, string[] spec_id_arr)
        {
            string conn_setts = "server=localhost;port=3306;username=root;password=root;database=heheru";
            MySqlConnection conn = new MySqlConnection(conn_setts);
            conn.Open();
            for (int i = 0; i < spec_id_arr.Length; i++)
            {
                string sql = $"INSERT IGNORE INTO `vacancies_specializations`(`id_vacancy`, `id_specialization`) VALUES('{idVacany}', '{spec_id_arr[i]}')";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteScalar();
            }
            conn.Close();
        }
        private void AddSkills(int idVacancy, string[] skills_arr)
        {
            string conn_setts = "server=localhost;port=3306;username=root;password=root;database=heheru";
            MySqlConnection conn = new MySqlConnection(conn_setts);
            conn.Open();
            for (int i = 0; i < skills_arr.Length; i++)
            {
                string sql = $"INSERT IGNORE INTO `vacancies_skills`(`id_vacancy`, `id_skill`) VALUES('{idVacancy}', '{skills_arr[i]}')";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteScalar();
            }
            conn.Close();
        }
        private void AddVacancy(int idVacancy,string Description,string NameVacancy,string formatedforsql,string salaryCurrency,string salaryFrom,string salaryTo,string SnippetRequirement,string SnippetResponsibility,int idArea, string idExpirience )
        {
            string sql = $"INSERT IGNORE INTO `vacancies`(`id_vacancy`, `description`, `name`, `published_at`, `salary_currency`, `salary_from`, `salary_to`, `snippet_requirement`, `snippet_responsibility`, `id_area`, `id_experience`) VALUES ({idVacancy},'{Description}','{NameVacancy}','{formatedforsql}','{salaryCurrency}',{salaryFrom},{salaryTo},'{SnippetRequirement}','{SnippetResponsibility}',{idArea},'{idExpirience}')";
            string conn_setts = "server=localhost;port=3306;username=root;password=root;database=heheru";
            MySqlConnection conn = new MySqlConnection(conn_setts);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            try
            {
                cmd.ExecuteScalar();
            }
            catch (MySql.Data.MySqlClient.MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
            conn.Close();
        }
        private void AddSpec(string[] spec_id_arr, string[] spec_name_arr)
        {
            string conn_setts = "server=localhost;port=3306;username=root;password=root;database=heheru";
            MySqlConnection conn = new MySqlConnection(conn_setts);
            conn.Open();
            for (int i = 0; i < spec_id_arr.Length; i++)
            {
                string sql = $"INSERT IGNORE INTO `specializations`(`id_specialization`, `name`) VALUES('{spec_id_arr[i]}', '{spec_name_arr[i]}')";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteScalar();
            }
            conn.Close();
        }
        private void AddExperience(string idExp, string Name)
        {
            string sql = $"INSERT IGNORE INTO `experience`(`id_experience`, `name`) VALUES('{idExp}', '{Name}')";
            string conn_setts = "server=localhost;port=3306;username=root;password=root;database=heheru";
            MySqlConnection conn = new MySqlConnection(conn_setts);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteScalar();
            conn.Close();
        }
        private void AddArea(int idArea, string nameArea)
        {
            string sql = $"INSERT IGNORE INTO `area`(`id_area`, `name`) VALUES({idArea}, '{nameArea}')";
            string conn_setts = "server=localhost;port=3306;username=root;password=root;database=heheru";
            MySqlConnection conn = new MySqlConnection(conn_setts);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteScalar();
            conn.Close();
        }
        private void fill_Click(object sender, EventArgs e)
        {
            string area = "area="+Area.Text;
            string text = "text="+Vacancy.Text;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(
                $"https://api.hh.ru/vacancies?" + area + "&" + text);
            request.Headers.Add("HH-User-Agent", "HH-User-Agent");

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);
            string line = reader.ReadToEnd();
            dynamic d = JsonConvert.DeserializeObject(line);
            
            foreach(dynamic item in d.items)
            {
                int idVacancy = item.id;

                HttpWebRequest vacancy_request = (HttpWebRequest)WebRequest.Create(
                $"https://api.hh.ru/vacancies/" + idVacancy);
                vacancy_request.Headers.Add("HH-User-Agent", "HH-User-Agent");
                HttpWebResponse vacancy_response = (HttpWebResponse)vacancy_request.GetResponse();
                Stream s = vacancy_response.GetResponseStream();
                StreamReader r = new StreamReader(s);
                string ln = r.ReadToEnd();
                JsonSerializerSettings setts = new JsonSerializerSettings();
                setts.NullValueHandling = NullValueHandling.Ignore;

                dynamic v = JsonConvert.DeserializeObject(ln);

                int i = 0;
                var key_skills = v.key_skills;
                i = key_skills.Count;
                string[] skills_arr = new string[i]; 
                for(int j = 0; j < i; j++)
                {
                    skills_arr[j] = v.key_skills[j].name;
                }
                string NameVacancy = v.name;
                int idArea = v.area.id;
                string nameArea = v.area.name;
                string salaryCurrency = "null";
                string salaryFrom = "null";
                string salaryTo = "null";
                

                if (v.salary != null && v.salary.from != null)
                {
                    salaryFrom = v.salary.from;
                    salaryCurrency = v.salary.currency;
                }
                else
                {
                    salaryFrom = "null";
                }

                if (v.salary != null && v.salary.to != null)
                {
                    salaryTo = v.salary.to;
                    salaryCurrency = v.salary.currency;
                }
                else
                {
                    salaryTo = "null";
                }

                DateTime PublishedAt = v.published_at;
                string formatedforsql = PublishedAt.ToString("yyyy-MM-dd HH:mm:ss");

                string Description = v.description;
                string SnippetRequirement = item.snippet.requirement;
                string SnippetResponsibility = item.snippet.responsibility;
                string idExpirience = v.experience.id;
                string nameExpirience = v.experience.name;

                i = 0;
                var spec = v.specializations;
                i = spec.Count;
                string[] spec_id_arr = new string[i];
                string[] spec_name_arr = new string[i];
                for (int j = 0; j < i; j++)
                {
                    spec_id_arr[j] = v.specializations[j].id;
                    spec_name_arr[j] = v.specializations[j].name;
                }

                AddArea(idArea, nameArea);
                AddExperience(idExpirience, nameExpirience);
                AddSpec(spec_id_arr, spec_name_arr);
                AddSkills(idVacancy,skills_arr);
                AddVacSpec(idVacancy, spec_id_arr);
                AddVacancy(idVacancy, Description, NameVacancy, formatedforsql, salaryCurrency, salaryFrom, salaryTo, SnippetRequirement, SnippetResponsibility, idArea, idExpirience);


                s.Close();
                r.Close();
                vacancy_response.Close();
            }
            
            
            response.Close();
        }
    }
}
