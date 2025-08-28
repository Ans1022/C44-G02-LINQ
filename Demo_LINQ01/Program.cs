using System.Collections;
using System.Text.RegularExpressions;

namespace Demo_LINQ01
{
    internal class Program
    {
        public static object ProductList { get; private set; }

        static void Main(string[] args)
        {
            #region Implicitly-Type Local Variables [var - dynamic]
            // Var : C# KeyWord

            //var Data01 = "Anas";

            // Compiler Can Detect DataType Of The Local Varibales Based On Initial Value
            //Must Be Initialized
            //Can't Initialized the Local Varibales With Null
            //Can't Change Datatype of the Local Varibales With Afetr Initialized

            /////////////////////////////////////////////////////////////////////////////////////////

            //dynamic
            // At RUNTime

            //dynamic Data02 = "Mohamed";

            //Data02 = 12;
            //Console.WriteLine(Data02.GetType().Name);
            //Data02 = 1.5;
            //Console.WriteLine(Data02.GetType().Name);
            //Data02 = true;
            //Console.WriteLine(Data02.GetType().Name);


            #endregion

            #region Anonymous Type
            //Employee E01 = new Employee() { Id = 12, Name = "Anas", Salary = 12200 };

            //var E01 = new { Id = 12, Name = "Anas", Salary = 12200 };
            //var E02 = new { Id = 2, Name = "Anas", Salary = 12200 };
            //Console.WriteLine(E01.Id);
            //Console.WriteLine(E01.Name);
            //Console.WriteLine(E01.Salary);

            //E01.Id = 12; // Invalid

            //var E01 = E02 With {Id = 2}; // new Feature C# 10.0 


            #endregion

            #region Extension Methods
            //int Number = 12345;

            //var result = IntExtension.Reverse(Number); // Class Member Methods
            //Console.WriteLine(result);

            // Number.Reverse();  // Extension Methods
            #endregion

            #region What is LINQ
            // Language Intergrated Query
            // 40+ EXM Against Ant Data [Data in Sequence]
            // LINQ opertors Exists Bulit_in Class "Enumerable"

            //================

            //Sequence : Object From Class implement Interface "IEnumerable"
            // Local Sequence : L20 / l2XMl
            // Remote Sequence : l2Ef

            // Input Sequence => linq opertors => oupet Sequence
            //                => linq opertors => One Value 
            //                => linq opertors => oupet Sequence

            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            //var result = Enumerable.Where(Numbers, N => N  % 2 == 0);
            //var result = Enumerable.Any(Numbers, N => N  % 2 == 0);
            //var result = Enumerable.Range(0, 100);

            //foreach (int N in result)
            //{
            //    Console.WriteLine($"N : {N}");
            //}

            //Console.WriteLine(result);



            #endregion

            #region LINQ Syntax
            //1.Fluent Syntax
            //Use LinQ Methods 

            //1.1 LiNQ Opertors as => Class Member methods through Class "IEnumerable"
            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5 , 6 , 7, 8, 9, 10};
            //var result = Enumerable.Where(Numbers, X => X % 2 == 0);

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Number{item}");
            //}

            //1.2 LiNQ Opertors as => Extension Methods

            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var result = Numbers.Where(X => X % 2 == 0);
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Number{item}");
            //}



            //2. Query Syntax : Like SQL Sytle
            //Start : From 
            //End : Select : groub By


            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var result = from N in Numbers
            //             where N % 2 == 0
            //             select N;
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Number{item}");
            //}
            #endregion

            #region LINQ Execution Ways
            //1.Differed Execution Ways : 10 Category
            //2.Immediate Execution Ways : 3 Category[Elements opertors , Casting opertors , Aggregate opertors ]

            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var result = Numbers.Where(X => X % 2 == 0); //Differed

            //Numbers.AddRange(new int[]{11,12,13,14,15 });

            //foreach (var item in result) // here
            //{
            //    Console.WriteLine($"Number{item}");
            //}

            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var result = Numbers.Where(X => X % 2 == 0).ToList(); //Immediate

            //Numbers.AddRange(new int[] { 11, 12, 13, 14, 15 });

            //foreach (var item in result) // here
            //{
            //    Console.WriteLine($"Number : {item}");
            //}
            #endregion

