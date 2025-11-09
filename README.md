# Calculator and Shapes Tests

<pre>
 /\_/\    /\_/\    /\_/\
( o.o )  ( o.o )  ( o.o )
 > ^ <    > ^ <    > ^ <
</pre>

## <b>Overview</b>
This repository contains two lightweight <b>C#</b> modules designed to practice clean structure and unit testing with <b>NUnit</b>.

## <b>Shapes</b>
Implements four geometric classes: <b>Sphere</b>, <b>Cube</b>, <b>Cylinder</b>, and <b>Rectangle</b>.  
Each provides the following methods:  
<code>CalculateArea()</code> and <code>CalculateVolume()</code>

## <b>Calculator</b>
A simple arithmetic class performing operations:  
<code>+  -  *  /</code>  
Handles invalid operators and division by zero gracefully.

## <b>Testing</b>
Both modules are fully covered with <b>NUnit</b> test cases, verifying:
<ul>
<li>positive, negative, and zero values</li>
<li>decimal and boundary inputs (<code>double.MaxValue</code>, <code>double.MinValue</code>)</li>
<li>exceptions and stability under edge conditions</li>
</ul>
