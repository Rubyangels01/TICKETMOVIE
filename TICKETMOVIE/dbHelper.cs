using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace TICKETMOVIE
{
    class dbHelper
    {
        public static T ConvertToClass<T>(object data)
        {
            if (data != null)
            {
                // Serialize đối tượng data sang JSON string
                string jsonData = JsonConvert.SerializeObject(data);

                // Deserialize JSON string thành đối tượng kiểu T
                T objectConvert = JsonConvert.DeserializeObject<T>(jsonData);

                return objectConvert;
            }
            return default(T);
        }


        public static string ConvertDate(string date, string type)
        {
            if (string.IsNullOrWhiteSpace(date))
            {
                throw new FormatException("Date string cannot be null or whitespace.");
            }

            DateTime inputDate;
            string[] formats = { "M/d/yyyy", "MM/dd/yyyy", "d/M/yyyy", "dd/MM/yyyy", "yyyy-MM-dd","dd-MM-yyyy" };

            if (DateTime.TryParseExact(date, formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out inputDate))
            {
                string formattedDate = inputDate.ToString(type);
                return formattedDate;
            }
            else
            {
                throw new FormatException($"Invalid date format: {date}. Expected formats are: {string.Join(", ", formats)}.");
            }
        }
        public static string convertDate(string date)
        {
            DateTime dateTime = DateTime.Parse(date, null, DateTimeStyles.RoundtripKind);
            string formattedDate = dateTime.ToString("dd-MM-yyyy HH:mm");
            return formattedDate;
        }

        public static string ConvertStringArr(String[] arr)
        {
            
            string result = string.Join(", ", arr);
            return result;

        }
        
            public static bool CheckDate(String str)
            {

            DateTime dateToCompare;
            bool isParsed = DateTime.TryParse(str, out dateToCompare);

            if (isParsed)
            {
                
                DateTime currentDate = DateTime.Now;

                
                int comparisonResult = DateTime.Compare(dateToCompare, currentDate);

                if (comparisonResult < 0)
                {
                    return false;
                }
                else if (comparisonResult == 0)
                {
                   return true;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
            return false;

        }
    }
}
