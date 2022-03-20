// See https://aka.ms/new-console-template for more information

using GenericExample;
/*
StringStack stack = new StringStack();

stack.Push("Deepak");

Console.WriteLine(stack.Position);

Console.WriteLine(stack.Pop());

Console.WriteLine(stack.Position);

Console.WriteLine("---------------------");
stack.Push("Suraj");

Console.WriteLine(stack.Position);

Console.WriteLine(stack.Pop());

Console.WriteLine(stack.Position);


IntegerStack integerStack = new IntegerStack();

integerStack.Push(1);   
integerStack.Push(2);
integerStack.Push(3);
integerStack.Push(4);
Console.WriteLine($"Position: {integerStack.Position}");
Console.WriteLine(integerStack.Pop());
Console.WriteLine($"Position: {integerStack.Position}");

ObjectStack objectStack = new ObjectStack();    

objectStack.Push(1);
objectStack.Push(2);
objectStack.Push("StringInput");
objectStack.Push(new Person());
*/


GenericStack<int> genericStackOfInteger = new GenericStack<int>();
genericStackOfInteger.Push(1);
genericStackOfInteger.Push(2);


GenericStack<string> genericStringStack = new GenericStack<string>();
genericStackOfInteger.Push(1);
genericStackOfInteger.Push(2);


Console.ReadKey();  