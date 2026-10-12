namespace C_OOP06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region OOP05
            #region Theoretical Questions
            #region Object Copying
            /*  a) What happens when you assign one object variable to another object variable?
             *     Answer: When you assign one object variable to another, you copy the reference of the object, not the actual object itself.
             *     
             *  b) Does assigning one object to another create a new object? Explain
             *     Answer: No, assigning one object to another does not create a new object. It simply copies the reference of the same object in memory. 
             *             Both variables will point to the same instance, and any modifications made through one reference the other will be affect.
             *  
             *  c) What is the difference between copying an object and copying its reference?
             *     Answer: Copying an object creates a new instance of the object with the same values, means two objects are independent of each other. Any changes made to one object does't affect to the other. 
             *             On the other hand, copying its reference means that both variables point to the same object in memory, and changes made through one variable will affect the other since they refer to the same instance.
             */
            #endregion
            #region Shallow Copy vs Deep Copy
            /*  a) What is a Shallow Copy?
             *     Answer: A shallow copy creates a new object, and copies all value type fields, and reference type fields are copied as references not copies the objects they point to.
             * 
             *  b) What is a Deep Copy?
             *     Answer: A deep copy creates a new object and recursively copies all nested objects. This means that the deep copy and the original object are completely independent of each other.
             *
             *  c) What happens to reference-type members when a Shallow Copy is created?
             *     Answer: When a shallow copy is created, reference-type members are copied as references,
             *             This means that both the original object and the shallow copy will point to the same instance of the reference-type member.
             *             
             *  d) What happens to reference-type members when a Deep Copy is created?
             *     Answer: When a deep copy is created, reference-type members are recursively copied, creating new instances of the objects they point to. 
             *             This means that the deep copy and the original object are completely independent of each other.
             *             
             *  e) Give one situation where Deep Copy would be safer than Shallow Copy.
             *     Answer: when the object contains reference-type, if you want to modify the copied object, 
             *             A deep copy would be safer because when you want to modify in the copied object, the original object will not be affected, because they are independent of each other, 
             *             On the other hand, if you use a shallow copy, any changes made to the reference-type members in the copied object will also affect the original object, which can lead to unexpected behavior and bugs, because both objects share the same reference to the same instance of the reference-type member.
             */
            #endregion

            #region Static Members
            /*
             *  a) What is a static field, and how is it different from an instance field?
             *     Answer: Static field is a field that belongs to the class itself not to any instatnce. It is created only once and it is shared among all instances of the class, and it can be accessed using the class name without creating an instance of the class. 
             *             On the other hand, an instance field is a field that belongs to a specific instance of a class. Each instance of the class has its own copy of the instance field, and it can be accessed only through an instance of the class.
             *             
             *  b) What is a static method? Can a static method directly access instance members?
             *     Answer: A static method is a method that belongs to the class itself, rather than to any specific instance of the class. 
             *             It can be accessed using the class name without creating an instance of the class.
             *             
             *  c) What is a static constructor, and when is it executed?
             *     Answer: A static constructor is a special constructor that is used to initialize static members of a class. It is executed only once, before the first use of the class. 
             *     
             *  d) What is a static class? Can you create an object from a static class?
             *     Answer: A static class is a class that can only contain static members. Used to group related static members together. 
             *             A class declared as static cannot create objects from it. It can be accessed using the class name without creating an instance of the class. 
             */
            #endregion
            #endregion

            #region Practical Questions

            #region Object Copying
            // Demonstrate the difference between assigning one object variable to another and creating an actual copy.
            //Shipment originalStandard = new StandardShipment("S001", "Books", 5, 50, new DeliveryAddress("Cairo", "Tahrir", 10));

            //// Assigning reference
            //Shipment copyReferenceStandard = originalStandard;   // Assigning reference

            //Console.WriteLine(ReferenceEquals(originalStandard, copyReferenceStandard));  //True
            //copyReferenceStandard.Description = "Electronics";   // Modifying the copy
            //Console.WriteLine(originalStandard.Description);   // Output affected

            ////Actual copy
            //Shipment copyActualStandard = originalStandard.CopyShipment();   // Creating an actual copy
            //Console.WriteLine(ReferenceEquals(originalStandard, copyActualStandard));   // False
            //copyActualStandard.Description = "Clothing";    // Modifying the copy
            //Console.WriteLine(originalStandard.Description);   // Output not affected 
            #endregion

            #region Shallow copy
            //// Address converted to a class
            ////Demonstrate the Shallow Copy concept
            //Shipment original = new StandardShipment("S001", "Books", 5, 50, new DeliveryAddress("Cairo", "Tahrir", 10));
            //Shipment shallowCopy = original.ShallowCopy();
            //Console.WriteLine(ReferenceEquals(original, shallowCopy));   // False
            //Console.WriteLine(ReferenceEquals(original.Destination, shallowCopy.Destination));   // True
            //shallowCopy.Destination.city = "Alexandria";   // Modifying the copy
            //Console.WriteLine(original.Destination.city);   // Output affected
            #endregion

            #region Deep Copy
            ////Demonstrate the Deep Copy concept
            //Shipment original = new StandardShipment("S001", "Books", 5, 50, new DeliveryAddress("Cairo", "Tahrir", 10));
            //Shipment deepCopy = original.DeepCopy();
            //Console.WriteLine(ReferenceEquals(original, deepCopy));   // False
            //Console.WriteLine(ReferenceEquals(original.Destination, deepCopy.Destination));   // False
            //deepCopy.Destination.city = "Alexandria";   // Modifying the copy
            //Console.WriteLine(original.Destination.city);   // Output not affected
            #endregion
            #endregion
            #endregion
        }
    }
}
