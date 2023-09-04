namespace Local
{
    internal class Program
    {
        //Task1
        //static void Main(string[] args)
        //{
        //    // 1. Data source.
        //    int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };

        //    // 2. Query creation.
        //    var numQuery =
        //        from num in numbers
        //        where (num % 2) == 0
        //        select num;

        //    // 3. Query execution.
        //    foreach (int num in numQuery)
        //    {
        //        Console.Write("{0,1} ", num);
        //    }
        //}

        //Task2
        //static void Main(string[] args)
        //{
        //    List<int> list = new List<int>() { 1, 3, 6, 9, 10, 0, -1, -3, -6, -9, -10 };
        //    IEnumerable<int> filteringQuery =
        //      from num in list
        //      where num >= 1 && num <= 11
        //      select num;
        //    foreach (var i in filteringQuery)
        //        Console.Write(i + " ");
        //}

        //Task3
        //static void Main(string[] args)
        //{
        //    var arr = new[] { 6, 7, 8, 9 };

        //    var square = from int number in arr
        //                 let sqrno = number * number
        //                 where sqrno > 20
        //                 select new { number, sqrno };

        //    foreach (var a in square) Console.WriteLine(a);
        //}

        //Task4
        //static void Main(string[] args)
        //{
        //    int[] arr1 = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

        //    var n = from x in arr1
        //            group x by x into y
        //            select y;
        //    foreach (var arrNo in n)
        //    {
        //        Console.WriteLine("Number " + arrNo.Key + " appears " + arrNo.Count() + " times");
        //    }
        //}

        //Task5
        //static void Main(string[] args)
        //{
        //    int[] nums = new int[] { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };

        //    var m = from x in nums
        //            group x by x into y
        //            select y;

        //    foreach (var arrEle in m)
        //    {
        //        Console.WriteLine("Character " + arrEle.Key + ": " + arrEle.Count() + " times");
        //    }
        //}

        //Task6
        //static void Main(string[] args)
        //{
        //    string[] weekDay = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday","Sunday"};

        //    var day = from WeekDay in weekDay
        //              select WeekDay;
        //    foreach (var WeekDay in day)
        //    {
        //        Console.WriteLine(WeekDay);
        //    }
        //}

        //Task7
        //static void Main(string[] args)
        //{
        //    int[] num = new int[] { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };


        //    var nums = from x in num
        //               group x by x into y
        //               select y;

        //    foreach (var arrEle in nums)
        //    {
        //        Console.WriteLine(arrEle.Key + "\t" + arrEle.Sum() + "\t\t\t" + arrEle.Count());
        //    }
        //}

        //Task8
        //static void Main(string[] args)
        //{
        //    string chst, chen;
        //    char ch;
        //    string[] cities =
        //    {
        //        "LONDON","NAIROBI","CALIFORNIA","Azerbaijan","PARIS"
        //    };

        //    ch = 'L';
        //    chst = ch.ToString();
        //    ch = 'N';
        //    chen = ch.ToString();


        //    var _result = from x in cities
        //                  where x.StartsWith(chst)
        //                  where x.EndsWith(chen)
        //                  select x;
        //    foreach (var city in _result)
        //    {
        //        Console.Write("The city starting with {0} and ending with {1} is : {2} \n", chst, chen, city);
        //    }
        //}

        //Task9
        static void Main(string[] args)
        {
            List<int> templist = new List<int>();
            templist.Add(20);
            templist.Add(10);
            templist.Add(195);
            templist.Add(230);
            templist.Add(482);
            templist.Add(746);
            templist.Add(750);
            foreach (var lstnum in templist)
            {
                Console.Write(lstnum + " ");
            }
            List<int> FilterList = templist.FindAll(x => x > 80 ? true : false);
            Console.WriteLine("\n\nThe numbers greater than 80 are : ");
            foreach (var num in FilterList)
            {
                Console.WriteLine(num);
            }
        }

    }
}