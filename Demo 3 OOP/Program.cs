using Demo_2_OOP.PolymorphismOverriding;
using Demo_3_OOP.Binding;
using Demo_3_OOP.Builtin_Interface;
using Demo_3_OOP.ExampleForBinding;
using Demo_3_OOP.Interface;
using System;

namespace Demo_3_OOP
{
    internal class Program
    {
        #region overriding
        //public static void ProcessEmployee(FullTimeEmployee emp)
        //{
        //    if (emp is not null)
        //    {
        //        emp.func1();
        //        emp.func2();
        //    }
        //}
        //public static void ProcessEmployee(PartTimeEmployee emp)
        //{
        //    if (emp is not null)
        //    {
        //        emp.func1();
        //        emp.func2();
        //    }
        //}

        //public static void ProcessEmployee(Employee emp)
        //{
        //    if (emp is not null)
        //    {
        //        emp.func1();
        //        emp.func2();
        //    }
        //}


        #endregion

        #region Interface
        //public static void print10numfromseries(SeriesBy2 series)
        //{
        //    // هلوب عشان يطبع 10 مرات
        //    //null مش ب series وهتاكد الاول ان ال

        //    if (series == null)
        //     Console.WriteLine("Series is null");

        //        for (int i = 0; i < 10; i++)
        //        {
        //            Console.WriteLine($"current num is:{series.current}\t");

        //            series.GrtNext();

        //        }
        //        series.Reset();
        //        Console.WriteLine();
        //}

        //public static void print10numfromseries(SeriesBy3 series)
        //{
        //    // هلوب عشان يطبع 10 مرات
        //    //null مش ب series وهتاكد الاول ان ال

        //    if (series == null)
        //        Console.WriteLine("Series is null");

        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine($"current num is:{series.current}\t");

        //        series.GrtNext();

        //    }
        //    series.Reset();
        //    Console.WriteLine();
        //}

