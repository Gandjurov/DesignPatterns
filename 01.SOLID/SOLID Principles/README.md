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

<p><strong>Cohesion and Coupling - Approaches</strong></p>
<ul>
	<li><strong>Small number</strong> of instance variables inside a class</li>
	<li>Each method of a class should manipulate <strong>one or more</strong> of those variables</li>
	<li>Two modules should <strong>exchange</strong> as <strong>little information</strong> as possible</li>
	<li>Creating an <strong>easily reusable</strong> subsystem </li>
</ul>