            #region Setup Data
            //Console.WriteLine(ListGenerator.ProductList[0]);
            //Console.WriteLine(ListGenerator.CustomerList[0]);

            //var result = ListGenerator.ProductList.Where(P => P.UnitsInStock == 0);
            //foreach (var item in result) Console.WriteLine(item);

            //var result = ListGenerator.CustomerList.Where(C => C.City == "Berlin");
            //foreach (var item in result) Console.WriteLine(item);

            #endregion

            ////////////////////////////////////(Demo02)///////////////////////////////////////////////////

            #region Filtration Operator - Where & OfType
            //var result = ProductList.Where(P => P.UnitsInStock == 0);

            //Query Syntax
            //var result = from P in ProductList
            //             where P.UnitsInStock == 0
            //             select P;

            // var result = ProductList.Where(P => P.Category == "Meat/Poultry");

            //var result = from P in ProductList
            //             where P.UnitsInStock > 0 && P.Category == "Meat/Poultry"
            //             select P;

            // var result = ProductList.Where((P, Index) => Index < 10 && P.UnitsInStock == 0 );
            //var result = ProductList.Where((P, Index) => Index < 5);

            //ArrayList arrayList = new ArrayList() { 1, 2, 3, "Ahmed", "Ali", 1.3, 1.5, 1.7f , 1.8f, 2.4m , 4.6m , ProductList[0] , ProductList[1] };
            //arrayList.OfType<Product>();
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region Transformation Operators - Select, SelectMany
            // var res = ProductList.Select(P => P);
            //var res = ProductList.Select(P => P.ProductName);
            //var res = from P in ProductList
            //          select P.ProductName;


            //var res = ProductList.Where(P => P.UnitsInStock > 0 && P.Category == "Seafood")
            //                     .Select(P => new
            //                     {
            //                         P.ProductName,
            //                         P.Categoy,
            //                         OldPrice = P.UnitPrice,
            //                         NewPrice = P.UnitPrice - P,
            //                         UnitPrice * 1.0M
            //                     });




            //var res = CustomerList.Select(C => C.CustomerName);
            //var res = CustomerList.Select(C => C.Orders);
            //var res = CustomerList.SelectMany(C => C.Orders);

            //var res = from C in CustomerList
            //          from O in C.Orders
            //          where O;

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region Ordering Operators

            // var res = ProductList.OrderBy(P => P.UnitPrice);
            // var res = ProductList.OrderBy(P => P.UnitPrice).Select(P => new {P.ProductName , P.UnitPrice , P.UnitsInStock })


            //var res = from P in  ProductList
            //          orderby P.UnitsInStock descending
            //          select P;

            //var res = from P in  ProductList
            //          orderby P.UnitsInStock ascending
            //          select P;


            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}


            //foreach (var item in ProductList)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Element Operators - Immediate Execution

            //ProductList = new List<Product>();


            //var res = ProductList.First();
            //var res = ProductList.Last();



            // var res = ProductList.First(P => P.UnitsInStock == 1000 );
            //var res = ProductList.Last(P => P.UnitsInStock == 0);

            // var res = ProductList.FirstOrDefault();
            //var res = ProductList.FirstOrDefault(new Product() { ProductName = "Default Product" });
            //var res = ProductList.FirstOrDefault(p => p.UnitsInStock == 0);

            //Console.WriteLine(res?.ProductName ?? "NA");
            //Console.WriteLine(res);

            //var res = ProductList.ElementAt(0);
            //var res = ProductList.ElementOrDefault(1);

            //ProductList = new List<Product>() { new Product() { ProductName = "Only One Prodect " } };

            //var res = ProductList.Single(p => p.UnitsInStock == 0);
            // var res = ProductList.DefaultIfEmpty();

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Aggregate Operators - Immediate Execution
            // Count / Max / Sum / Min / Avg
            //var res = ProductList.Count();//77
            //var res = ProductList.Count;

            // var res = ProductList.Count(P => P.UnitsInStock == 0);//5
            //Console.WriteLine(res);

            //var res = ProductList.Sum(P => P.UnitPrice);
            //var res = ProductList.Sum(P => P.UnitsInStock);

            //var res = ProductList.Average(P => P.UnitPrice);


