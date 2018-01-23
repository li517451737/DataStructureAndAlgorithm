using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnCalendar
{
    public class CCalender
    {
        /// <summary>
        /// 当前阳历的日期
        /// </summary>
        private DateTime myDate;
        /// <summary>
        /// 甲子中的年份
        /// </summary>
        private int sexagenaryYear;
        /// <summary>
        /// 天干年份
        /// </summary>
        private int celestialStem;
        /// <summary>
        /// 地支年份
        /// </summary>
        private int terrestrialBranch;
        /// <summary>
        /// 月份
        /// </summary>
        private int cnMonth;
        /// <summary>
        /// 闰月
        /// </summary>
        private int cnLeapMonth;
        /// <summary>
        /// 日子
        /// </summary>
        private int cnDay;

        /// <summary>
        /// 天干
        /// </summary>
        private static string[] arrCelestialStem = { "", "甲", "乙", "丙", "丁", "戊", "己", "庚", "辛", "壬", "葵" };
        /// <summary>
        /// 地支
        /// </summary>
        private static string[] arrTerrestrialBranch = { "", "子", "丑", "寅", "卯", "辰", "酉", "午", "未", "申", "酉", "午", "亥" };
        /// <summary>
        /// 农历月份名称
        /// </summary>
        private static string[] arrMonthName = { "", "正月", "二月", "三月", "四月", "五月", "六月", "七月", "八月", "九月", "十月", "冬月", "腊月" };
        /// <summary>
        /// 农历日子名称
        /// </summary>
        private static string[] arrDayName = { "","初一","初二","初三","初四","初五","初六","初七","初八","初九","初十",
                                    "十一","十二","十三","十四","十五","十六","十七","十八","十九","二十",
                                    "廿一","廿二","廿三","廿四","廿五","廿六","廿七","廿八","廿九","三十"};

        public CCalender(DateTime date)
        {
            myDate = date;
            ChineseLunisolarCalendar caleCn = new ChineseLunisolarCalendar();
            //计算农历年份
            sexagenaryYear = caleCn.GetSexagenaryYear(myDate);
            //计算天干
            celestialStem = caleCn.GetCelestialStem(sexagenaryYear);
            //计算地支
            terrestrialBranch = caleCn.GetTerrestrialBranch(sexagenaryYear);
            //计算月份
            cnMonth = caleCn.GetMonth(myDate);
            //闰月
            if (myDate.Month < 3 && cnMonth > 9)
            {
                cnLeapMonth = caleCn.GetLeapMonth(myDate.Year - 1);
            }
            else
            {
                cnLeapMonth = caleCn.GetLeapMonth(myDate.Year);
            }
            cnDay = caleCn.GetDayOfMonth(myDate);
        }
        /// <summary>
        /// 显示农历年份名称
        /// </summary>
        /// <returns></returns>
        public string GetYearName()
        {
            return arrCelestialStem[celestialStem] + arrTerrestrialBranch[terrestrialBranch] + "年";
        }

        /// <summary>
        /// 显示月份名称
        /// </summary>
        /// <returns></returns>
        public string GetMonthName()
        {
            if (cnLeapMonth == 0)
            {
                return arrMonthName[cnMonth];
            }
            else
            {
                if (cnMonth < cnLeapMonth)
                {
                    return arrMonthName[cnMonth];
                }
                else if (cnMonth == cnLeapMonth)
                {
                    return "闰" + arrMonthName[cnMonth - 1];
                }
                else
                {
                    return arrMonthName[cnMonth - 1];
                }
            }
        }
        /// <summary>
        /// 获取日子名称
        /// </summary>
        /// <returns></returns>
        public string GetDayName()
        {
            return arrDayName[cnDay];
        }
        /// <summary>
        /// 获取属性名称
        /// </summary>
        /// <returns></returns>
        public string GetAnimalName()
        {
            string[] arrAnimalName = { "猪", "鼠", "牛", "虎", "兔", "龙", "蛇", "马", "羊", "猴", "鸡", "狗" };
            return arrAnimalName[sexagenaryYear % 12];
        }
    }
}
