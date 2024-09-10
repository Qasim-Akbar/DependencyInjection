using DependencyInjection;

var log1 = new ClassB();
var var1 = new ClassA(log1);
var1.Run();