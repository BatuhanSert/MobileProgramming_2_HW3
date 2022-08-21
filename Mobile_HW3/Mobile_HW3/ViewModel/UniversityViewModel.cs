using Mobile_HW3.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Reflection;
using System.IO;
using CsvHelper;
using System.Globalization;
using Xamarin.Forms;

namespace Mobile_HW3.ViewModel
{
    public class UniversityViewModel
    {
        public ObservableCollection<Universities> UniversityLists { get; set; }              

        public UniversityViewModel()
        {
            UniversityLists = new ObservableCollection<Universities>()
            {
                //new Universities(){id = 1, university_name= "ESTU", university_details= "Eskişehir"},
                //new Universities(){id = 1, university_name= "Anadolu", university_details= "Eskişehir"},
            };
            var assembly = IntrospectionExtensions.GetTypeInfo(typeof(UniversityViewModel)).Assembly;
            Stream stream = assembly.GetManifestResourceStream("Mobile_HW3.Universiteler.csv");
            using (var reader = new System.IO.StreamReader(stream))
            {
                if (reader != null)
                {
                    using (var csvReader = new CsvReader(reader, CultureInfo.CurrentCulture))
                    {

                        while (csvReader.Read())
                        {
                            string logo = csvReader.GetField<string>(0);
                            string uni = csvReader.GetField<string>(1);
                            string tur = csvReader.GetField<string>(2);
                            string sehir = csvReader.GetField<string>(3);
                            string web_sitesi = csvReader.GetField<string>(4);
                            UniversityLists.Add(new Universities() { university_logo = logo, university_name = uni , university_type = tur , university_location = sehir, university_url = web_sitesi });                                                        
                        }
                    }
                }
            }

            
        }

    }
}
