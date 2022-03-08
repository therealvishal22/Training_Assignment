

    class Polymorphism_FunctionOverloading
    {
        public void demo()
        {
            Console.WriteLine("1st demo function in Polymorphism_FunctionOverloading class - no return type, no parameter.");
        }
        public void demo(int a)
        {
            Console.WriteLine("2nd demo function in Polymorphism_FunctionOverloading class - no return type, 1 integer parameter");
        }
        public void demo(int a, char b)
        {
            Console.WriteLine("3rd class Base_Cls)
    {
        public virtual void DemoFunction()
        {
            Console.WriteLine("Base_Cls Saying Hello!");
        }
        public void DemoFunction2()
        {
            Console.WriteLine("Base_Cls Saying Hello second time!");
        }
    }
    class Derived_Cls : Base_Cls
    {
        public override void DemoFunction()
        {
            base.DemoFunction();
            Console.WriteLine("Derived_Cls Saying Hello!");
        }
        public void DemoFunction2()
        {
            Console.WriteLine("Derived_Cls Saying Hello second time!");
        }

    }
    class Derived_Sub_Cls : Derived_Cls
    {
        public override void DemoFunction()
        {
            base.DemoFunction();
            Console.WriteLine("Derived_Sub_Cls Saying Hello!");
        }
        public void DemoFunction2()
        {
            Console.WriteLine("Derived_Sub_Cls Saying Hello second time!");
        }
    }

   // function in Polymorphism_FunctionOverloading class - no return type, 1 integer parameter + 1 character parameter.");
        
    

    Polymorphism_FunctionOverloading PolyFunOverLoading = new Polymorphism_FunctionOverloading();
PolyFunOverLoading.demo(); 
PolyFunOverLoading.demo(1); 
PolyFunOverLoading.demo(1, 'A'); 

// Function Overriding 

Base_Cls B_CLS = new Base_Cls();
B_CLS.DemoFunction(); 
B_CLS.DemoFunction2(); 

Derived_Cls D_CLS = new Derived_Cls();
D_CLS.DemoFunction(); 
D_CLS.DemoFunction2(); 

Derived_Sub_Cls DS_CLS = new Derived_Sub_Cls();
DS_CLS.DemoFunction(); 
DS_CLS.DemoFunction2(); 
Polymorphism_FunctionOverloading PolyFunOverLoading = new Polymorphism_FunctionOverloading();
PolyFunOverLoading.demo();
PolyFunOverLoading.demo(1); 
PolyFunOverLoading.demo(1, 'A'); 



