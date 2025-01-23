using System;
using System.Runtime.Intrinsics.X86;
using static System.Net.Mime.MediaTypeNames;

namespace Assigment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region question1
            //Question 1:
            //What is the primary purpose of an interface in C#?
            //a) To provide a way to implement multiple inheritance
            //b) To define a blueprint for a class
            //c) To declare abstract methods and properties
            //d) To create instances of objects

            //Answer is > (b).. To define a blueprint for a class

            //  تعتبر "مخطط" أو "هيكل" للقوالب اللي المفروض الكلاسات تتبعها interface  الـ  . 
            // interface  فهي زي عقد بين الكلاس والـ
            //لازم يلتزم بيهاimplementاللي أي كلاس بيعمل لهاpropertiesوالـmethods  بمعنى إنها تحدد مجموعة من

            #endregion

            #region question2
            //Question 2:
            //Which of the following is NOT a valid access modifier for interface members in C#?
            //a) private
            //b) protected
            //c) internal
            //d) public

            //Answer is > (a).. private
            //protectedأو private ما ينفع تستخدم ،   
            // مش شيء مخفيpublic لازم تكون interfaceكل حاجه في ال

            #endregion

            #region question3
            //Question 3:
            //Can an interface contain fields in C#?
            //a) Yes
            //b) No
            //c) Only if they are static
            //d) Only if they are readonly

            //Answer is > (b).. No

            //blueprint مصممة لتكون 
            //داخل الكلاسvariablesالfieldsما يُمكنها احتواء الـinterface
            //اسمها كذا"، ولكنها لا تهتم كيف يتم تنفيذها أو من أين تأتي البيانات ( method أو property بمعني تحدد: "فيه
            #endregion

            #region question4
            //Question 4:
            //In C#, can an interface inherit from another interface?
            //a) No, interfaces cannot inherit from each other
            //b) Yes, interfaces can inherit from multiple interfaces
            //c) Yes, but only if they have the same methods
            //d) Only if the interfaces are in the same namespace

            //Answer is > (b).. iterfaces can inherit from multiple interfaces

            #endregion

            #region question5
            //Which keyword is used to implement an interface in a class in C#?
            //a) inherit
            //b) use
            //c) extends
            //d) implements

            //Answer is > (d).. implements
            #endregion

            #region question6
            //Question 6:
            //Can an interface contain static methods in C#?
            //a) Yes
            //b) No
            //c) Only if the interface is sealed
            //d) Only if the methods are private

            //Answer is > (a).. Yes
            // ممكن استخدمو عادي

            #endregion

            #region question7
            //Question 7:

            //In C#, can an interface have explicit access modifiers for its members?
            //a) Yes, for all members
            //b) No, all members are implicitly public
            //c) Yes, but only for abstract members
            //d) Only if the interface is sealed

            //Answer is > (b).. No, all members are implicitly public
            //implicitly publicتعتبر interface داخل الـ  methods و properties)  
            // private أو protected أو  internalلا يمكن استخدام

            #endregion

            #region question8
            //Question 8:
            //What is the purpose of an explicit interface implementation in C#?
            //a) To hide the interface members from outside access
            //b) To provide a clear separation between interface and class members
            //c) To allow multiple classes to implement the same interface
            //d) To speed up method resolution

            //Answer is >(b) To provide a clear separation between interface and class members
            // يجب أن تحدد أي واجهة تقصدclass()،هنا لو استدعيت :
            // 2 interface  مفيدًا لما يكون عندك
            //أو أكثر فيهما أعضاء بنفس الاسمهذا يكون

            #endregion

            #region question9
            //Question 9:

            //In C#, can an interface have a constructor?
            //a) Yes, but it must be private
            //b) No, interfaces cannot have constructors
            //c) Yes, but only if the interface is sealed
            //d) Only if the constructor is static

            //Answer is > (b) No.. interfaces cannot have constructors
            //constructors لا تحتوي على interfaces 
            //classes أو الـ structs. مسموحة فقط في  لأن الـ constructorsسيظهر خطأ الـ 

            #endregion

            #region question10
            // Question 10:
            //How can a C# class implement multiple interfaces?
            //a) By using the "implements" keyword
            //b) By using the "extends" keyword
            //c) By separating interface names with commas
            //d) A class cannot implement multiple interfaces


            //Answer is > (c).. By separating interface names with commas :... , ...

            #endregion

            #region part2
            //Question 01:
            //Define an interface named IShape with a property Area and a method DisplayShapeInfo.
            //Create two interfaces, ICircle and IRectangle,
            //that inherit from IShape.
            //Implement these interfaces in classes Circle and Rectangle.
            //Test your implementation by creating instances of both classes and displaying their shape information.

            //IShape circle = new Circle(5);//Raidus
            //circle.DisplayShapeInfo();

            //// Create a Rectangle object
            //IShape rectangle = new Rectangle(10, 4); //Width , Height
            //rectangle.DisplayShapeInfo();


            ////// لو اليوزر هو اللي هيدخل 
            //while (true)
            //{
            //    Console.WriteLine("Choose an option:");
            //    Console.WriteLine("1 - Calculate area of a circle");
            //    Console.WriteLine("2 - Calculate area of a rectangle");
            //    Console.WriteLine("0 - Exit");

            //    string choice = Console.ReadLine();

            //    if (choice == "0")
            //    {
            //        Console.WriteLine("Exiting the program. Goodbye!");
            //        break;
            //    }

            //    switch (choice)
            //    {
            //        case "1":
            //            Console.Write("Enter the radius of the circle: ");
            //            if (double.TryParse(Console.ReadLine(), out double radius) && radius > 0)
            //            {
            //                Circle ccircle = new Circle(radius);
            //                ccircle.DisplayShapeInfo();
            //            }
            //            else
            //            {
            //                Console.WriteLine("Invalid input. Please enter a positive numeric value for the radius.");
            //            }
            //            break;

            //        case "2":
            //            Console.Write("Enter the width of the rectangle: ");
            //            if (double.TryParse(Console.ReadLine(), out double width) && width > 0)
            //            {
            //                Console.Write("Enter the height of the rectangle: ");
            //                if (double.TryParse(Console.ReadLine(), out double height) && height > 0)
            //                {
            //                    Rectangle reectangle = new Rectangle(width, height);
            //                    reectangle.DisplayShapeInfo();
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Invalid input. Please enter a positive numeric value for the height.");
            //                }
            //            }
            //            else
            //            {
            //                Console.WriteLine("Invalid input. Please enter a positive numeric value for the width.");
            //            }
            //            break;

            //        default:
            //            Console.WriteLine("Invalid choice. Please select 1, 2, or 0 to exit.");
            //            break;
            //    }

            //}
            #endregion
        }
    }
}
