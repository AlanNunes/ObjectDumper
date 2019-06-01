# AN.ObjectDumper
Declare a string variable and call the static method **Dump** from **ObjectDumper** class
```c#
string result = "";
ObjectDumper.Dump(object obj, ref string result, int depth);
```
<p><em>obj</em> is the object you desire to dump.</p>
<p><em>result</em> is where the dumper is going to be written.</p>
<p><em>depth</em> is the depth of the dump. Usually <code>depth = 1</code> is enough.</p>

# Nuget Package
[Nuget package](https://www.nuget.org/packages/AN.ObjectDumper/)
