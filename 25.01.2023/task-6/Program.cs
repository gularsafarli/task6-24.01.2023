using System;
using System.Reflection.Metadata.Ecma335;

namespace task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string name = "Gular";
            //var word= IsName(name);
            //Console.WriteLine(word);

            //string[] fullnames = {"Hikmet Ziya", "Mikayil Musviq", "Abdulla Saiq" };
            //var names = Makename(fullnames);
            //for (int i = 0; i < fullnames.Length; i++)
            //{
            //    Console.WriteLine(names[i]);
            //}
            //string[] ahsh = { "alma", "armud", "alma", "heyva", "glas" };
            //string [] word = MakeAry(ahsh);
            //for (int i = 0; i < word.Length; i++)
            //{
            //    Console.WriteLine(word[i]);
            //}

            //var word = Returnword("SAlAm");
            //Console.WriteLine(word);

            #region AcademyTask5+ cosole-da email deyeri istenilsin. Eger deyerde @ xarakteri yoxdursa yeniden istenilsin
            //string email;
            //do
            //{
            //    Console.WriteLine("Email daxil edin:");
            //    email = Console.ReadLine();
            //} while (!email.Contains('@'));
            #endregion

            #region AcademyTask6+ Ad daxil etdikde, dogru olmadiqda yeniden istenilsin.
            //string name;
            //do
            //{
            //    Console.WriteLine("Adinizi daxil edin:");
            //    name = Console.ReadLine();
            //} while (IsName(name)==false);
            #endregion

            //string name = "Gular";
            //var str = Hasanum(name);
            //Console.WriteLine(str);

            //int[] numbers = { 2, 3, 7, 5, 3, 4, 2 };
            //int [] num = ReturnAry(numbers);
            //for (int i = 0; i < num.Length; i++)
            //{
            //    Console.WriteLine(num[i]);
            //}
            //Console.WriteLine(IsFullname("Mikayil Musviq"));
        }

        #region AcademyTask1+ Verilmis yazinin ad olub olmadigini tapan method
        static bool IsName(string name)
        {
            if (!char.IsUpper(name[0]))
                return false;

            for (int i = 1; i < name.Length; i++)
            {
                if (!char.IsLower(name[i]))
                {
                    return false;
                }
            }
            return true;
        }
        #endregion

        #region AcademyTask2+ Verilmis fullname siyahasindan name siyahasini duzeldib qaytaran metod
        //static string[] Makename(string[] fullname)
        //{
        //    string[] names = new string[fullname.Length];
        //    for (int i = 0; i < fullname.Length; i++)
        //    {
        //        names[i] = fullname[i].Substring(0, fullname[i].IndexOf(" "));
        //    }
        //    return names;
        //}
        #endregion

        #region AcademyTask3+ Verilmis string arrayinin icerisindeki tekrarlanmayan deyerlerden ibaret yeni bir array qaytarsin.
        //static string [] MakeAry(string[] word)
        //{
        //    string[] newAr = new string[0];
        //    for (int i = 0; i < word.Length; i++)
        //    {
        //        if (Array.IndexOf(newAr, word[i])==-1)
        //        {
        //            Array.Resize(ref newAr,newAr.Length + 1);
        //            newAr[newAr.Length - 1] = word[i];
        //        }
        //    }
        //    return newAr;

        //}
        #endregion

        #region AcademyTask4+ Verilmis yazini bas herfi boyuk digerleri kicik halda qaytaran metod
        //static string Returnword(string word)
        //{
        //   return char.ToUpper(word[0]) + word.Substring(1).ToLower();
        //}
        #endregion

        #region Homework1+  Verilmiş yazıda rəqəm olub olmadığını tapan metod
        //static bool Hasanum(string word)
        //{
        //    for (int i = 0; i < word.Length; i++)
        //    {
        //        if (char.IsDigit(word[i]))
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}
        #endregion

        #region Homerwork2+ Verilmiş yazının fullname olub olmadığını tapan metod (fullname olması üçün iki sozdən ibarət olmalıdır.
        //və hər bir söz böyük hərflə başlayıb kiçik hərflərlə davam etməlidir)
        //static bool IsFullname(string str)
        //{
            //esas hell//int count = 0;
            //for (int i = 0; i < str.Length; i++)
            //{
            //    if (str[i]!=' ')
            //    {
            //        count++;
            //    }
            //    if (count==2)
            //    {
            //        var word = str.Split(" ");
            //        if (IsName(word[0]) && IsName(word[1]))
            //        {
            //            return true;
            //        }
            //    }
            //}
            //return false;     
        //}

        #endregion

        #region Homerwork3+ Verilmiş ədədlər siyahısından yeni bir array düzəldib qaytaran metod.
        //Yeni arrayə elementlər təkrarlanmamaq şərti ilə yerləşdirilsin.
        //static int[] ReturnAry(int[] num)
        //{
        //   int[] newArr = new int[0];
        //   for (int i = 0; i < num.Length; i++)
        //   {
        //       if (Array.IndexOf(newArr, num[i])==-1)
        //       {
        //           Array.Resize(ref newArr, newArr.Length + 1);
        //           newArr[newArr.Length - 1] = num[i];
        //       }
        //   }
        //   return newArr;
        //}
        #endregion

        #region Homerwork4- Verilmiş email-lər siyahısından domainlər siyahısı düzəldən metod.Domainlər arrayondə təkrarlanmamlıdır domainlər!
        //static string[] MakeEmail(string[] str)
        //{
        //    string[] newArray = new string[0];
        //    Array.IndexOf(str, '@');

        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        Array.IndexOf(newArray, str[i]);
 
        //    }
        //}

        #endregion

        #region Homework5+ Verilmiş yazının içindəki cümlələrin sayını tapan metod.
        //static int FindCount(string str)
        //{
        //  int count = 0;
        //  for (int i = 0; i < str.Length; i++)
        //  {
        //      if (str[i] == '!' || str[i] == '.' || str[i] == '?')
        //      {
        //          count++;
        //      }
        //  }
        //  return count;
        //}
        #endregion
    }
}
