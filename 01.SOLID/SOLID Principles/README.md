<h1>Single Responsibility Principle</h1>
<p><strong>What is Single Responsibility?</strong></p>
<br/>
<p>Every class should be responsible <strong>for only a single part of the functionality</strong> and that responsibility should be entirely <strong>encapsulated</strong> by the class.</p>
<br/>
<p align="right">"There should never be more than one reason for a class to change."<br/>- Robert C. "Uncle Bob" Martin</p>

<br/>

<p><strong>Cohesion</strong> ...</p>
<ul>
	<li><strong>Cohesion</strong> refers to the grouping of <strong>functionally related processes</strong> into a particular module.</li>
	<li>Aim for <strong>strong cohesion</strong></li>
	<ul>
		<li>Each <strong>task</strong> maps a <strong>single</strong> code unit</li>
		<li>A method should do <strong>one operation</strong></li>
		<li>A class should represent <strong>one entity</strong></li>
	</ul>
</ul>

<br/>

<p><strong>Coupling</strong> ...</p>
<ul>
	<li><strong>Coupling</strong> – the degree of dependence between modules</li>
		<ul>
			<li>How closely connected two modules are</li>
			<li>The strength of the relationship between modules</li>
		</ul>
	<li>Aim for <strong>loose</strong> coupling</li>
		<ul>
			<li>Supports <strong>readability</strong> and <strong>maintainability</strong></li>
			<li>Often a sign of good system <strong>design</strong></li>
		</ul>
</ul>

<br/>

<p><strong>Cohesion and Coupling - Approaches</strong></p>
<ul>
	<li><strong>Small number</strong> of instance variables inside a class</li>
	<li>Each method of a class should manipulate <strong>one or more</strong> of those variables</li>
	<li>Two modules should <strong>exchange</strong> as <strong>little information</strong> as possible</li>
	<li>Creating an <strong>easily reusable</strong> subsystem </li>
</ul>

<br/>



<h1>Open/Close Principle</h1>
<p><strong>What is the Open/Closed Principle?</strong></p>

<br/>
<ul>
	<li>Software entities like <strong>classes</strong>, <strong>modules</strong> and <strong>functions</strong> should be <strong>open</strong> for <strong>extension</strong>, 
	but <strong>closed</strong> for <strong>modifications</strong></li>
	<li><strong>Extensibility</strong></li>
		<ul>
			<li>Adding a new behavior <strong>doesn't require</strong> changes over existing source code</li>
		</ul>
	<li><strong>Reusability</strong></li>
		<ul>
			<li>subsystems are <strong>suitable for reusing</strong> in other projects – modularity</li>
		</ul>
</ul>

<br/>
<p><strong>Design Smell - Violations</strong></p>
<ul>
	<li>Need to <strong>retest</strong> after changes</li>
		<ul>
			<li>Old parts changed -> possible bugs</li>
		</ul>
	<li><strong>Cascading changes</strong> through modules</li>
	<li>Logic depends on <strong>conditional statements</strong> (“<strong>IS-A</strong>” checking)</li>
</ul>

<br/>
<p><strong>OCP - Approaches</strong></p>
<ul>
	<li>Parameters</li>
		<ul>
			<li>Control behavior specifics via a <strong>parameter</strong> or a <strong>delegate</strong></li>
		</ul>
	<li>Rely on abstraction, <strong>not implementation</strong></li>
		<ul>
			<li>Inheritance / Template Method Pattern</li>
		</ul>
	<li>Strategy Pattern</li>
		<ul>
			<li>Plug in model (insert a new implementation of the interface)</li>
		</ul>
</ul>

<br/>
<p><strong>OCP - When to Apply</strong></p>
<ul>
	<li>By experience – know the problem domain and if a <strong>change</strong> is very <strong>likely</strong> to <strong>recur</strong></li>
	<li>New domain problem – implement the <strong>most simple</strong> way</li>
		<ul>
			<li>Changes once – <strong>modify</strong>, second time – <strong>refactor</strong></li>
		</ul>
	<li>TANSTAAFL – There Ain't No Such Thing As A Free Lunch</li>
		<ul>
			<li>OCP adds <strong>complexity</strong> to design</li>
		</ul>
		<ul>
			<li>No design can be <strong>closed against all changes</strong> - know which ones to guard</li>
		</ul>
</ul>

<br/>
<h1>Liskov Substitution Principle</h1>
<p><strong>LSP - Substitutability</strong></p>
<ul>
	<li>Derived types must be completely <strong>substitutable</strong> for their base types</li>
	<li>Derived classes</li>
		<ul>
			<li>only <strong>extend</strong> functionalities of the base class</li>
			<li>must <strong>not</strong> remove <strong>base</strong> class <strong>behavior</strong></li>
			<code>Student <strong>IS-SUBSTITUTED-FOR</strong> Person</code>
		</ul>

</ul>

<br/>
<p><strong>Design Smell - Violations</strong></p>
<ul>
	<li>Type Checking</li>
	<li>Overridden methods say "I am not implemented"</li>
	<li>Base class depends on its subtypes</li>
</ul>

<br/>
<p><strong>LSP – Approaches</strong></p>
<ul>
	<li>Tell Don't Ask</li>
		<ul>
			<li>If you need to check what is the object  - move the behavior <strong>inside the object</strong></li>
		</ul>
	<li>New Base Class – if <strong>two classes</strong> share a common behavior, but are not substitutable, create a third, from which <strong>both derive</strong></li>
	<li>There <strong>shouldn't</strong> be any <strong>virtual methods</strong> in constructors</li>
</ul>