        #endregion
        static void Main(string[] args)
        {
            #region Binding
            //overrload وoverriding ان عندي  polymarfism كنا قولنا ف ال
            // overriding كان عندي طريقتين عشان استخدم  ال 

            // 1- اول طريقه هخفي الفنكن الاساسيه اللي وارثها واعدل انا براحتي
            //هخفي الاصل new عن طريق استخدام كلمه  
            //public بعد new هعمل فنكشن عاديه بس هحط 

            //-------------------------------

            // 2- تاني طريقه هسيب الفنكن الاساسيه اللي وارثها واعدل انا براحتي
            //في الفنكشن الاساسيه  public virtual عن طريق استخدام كلمه
            //public بعد virtual هعدل ف الفنكشن الاساسيه  بس هحط 
            //to string ع ال override هجيبيها زي م كنت بعمل 

            // طب امتا استخدم دي وامتا دي
            //(public virtual)override وامتا استخدم ال new هو اللي هيعرفني امتا استخدم ال Binding ال
            //Binding الاختلاف الوحيد بينهم هيظهر ف كونسبت ال

            //Binding is behavior 
            //inheritance , encspsulation دا سلوك مش كونسبت زي ال
            // دا سلوك معين هستخدمه لما اعوزه behavior يعني اي

            //من نفس الكلاس او من كلاس وارث منه object من كلاس مؤهل انو يكون  reference دا عباره عن 
            // Reference from parent = object from chiled

            //Type_A refr;
            //refr = new Type_A(4); // >> not binding عشان من نفس الكلاس
            //refr = new Type_B(7 , 1); // >> is binding >> chiledعشان بيشاور علي كلاس ال
            ////Type_B type_B = refr; // invalid دا كده مينفعش
            //Type_B type_B = (Type_B)refr; //binding مش explicit casting  دا كده 


            #endregion

            #region Binding is behavior 
            ////inheritance , encspsulation دا سلوك مش كونسبت زي ال
            //// دا سلوك معين هستخدمه لما اعوزه behavior يعني اي
            ////جوا كلاسات بقا Binding هعمل فولدر اسمو

            ////ProcessEmployee هطلع فوق اهمل فنكشن اسمها
            //FullTimeEmployee full = new FullTimeEmployee();
            //full.Id = 7;
            //full.Name = "Test";
            //full.Age = 30;
            //full.Salary = 2000;
            //ProcessEmployee(full);

            ////part time هيكونو  employee طب جالي فجاه ان في 
            ////PartTimeEmployee هعمل كلاس تالت اسمو
            //Console.WriteLine("---------------------");
            //PartTimeEmployee part = new PartTimeEmployee();
            //part.Id = 7;
            //part.Name = "Test";
            //part.Age = 30;
            //part.HoureRate = 5;
            //ProcessEmployee(part);

            //// نفسه وهعمله فنكشن فوق employee وهبعت ال binding هعمل ال
            ////هلاقي عند ان
            ////emp.func1(); >> ststic binding >> i employee>employee اتطبعت زي كلاس ال
            ////emp.func2(); >> dymanic binding >> part , full اتطبعت زي كلاس ال



            #endregion

            #region important example for binding
            //ExampleForBinding هعمل فولدر اسمو

            //------ TypeA --------
            //TypeA a = new TypeC(7, 4, 3); //اللي هيتطبع input خدت ال
            //a.A = 10; // ب10  a اديت قيمه لل
            ////a.B = 20;// invalid
            ////a.C = 30;// invalid
            ////وبس Aمش هيشةف حاجه غير اللي فيه اللي هي  parent ده aعشان ال  invalid دول

            ////function نيجي لل
            //a.myFunc1(); // static binding >> i parent 
            //a.myFunc2(); // dynamci func >>A is: 10 , B is: 4,C is: 3

            //Console.WriteLine("------------------------");
            //------ TypeB --------
            //TypeB b = new TypeC(7, 4, 3); //اللي هيتطبع input خدت ال
            //b.A = 10; // ب10  a اديت قيمه لل
            //b.B = 20;
            ////b.C = 30;// invalid
            ////وبس B, Aمش هيشوف حاجه غير اللي فيه اللي هي  parent ده bعشان ال  invalid دي

            ////function نيجي لل

            //b.myFunc1(); // static binding >> i Chiled 
            //b.myFunc2(); // dynamci func >>A is: 10 , B is: 20 ,C is: 3

            //Console.WriteLine("------------------------");

            //----------------------
            //---------------------

            //TypeA A1 = new TypeE(7, 4, 3 , 15 , 23); //اللي هيتطبع input خدت ال
            //TypeB B1 = new TypeE(7, 4, 3 , 15 , 23); //اللي هيتطبع input خدت ال
            //TypeC C1 = new TypeE(7, 4, 3 , 15 , 23); //اللي هيتطبع input خدت ال
            //TypeD D1 = new TypeE(7, 4, 3 , 15 , 23); //اللي هيتطبع input خدت ال
            //TypeE E1 = new TypeE(7, 4, 3 , 15 , 23); //اللي هيتطبع input خدت ال

            //Console.WriteLine("funcA 1 \n");
            //A1.myFunc1();//static binding >> i A parent
            //Console.WriteLine("funcA 2 \n");
            //A1.myFunc2();//dynamci func >> Type C : A is: 7 , B is: 4, C is: 3

            //Console.WriteLine("funcB 1 \n");
            //B1.myFunc1();//static binding >> i B child
            //Console.WriteLine("funcB 2 \n");
            //B1.myFunc2(); //dynamci func >> Type C : A is: 7 , B is: 4, C is: 3

            //Console.WriteLine("funcC 1 \n");
            //C1.myFunc1(); //static binding >> i C Grand Parent
            //Console.WriteLine("funcC 2 \n");
            //C1.myFunc2(); //dynamci func >> Type C : A is: 7 , B is: 4, C is: 3

            //Console.WriteLine("After breale the chain");
            //Console.WriteLine("funcC 1 \n");
            //D1.myFunc1(); //static binding >> i D Grand Grand Parent
            //Console.WriteLine("funcC 2 \n");
            //D1.myFunc2(); //dynamci func >> Type D : A is: 7 , B is: 4 , C is: 3 , D is: 15 , E is: 23


            //Console.WriteLine("funcC 1 \n");
            //E1.myFunc1(); //static binding >>i E Grand Grand Grand Parent

            //Console.WriteLine("funcC 2 \n");
            //E1.myFunc2(); // dynamci func >> Type E : A is: 7 , B is: 4 , C is: 3 , D is: 15 , E is: 23



            #endregion

            #region Interface
            //  تعتبر "مخطط" أو "هيكل" للقوالب اللي المفروض الكلاسات تتبعها interface  الـ  . 
            // interface  فهي زي عقد بين الكلاس والـ
            //لازم يلتزم بيهاimplementاللي أي كلاس بيعمل لهاpropertiesوالـmethods  بمعنى إنها تحدد مجموعة من

            //blueprint مصممة لتكون 

            //مينفعش الكلاس يورث من كئا حاجه ف وقت واحد multiInheritance بص عشان تكون عارف انا معنديش حاجه اسمها
            //interface الكلاس الواحد جواه كذاmultiInterface بس عندي

            //هي عبارة عن "عقد" أو "اتفاقية" بتحدد إيه اللي الكلاس هيعمله، من غير ما تحدد إزاي. 
            //(implement it) اللي لازم الكلاس اللي "ينفذها"  يلتزم بيها.Properties وال Methods هي نوع خاص من الكود بيوصف مجموعة من الInterface 

            //Interface لازم يكتب كل الحاجات اللي موجودة في الـ Interface. الكلاس اللي بينفذ الـ  

            //بحدد فيه حاجات استخدمها بس مش محدداناهستخدمهاازاي لما بيجي اللي هيستخدمها هو اللي بيحدد بالطريقه اللي تناسبه هيستخدمها ازاي

            // Signature for .. الحاجات اللي هتتكت فيه اسمها

            //بالطريقه اللي تناسبهbodyبتاعها زي مقولنا كل واحد هيستخدمها هيكتب ال body مش بكتب ال methoud  ولما باجي اكتب 


            // Interface هعمل  فولدر اسمو
            //جاهز Interface ل اي ? كلاس ؟ لا عندي ADD هعمل
            // Add > new item > Interface
            //بعدين الاسم اللي عايزو I عشان اسميه ببدا بحرف ال

            //reference typeدي تعتبر Interface ال

            #region Example1
            //  IMy_Type my_Type;
            //null بيشاور علي IMy_Type من نوع refrence بعمل
            //Interface لل implement  من نوع كلاس او ستراكت بشرط يكةن بي object ممكن يشاور علي my_Type اللي هو  refrence ال
            //Interface يعني عادي يشاور علي كلاس او ستراكت يكون بينفذ ال 

            //interface من object مينفعش اعمل
            // my_Type = new IMy_Type();// invalid

            ////interfaceمن الكلاس او الاستراكت اللي بينفذ الobject  بس عادي اعمل
            //My_Type my_Type2 = new My_Type();
            //my_Type2.Salary = 10000;
            //my_Type2.MyFun();

            ////print ثابته كل مره ومش هتتغير كان اسمها Method طب يعم انا مش كان عندي      
            //// my_Type2.print(); > invalidمظهؤتش معايا ليه؟؟؟
            //// لازم عشان تظهر عندي اعدل شويه ف الطريقه اللي هنادي بيها

            ////Interface من الكلاس اللي بيتنفذ قيه ال object يكون بيشاور علي  Interface من ال refrence محتاج اعمل
            ////ومككن انادي علي بيقيه الحاجات بنفس الطريقه دي برضو
            //Console.WriteLine("---------");
            //IMy_Type refFromInterface = new My_Type();
            //refFromInterface.Print();
            //refFromInterface.MyFun();
            //refFromInterface.Salary = 50000;
            #endregion

            #region Example2
            //// عايز اعمل نمط كل مره يزود الرقم ب 2ويطبع 10 مرات
            ////Iseries اسمو  interface  هعمل 
            ////خلصت هنا بقا هروح اعمل فنكش برا تخليه يطبعلي ال 10 مرات
            //Console.WriteLine("print10numfromseries2");
            //SeriesBy2 series2 = new SeriesBy2();
            //print10numfromseries(series2);
            //// حلو وصلتى ل هنا ولقيته بيقولي اني لا مش عايز يزود رقيمن انا عايزو يزود ب 3 ارقام
            ////SeriesBy3هعمل كلاس جديد هسميه 
            //Console.WriteLine("print10numfromseries3");

            //SeriesBy3 series3 = new SeriesBy3();
            //print10numfromseries(series3);

            #endregion

            #region Example3
            ////مينفعش الكلاس يورث من كئا حاجه ف وقت واحد multiInheritance بص عشان تكون عارف انا معنديش حاجه اسمها
            ////interface الكلاس الواحد جواه كذاmultiInterface بس عندي

            //// المثال بتاعنا عندي طياره ب صفاتها وعندي عربيه ب صفاتها
            //// العربيه بتمشي ع الارض هعمل كلاس للارض ب صفاتها
            //// الطياره بتمشي ع الارض  الاول وبعدين بتطير ف الهوا المفروض ان الطياره هتاخد ضفات الكلاس الارض وتاخد صفات الكلاس بتاع الهوا
            ////interface عشان تاخد صفات كذا كلاس هستخدم

            ////عشان ندي كذا فنكشن interface انا هعمل ريفرينس من ال
            //Console.WriteLine("IMoveable Airplane");
            //IMoveable moveable = new AirPlane();//interface ريفرينس من ال
            //AirPlane airplane = (AirPlane)moveable;// ضبط سرعة الطائرة أثناء الحركه علي الارض//class ريفرينس من ال
            //airplane.Speed = 500;
            //Console.WriteLine($"AirPlane speed while moving on the ground is : {airplane.Speed}");

            //moveable.Backward();
            //moveable.Forward();
            //moveable.Left();
            //moveable.Right();

            //Console.WriteLine("\n");

            //Console.WriteLine("IFlyable Airplane");
            //IFlyable flyable = new AirPlane();//interface ريفرينس من ال

            //AirPlane flyableAirplane = (AirPlane)flyable;
            //flyableAirplane.Speed = 600; // ضبط سرعة الطائرة أثناء الطيران//class ريفرينس من ال
            //Console.WriteLine($"AirPlane speed while air is : {flyableAirplane.Speed}");

            //flyable.Backward();
            //flyable.Forward();
            //flyable.Left();
            //flyable.Right();

            //Console.WriteLine("\n");

            //Console.WriteLine("IMoveable Car");
            //IMoveable moveablcar = new Car();//interface ريفرينس من ال

            //Car carspead = (Car)moveablcar;// ضبط سرعة الارض أثناء الحركه علي الارض//class ريفرينس من ال
            //carspead.Speed = 500;
            //Console.WriteLine($"Car speed while moving on the ground isis : {carspead.Speed}");

            //moveablcar.Backward();
            //moveablcar.Forward();
            //moveablcar.Left();
            //moveablcar.Right();


            #endregion


            #endregion

            #region Shallow Copy , Deep Copy
            //int[] Arr01 = { 1, 2, 3 };
            //int[] Arr02 = { 4, 5, 6 };
            //Console.WriteLine($"HashCode Of Array 01 ={Arr01.GetHashCode()}");
            //Console.WriteLine($"HashCode Of Array 02 ={Arr02.GetHashCode()}");
            ////مختلف object هنا دول كل واحد فيهم بيشاور علي 
            #region Shallow Copy
            //Arr02 = Arr01;
            //// This Object {1,2,3} Has 2 Refernces [Arr01, Arr02] (اسمين دلع)
            //// This Object {4,5,6} Became Unreachable Object // بقا فاضي مش بيشاور علي حاجه

            //// Sallow Copy ده كده اسمو
            //Console.WriteLine("After Sallow Copy");
            //Console.WriteLine($"HashCode Of Array 01 ={Arr01.GetHashCode()}");
            //Console.WriteLine($"HashCode Of Array 02 ={Arr02.GetHashCode()}");
            //// بقو بيشاورو ع نفس الهاش كود 
            //Arr02[0] = 100;
            //Console.WriteLine(Arr01[0]);//100
            //// لو عدلت ف قيمه حاجه هتسمع ف الاتنين
            #endregion

            #region Deep Copy
            //// انا هستخدمو عشان لو عايز اعدل ف حاجه متسمعش ف الباقي
            ////clone اللي بتعملي كده اسمها methoud ال
            //Arr02 = (int[])Arr01.Clone();
            //// جديد خالص ف مكان جديد خالص تحط فبه القيم دي object بتكريت         
            ////عشان تشتغل casting بس انا محتاج اعملهها

            //Console.WriteLine("After Deep Copy");
            //Console.WriteLine($"HashCode Of Array 01 ={Arr01.GetHashCode()}");
            //Console.WriteLine($"HashCode Of Array 02 ={Arr02.GetHashCode()}");
            ////مختلف HashCodeلوحدو ب object كل واحد منهم بقا ف 
            //Arr02[0] = 100;
            //Console.WriteLine(Arr01[0]);//1
            //// لو عدلت ف قيمه حاجه مش هتسمع ف الاتنين

            #endregion

            #endregion

            #region IClonable
            // built in interface هنكلم عن
            //built in interface هعمل فولدر اسمو

            //Emp employee01 = new Emp()
            //{
            //    Id = 10,
            //    Name = "Rana",
            //    Salary = 7000
            //};

            //Emp employee02 = new Emp()
            //{
            //    Id = 10,
            //    Name = "Hatem",
            //    Salary = 4000

            //};

            //Console.WriteLine($" HasCode Of Employee01 = {employee01.GetHashCode()}");
            //Console.WriteLine($" HasCode Of Employee01 = {employee02.GetHashCode()}");
            //// كل واحد منهم موجود ف مكان مختلف

            #region Copy with Deep copy
            //Emp employee02 = employee01.Clone();// invalid
            ////object كانت متعرفه عندي انا دلوقتي عايو استخدمها جوا ال colone طب ال
            ////IClonable هحتاج اعرفها جوا الكلاس واورثها من كلاس اسمة
            //employee02 = (Emp)employee01.Clone();//الاساسي Emp محتاج اعملها كاست علي كلاس ال
            //                                     //جديد Object  كده عملت

            //Console.WriteLine("After Deep Copy");
            //Console.WriteLine($" HasCode Of Employee01 = {employee01.GetHashCode()}");
            //Console.WriteLine($" HasCode Of Employee01 = {employee02.GetHashCode()}");
            //// كل واحد منهم موجود ف مكان مختلف
            //Console.WriteLine("------------");
            //Console.WriteLine(employee02);
            //Console.WriteLine(employee01);
            ////شايلين نفس الحاجه

            #endregion

            #region copy with constructor
            //employee02 = new Emp(employee01);

            //Console.WriteLine("After copy with constructor");
            //Console.WriteLine($" HasCode Of Employee01 = {employee01.GetHashCode()}");
            //Console.WriteLine($" HasCode Of Employee01 = {employee02.GetHashCode()}");
            //// كل واحد منهم موجود ف مكان مختلف
            //Console.WriteLine("------------");
            //Console.WriteLine(employee02);
            //Console.WriteLine(employee01);

            #endregion

            #endregion

            #region IComparable
            //// هنقارن شويه حاجات ببعض
            //int[] num = { 1, 2, 7, 15, 3, 0 };
            //Array.Sort(num);
            //foreach (int i in num)
            //{
            //    Console.WriteLine(i);
            //}
            ////بقا هعمل ايobject  طب لو عمدي 
            ////Emp هشتغل عل كلاس ال
            //Emp[] emps =
            //{

            //       new Emp(){ Id =10 , Name = "Hamada" , Salary = 1000},
            //       new Emp(){ Id =20 , Name = "mohamed" , Salary = 50000},
            //       new Emp(){ Id =30 , Name = "reda" , Salary = 40000}
            //};

            //int result = emps[0].CompareTo(emps[1]);
            //// هقارن اول واحد ب التاني لو اكبر هيطلع واحد لو اصغير -1 لة اد بعض هيطلع 0
            //Console.WriteLine(result);//-1

            //// System.InvalidOperationException: Failed to compare two elements in the array.
            ////--->System.ArgumentException: At least one object must implement IComparable.

            ////compare to لازم يكون عندي فنكشن اسها  sort عشان يحصل مقارنه باستخدام
            ////compare to ف معنديشobject العاديه انما لو عنديarray دي بتبق مةجةده ع ال 
            ////وبالتالي كده مش هعرف اقارن
            //// طب الحل ايه

            ////copy عشان اعمل  ICloneable زي م استخدمت ال
            ////واقارن compare  عشان اعمل  IComparable هستخدم ال

            //// هروح انادي عليها ف الكلاس

            #endregion

            #region IComparer
            //عشان اقارن كلاس ب كلاس مختلف 
            //EmpIComparer هعملل كلاس جديد اسمو
            //Emp[] emps =
            //{

            //       new Emp(){ Id =10 , Name = "Hamada" , Salary = 1000},
            //       new Emp(){ Id =20 , Name = "mohamed" , Salary = 50000},
            //       new Emp(){ Id =30 , Name = "reda" , Salary = 40000}
            //};
            //Array.Sort(emps, new EmpIComparer());
            //foreach (Emp emp in emps)
            //{
            //    Console.WriteLine(emp);
            //}
            #endregion







        }














    }
}
