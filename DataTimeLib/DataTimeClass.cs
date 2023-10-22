using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTimeLib
{
    public class DataTimeClass
    {
        /// <summary>
        /// Метод принимает в качестве параметра стороку DataTime
        /// </summary>
        /// <param name="date"></param>
        /// <returns>
        /// Метод возврашает дату предыдущего дня
        /// </returns>
        public static DateTime PrevDate(DateTime date)
        {
            return date.AddDays(-1);
        }
        /// <summary>
        /// Метод принимает в качестве параметра стороку DataTime
        /// </summary>
        /// <param name="date"></param>
        /// <returns>
        /// Метод возврашает дату следующего дня
        /// </returns>
        public static DateTime NextDate(DateTime date)
        {
            return date.AddDays(+1);
        }


        /// <summary>
        /// Метод принимает в качестве параметра стороку DataTime
        /// </summary>
        /// <param name="date"></param>
        /// <returns>
        /// Метод возврашает сколько дней осталось до конца месяца
        /// </returns>
        public static int DaysUntilEndMonth(DateTime date)
        {
            int lastDayOfMonth = DateTime.DaysInMonth(date.Year, date.Month); //получение посленего дня в месяце
            int days = date.Day;
            int days1 = lastDayOfMonth - days; //вычитание из дней месяца заданого дня
            return days1;
        }

        /// <summary>
        /// Метод принимает в качестве параметра стороку DataTime
        /// </summary>
        /// <param name="date"></param>
        /// <returns>
        /// Метод возврашает true если год високосный, false если не високосный
        /// </returns>
        public static bool LeapYearCheck(DateTime date)
        {
            if(DateTime.IsLeapYear(date.Year)) //Проверка, что год високосный
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        /// <summary>
        /// Метод имеет два входящих параметра: дата относительно которой выполняется поиск, целое значение - число дней, которые необходимо отсчитать от указанной даты
        /// </summary>
        /// <param name="date"></param>
        /// <param name="plusdate"></param>
        /// <returns>
        /// Метод возвашает дату i-того по счету дня относительно установленной даты 
        /// </returns>
        public static DateTime FindDate(DateTime date, int plusdate)
        {
            DateTime finddate;
            finddate = date.AddDays(plusdate); //Прибавление к дате число дней
            return finddate;
        }

        /// <summary>
        /// Метод принимает в качестве параметра стороку DataTime
        /// </summary>
        /// <param name="date"></param>
        /// <returns>
        /// Метод возвращает значение true, если установленная дата не является последним днем месяца, иначе false;
        /// </returns>
        public static bool NextDayOfMonth(DateTime date)
        {
            int lastDayOfMonth = DateTime.DaysInMonth(date.Year, date.Month); //получение посленего дня в месяце
            if( lastDayOfMonth == date.Day ) //Сравнение дня месяца с поледним днём
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Метод принимает в качестве параметра стороку DataTime
        /// </summary>
        /// <param name="date"></param>
        /// <returns>
        /// Метод возврашает значение true, если установленная дата является началом года, иначе false
        /// </returns>
        public static bool FirstDayOdYear(DateTime date)
        {
            date.ToLocalTime();
            if (date.Day == 01 && date.Month == 01) //Проверка что дата первы день января
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Метод принимает две даты и параметр времени промежутков
        /// </summary>
        /// <param name="date1"></param>
        /// <param name="date2"></param>
        /// <param name="time"></param>
        /// <returns>
        /// Метод возврашает сколько временных промежутков находится между двумя датами
        /// returns>
        public static double TimeSpanPeriods(DateTime date1, DateTime date2, int time)
        {
            TimeSpan dt = date2.Subtract(date1);
            double i = dt.TotalMinutes / time;
            return Math.Round(i,2);
        }
    }
}
