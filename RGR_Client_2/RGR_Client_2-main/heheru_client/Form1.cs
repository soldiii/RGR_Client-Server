using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using System.IO;
using System.Globalization;

namespace heheru_client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        async private void POST_Click(object sender, EventArgs e)
        {
            int id_vacancy = Int32.Parse(vacId.Text);
            string description = vacDescription.Text;
            string name = vacName.Text;
            string published_at = "2022-05-14 21:46:25";
            string salary_currency = currency.Text;
            int salary_from = Int32.Parse(vacsalary_from.Text);
            int salary_to = Int32.Parse(vacsalary_to.Text);
            string snippet_requirement = snipreq.Text;
            string snippet_responsibility = snipres.Text;
            string name_area = vacarea.Text;
            int id_area;
            string id_skills = vacskills.Text;
            string name_experience = vacexp.Text;
            string id_experience;
            string spec_name = vacspec.Text;
            string id_specialization;

            HttpWebRequest requestarea = (HttpWebRequest)WebRequest.Create(
               $"http://localhost/restapi_rgr_2/areas?AreaName=" + name_area);
            requestarea.Headers.Add("HH-User-Agent", "HH-User-Agent");
            HttpWebResponse responsearea = (HttpWebResponse)requestarea.GetResponse();
            Stream streamarea = responsearea.GetResponseStream();
            StreamReader readerarea = new StreamReader(streamarea);
            string linearea = readerarea.ReadToEnd();
            dynamic area = JsonConvert.DeserializeObject(linearea);
            id_area = area.records[0].id_area;
            streamarea.Close();
            readerarea.Close();

            HttpWebRequest requesexp = (HttpWebRequest)WebRequest.Create(
               $"http://localhost/restapi_rgr_2/experiences?ExperienceName=" + name_experience);
            requesexp.Headers.Add("HH-User-Agent", "HH-User-Agent");
            HttpWebResponse responsexp = (HttpWebResponse)requesexp.GetResponse();
            Stream streamexp = responsexp.GetResponseStream();
            StreamReader readerexp = new StreamReader(streamexp);
            string linexp = readerexp.ReadToEnd();
            dynamic exp = JsonConvert.DeserializeObject(linexp);
            id_experience = exp.records[0].id_experience;
            streamexp.Close();
            readerarea.Close();

            HttpWebRequest requestspec = (HttpWebRequest)WebRequest.Create(
               $"http://localhost/restapi_rgr_2/specializations?SpecializationName=" + spec_name);
            requestspec.Headers.Add("HH-User-Agent", "HH-User-Agent");
            HttpWebResponse responsespec = (HttpWebResponse)requestspec.GetResponse();
            Stream streamspec = responsespec.GetResponseStream();
            StreamReader readerspec = new StreamReader(streamspec);
            string lineaspec = readerspec.ReadToEnd();
            dynamic spec = JsonConvert.DeserializeObject(lineaspec);
            id_specialization = spec.records[0].id_specialization;
            streamarea.Close();
            readerarea.Close();


            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), "http://localhost/restapi_rgr_2/vacancies"))
                {
                    request.Content = new StringContent($"id_vacancy={id_vacancy}&description={description}&name={name}" +
                        $"&published_at={published_at}&salary_currency={salary_currency}&salary_from={salary_from}" +
                        $"&salary_to={salary_to}&snippet_requirement={snippet_requirement}&snippet_responsibility={snippet_responsibility}" +
                        $"&id_area={id_area}&id_experience={id_experience}");
                    request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/x-www-form-urlencoded");
                    var response = await httpClient.SendAsync(request);
                }
            }

            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), "http://localhost/restapi_rgr_2/areas"))
                {
                    request.Content = new StringContent($"id_area={id_area}&name={name_area}");
                    request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/x-www-form-urlencoded");
                    var response = await httpClient.SendAsync(request);
                }
            }

            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), "http://localhost/restapi_rgr_2/experiences"))
                {
                    request.Content = new StringContent($"id_experience={id_experience}&name={name_experience}");
                    request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/x-www-form-urlencoded");
                    var response = await httpClient.SendAsync(request);
                }
            }

            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), "http://localhost/restapi_rgr_2/specializations"))
                {
                    request.Content = new StringContent($"id_specialization={id_specialization}&name={spec_name}");
                    request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/x-www-form-urlencoded");
                    var response = await httpClient.SendAsync(request);
                }
            }

            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), "http://localhost/restapi_rgr_2/vacancies_skills"))
                {
                    request.Content = new StringContent($"id_vacancy={id_vacancy}&id_skill={id_skills}");
                    request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/x-www-form-urlencoded");
                    var response = await httpClient.SendAsync(request);
                }
            }

            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), "http://localhost/restapi_rgr_2/vacancies_specializations"))
                {
                    request.Content = new StringContent($"id_vacancy={id_vacancy}&id_specialization={id_specialization}");
                    request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/x-www-form-urlencoded");
                    var response = await httpClient.SendAsync(request);
                }
            }
        }

        async private void DELETE_Click(object sender, EventArgs e)
        {
            string id_vacancy = (vacId.Text);
            
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("DELETE"), "http://localhost/restapi_rgr_2/vacancies/" + id_vacancy))
                {
                    var response = await httpClient.SendAsync(request);
                }
            }
        }

        async private void PUT_Click(object sender, EventArgs e)
        {
            int id_vacancy = Int32.Parse(vacId.Text);
            string description = vacDescription.Text;
            string name = vacName.Text;
            string published_at = "2022-05-14 21:46:25";
            string salary_currency = currency.Text;
            int salary_from = Int32.Parse(vacsalary_from.Text);
            int salary_to = Int32.Parse(vacsalary_to.Text);
            string snippet_requirement = snipreq.Text;
            string snippet_responsibility = snipres.Text;
            string name_area = vacarea.Text;
            int id_area;
            string id_skills = vacskills.Text;
            string name_experience = vacexp.Text;
            string id_experience;
            string spec_name = vacspec.Text;
            string id_specialization;

            HttpWebRequest requestarea = (HttpWebRequest)WebRequest.Create(
               $"http://localhost/restapi_rgr_2/areas?AreaName=" + name_area);
            requestarea.Headers.Add("HH-User-Agent", "HH-User-Agent");
            HttpWebResponse responsearea = (HttpWebResponse)requestarea.GetResponse();
            Stream streamarea = responsearea.GetResponseStream();
            StreamReader readerarea = new StreamReader(streamarea);
            string linearea = readerarea.ReadToEnd();
            dynamic area = JsonConvert.DeserializeObject(linearea);
            id_area = area.records[0].id_area;
            streamarea.Close();
            readerarea.Close();

            HttpWebRequest requesexp = (HttpWebRequest)WebRequest.Create(
               $"http://localhost/restapi_rgr_2/experiences?ExperienceName=" + name_experience);
            requesexp.Headers.Add("HH-User-Agent", "HH-User-Agent");
            HttpWebResponse responsexp = (HttpWebResponse)requesexp.GetResponse();
            Stream streamexp = responsexp.GetResponseStream();
            StreamReader readerexp = new StreamReader(streamexp);
            string linexp = readerexp.ReadToEnd();
            dynamic exp = JsonConvert.DeserializeObject(linexp);
            id_experience = exp.records[0].id_experience;
            streamexp.Close();
            readerarea.Close();

            HttpWebRequest requestspec = (HttpWebRequest)WebRequest.Create(
               $"http://localhost/restapi_rgr_2/specializations?SpecializationName=" + spec_name);
            requestspec.Headers.Add("HH-User-Agent", "HH-User-Agent");
            HttpWebResponse responsespec = (HttpWebResponse)requestspec.GetResponse();
            Stream streamspec = responsespec.GetResponseStream();
            StreamReader readerspec = new StreamReader(streamspec);
            string lineaspec = readerspec.ReadToEnd();
            dynamic spec = JsonConvert.DeserializeObject(lineaspec);
            id_specialization = spec.records[0].id_specialization;
            streamarea.Close();
            readerarea.Close();


            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("PUT"), $"http://localhost/restapi_rgr_2/vacancies/{id_vacancy}"))
                {
                    request.Content = new StringContent($"id_vacancy={id_vacancy}&description={description}&name={name}" +
                        $"&published_at={published_at}&salary_currency={salary_currency}&salary_from={salary_from}" +
                        $"&salary_to={salary_to}&snippet_requirement={snippet_requirement}&snippet_responsibility={snippet_responsibility}" +
                        $"&id_area={id_area}&id_experience={id_experience}");
                    request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/x-www-form-urlencoded");
                    var response = await httpClient.SendAsync(request);
                }
            }

            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("PUT"), "http://localhost/restapi_rgr_2/areas"))
                {
                    request.Content = new StringContent($"id_area={id_area}&name={name_area}");
                    request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/x-www-form-urlencoded");
                    var response = await httpClient.SendAsync(request);
                }
            }

            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("PUT"), "http://localhost/restapi_rgr_2/experiences"))
                {
                    request.Content = new StringContent($"id_experience={id_experience}&name={name_experience}");
                    request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/x-www-form-urlencoded");
                    var response = await httpClient.SendAsync(request);
                }
            }

            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("PUT"), "http://localhost/restapi_rgr_2/specializations"))
                {
                    request.Content = new StringContent($"id_specialization={id_specialization}&name={spec_name}");
                    request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/x-www-form-urlencoded");
                    var response = await httpClient.SendAsync(request);
                }
            }

            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("PUT"), "http://localhost/restapi_rgr_2/vacancies_skills"))
                {
                    request.Content = new StringContent($"id_vacancy={id_vacancy}&id_skill={id_skills}");
                    request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/x-www-form-urlencoded");
                    var response = await httpClient.SendAsync(request);
                }
            }

            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("PUT"), "http://localhost/restapi_rgr_2/vacancies_specializations"))
                {
                    request.Content = new StringContent($"id_vacancy={id_vacancy}&id_specialization={id_specialization}");
                    request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/x-www-form-urlencoded");
                    var response = await httpClient.SendAsync(request);
                }
            }
        }
    }
}
