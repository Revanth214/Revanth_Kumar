using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundamentals_Type_Object_Reference
{

    class Student
    {
        // --------------------------------------------------
        // INSTANCE MEMBERS
        // --------------------------------------------------

        public string Name;
        // Name is an INSTANCE FIELD.
        // Every Student object gets its own Name field.


        public int Age;
        // Age is also an INSTANCE FIELD.
        // Every Student object gets its own Age field.


        // --------------------------------------------------
        // STATIC MEMBER
        // --------------------------------------------------

        public static int StudentCount;
        // StudentCount is a STATIC FIELD.
        // It belongs to the Student TYPE, not to individual objects.
        // There is only ONE StudentCount shared by all Student objects.


        // --------------------------------------------------
        // INSTANCE METHOD
        // --------------------------------------------------

        public void Study()
        {
            // Study() is an INSTANCE METHOD.
            // It can be called through a Student object/reference.

            Console.WriteLine(Name + " is studying.");
            // Name refers to the Name of the particular object
            // on which Study() was called.
        }


        // --------------------------------------------------
        // STATIC METHOD
        // --------------------------------------------------

        public static void ShowStudentCount()
        {
            // ShowStudentCount() is a STATIC METHOD.
            // It belongs to the Student TYPE.
            // Therefore, it doesn't require a particular Student object.

            Console.WriteLine(StudentCount);
            // Accessing the static field through the type.
        }
    }


    class Program
    {
        static void Main()
        {
            // ==================================================
            // 1. TYPE
            // ==================================================

            // Student is a TYPE.
            // The Student class defines what Student objects can contain
            // and what they can do.


            // ==================================================
            // 2. CREATE AN OBJECT
            // ==================================================

            Student s1 = new Student();

            // Student
            //   ↑
            //   Type of the variable/reference
            //
            // s1
            //   ↑
            //   Reference variable
            //
            // new Student()
            //   ↑
            //   Creates a NEW Student object.
            //
            // After this statement:
            //
            // s1 ───────────→ Student Object #1


            // ==================================================
            // 3. CREATE ANOTHER OBJECT
            // ==================================================

            Student s2 = new Student();

            // Another NEW Student object is created.
            //
            // Now:
            //
            // s1 ───────────→ Student Object #1
            //
            // s2 ───────────→ Student Object #2
            //
            // s1 and s2 are two different reference variables.
            // They refer to two different objects.


            // ==================================================
            // 4. INSTANCE MEMBERS
            // ==================================================

            s1.Name = "Revanth";
            // Accessing the Name INSTANCE FIELD of Object #1.
            //
            // Object #1:
            // Name = "Revanth"


            s1.Age = 25;
            // Accessing the Age INSTANCE FIELD of Object #1.
            //
            // Object #1:
            // Name = "Revanth"
            // Age  = 25


            s2.Name = "Kumar";
            // Accessing the Name INSTANCE FIELD of Object #2.
            //
            // Object #2:
            // Name = "Kumar"


            s2.Age = 26;
            // Accessing the Age INSTANCE FIELD of Object #2.


            // IMPORTANT:
            //
            // s1.Name and s2.Name are DIFFERENT fields.
            //
            // Object #1:
            // Name = "Revanth"
            //
            // Object #2:
            // Name = "Kumar"


            // ==================================================
            // 5. INSTANCE METHOD
            // ==================================================

            s1.Study();
            // Calling the INSTANCE METHOD through s1.
            //
            // Because s1 refers to Object #1,
            // Study() works with Object #1's state.
            //
            // Output:
            // Revanth is studying.


            s2.Study();
            // Calling the same INSTANCE METHOD through s2.
            //
            // Now Study() works with Object #2's state.
            //
            // Output:
            // Kumar is studying.


            // Notice:
            //
            // We didn't create separate Study() methods like:
            //
            // Object #1 → its own Study()
            // Object #2 → its own Study()
            //
            // Study() is defined by the Student TYPE.
            // The particular object is the target of the call.


            // ==================================================
            // 6. STATIC MEMBER
            // ==================================================

            Student.StudentCount = 2;

            // Student
            //   ↑
            //   Type
            //
            // StudentCount
            //   ↑
            //   Static field
            //
            // We access a static member through the TYPE,
            // because it belongs to the Student type.
            //
            // There is ONE StudentCount shared by the type.


            Console.WriteLine(Student.StudentCount);
            // Output:
            // 2


            // ==================================================
            // 7. STATIC METHOD
            // ==================================================

            Student.ShowStudentCount();

            // ShowStudentCount() is a STATIC METHOD.
            //
            // It belongs to Student itself,
            // so we call it through the TYPE:
            //
            // Student.ShowStudentCount()
            //
            // We don't need:
            //
            // s1.ShowStudentCount()
            //
            // because the method doesn't belong to one particular
            // Student object.


            // ==================================================
            // 8. TWO REFERENCES TO THE SAME OBJECT
            // ==================================================

            Student s3 = s1;

            // IMPORTANT:
            //
            // This does NOT create a new Student object.
            //
            // It copies the reference stored in s1 into s3.
            //
            // Therefore:
            //
            // s1 ──────────┐
            //              ↓
            //        Student Object #1
            //              ↑
            // s3 ──────────┘
            //
            // s1 and s3 refer to the SAME object.


            s3.Name = "Changed";

            // s3 and s1 refer to the SAME object.
            //
            // Therefore, changing through s3 also changes
            // the object that s1 refers to.


            Console.WriteLine(s1.Name);

            // Output:
            // Changed
            //
            // Why?
            //
            // s1 ──────┐
            //          ↓
            //      SAME OBJECT
            //          ↑
            // s3 ──────┘


            // ==================================================
            // FINAL MENTAL MODEL
            // ==================================================

            /*

                         Student TYPE
                  ┌─────────────────────────┐
                  │                         │
                  │ StudentCount            │
                  │     ↑                   │
                  │   STATIC                │
                  │                         │
                  │ Study()                 │
                  │ ShowStudentCount()      │
                  │     ↑                   │
                  │   methods defined       │
                  │   by the type           │
                  └───────────┬─────────────┘
                              │
                     creates objects
                        through new
                              │
                  ┌───────────┴───────────┐
                  ↓                       ↓

            Student Object #1        Student Object #2
            ┌─────────────────┐      ┌─────────────────┐
            │ Name = Changed  │      │ Name = Kumar    │
            │ Age = 25        │      │ Age = 26        │
            └─────────────────┘      └─────────────────┘
                  ↑                       ↑
                 s1                      s2
                  ↑
                 s3
            (s1 and s3 refer to
             the same object)

            */


            // ==================================================
            // THE CORE RULES
            // ==================================================

            /*

            Student
                → TYPE / CLASS

            new Student()
                → CREATES AN OBJECT

            s1 / s2 / s3
                → REFERENCE VARIABLES

            Name / Age
                → INSTANCE FIELDS
                → Each object has its own copy

            Study()
                → INSTANCE METHOD
                → Called through an object/reference

            StudentCount
                → STATIC FIELD
                → One shared member associated with the type

            ShowStudentCount()
                → STATIC METHOD
                → Called through the type

            s3 = s1
                → Copies the reference
                → Does NOT create another object

            */

            Console.ReadLine();
        }
    }
}


/*
 


new → creates an object.

Object → has its own instance state.

Reference variable → refers to an object.

Instance member → associated with each object.

Static member → associated with the type.

Two new expressions → two objects.

s2 = s1 → two references, one object. 


 */