            //var res = ProductList.Max(P => P.UnitPrice);

            //var MaxPrice = ProductList.Max(P => P.UnitPrice);
            // ProductList.Where(P => P.UnitPrice == MaxPrice)

            //Console.WriteLine(res);

            #endregion

            #region Casting Operators - Immediate Execution
            //List<Product> list = (List<Product>)ProductList.Where(P => P.UnitsInStock == 0);
            //List<Product> list = ProductList.Where(P => P.UnitsInStock == 0).ToList();
            //Product[] list = ProductList.Where(P => P.UnitsInStock == 0).ToArray();
            //Dictionary<long, Product> list = ProductList.Where(P => P.UnitsInStock == 0).ToDictionary(P => P.ProdectId);
            //foreach (var p in list)
            //{
            //    Console.WriteLine(p);
            //}
            #endregion

            #region Generation Operators
            // var res = Enumerable.Range(1, 8);
            // var res = Enumerable.Empty<Product>().ToList;

            //res.Add(new Product() { ProductName = "Prodect01" });

            //var res = Enumerable.Repeat(ProductList[0], 5);

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Set Operators
            //var Sq01 = Enumerable.Range(1, 200);
            //var Sq02 = Enumerable.Range(10, 300);

            //var res = Sq01.Union(Sq02);
            //var res = Sq01.Concat(Sq02);
            //res = res.Distinct();

            //var res = Sq01.Intersect(Sq02);
            //var res = Sq01.Except(Sq02);


            //foreach (var item in res)
            //{
            //    Console.WriteLine($"{item}");
            //}
            #endregion

            #region Quantifier Operators - Return Boolean
            // var Sq01 = Enumerable.Range(1, 100);
            // var Sq02 = Enumerable.Range(50, 100);


            // ProductList  = new List<Product>();
            //var res = Sq01.Any(N => N % 2 == 0 );
            // var res = ProductList.Any(P => P.UnitsInStock == 0);


            //var res = ProductList.All(P => P.UnitsInStock == 0);
            //var res = ProductList.All(P => P.UnitsInStock > 0);

            //SquenceEqules()

            //var res = Sq01.SequenceEqual(Sq02);

            //var res = Sq02.Contains(2);


            //Console.WriteLine(res);
            #endregion

            #region Zip Operator
            //List<string> Words = new List<string>() {"Ten" , "Twenty" ,  "Thirty" ,  "Fourty" };

            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };

            //var res =  Words.Zip(Numbers, (W, N) => $"{N} --> {W} ");

            //foreach (var item in Numbers)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Grouping Operators
            //var res = ProductList.GroupBy(P => P.Category);

            //    res = from p in ProductList
            //          groub p by P.category;

            //foreach (var Category in res)
            //{
            //    Console.WriteLine(Category.Key);
            //    foreach (var Product in Category)
            //    {
            //        Console.WriteLine($"...{Product}");
            //    }
            //}

            //var res = from P in ProductList
            //          where P.UnitsInStock > 0
            //          group P by P.Category
            //          into Category
            //          where Category.Count() > 10
            //          select Category;


            //foreach (var Category in res)
            //{
            //    Console.WriteLine(Category.Key);
            //    foreach (var Product in Category)
            //    {
            //        Console.WriteLine($"...{Product}");
            //    }
            //}

            #endregion

            #region Partitioning Operators
            //var res = ProductList.Where(P => P.UnitsInStock == 0).Take(3);
            //var res = ProductList.TakeLast(5);

            //var res = ProductList.Skip(5).Take(5);

            //int[] numbers = { 10, 20, 30, 40, 50, 60 };
            // numbers.TakeWhile((N) => N % 3 == 0);
            // numbers.SkipWhile((N) => N % 3 == 0);

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Let and Into
            //List<string> names = new List<string>() { "Anas", "Ahmed" , "Mohamed" , " Wale" };

            //var res = from name in names
            //          select Regex.Replace("Ahmed", "[aeoiuAEOIU]", string.Empty)
            // into NoVolNames
            //          where NoVolNames.Length > 3
            //          select NoVolNames;

            //foreach (var name in res)
            //{
            //    Console.WriteLine(name);
            //}

            #endregion










        }
    }
}
