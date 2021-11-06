<Query Kind="Program" />

void Main()
{
	var p = new Person();
	var a = new Address();
	p.Address = a;

	var c = new ComplexTypeSample();
	p.Address.AnotherSample = c;


	//NullReferenceException

	p.Address.AnotherSample.AnotherThing = "sddsf";


}

class Person
{
	public string Name { get; set; }
	public Address Address { get; set; }

	public Person()
	{
		if (Address == null)
			Address = new Address();
	}
}


class Address
{
	public string AnyThing { get; set; }
	public ComplexTypeSample AnotherSample { get; set; }
	public List<ComplexTypeSample> AnotherSampleList { get; set; }
	public ComplexTypeSample[] AnotherSampleArray { get; set; }
	public Queue AnotherSampleQueue { get; set; }

	public Address()
	{
		if (AnotherSample == null)
			AnotherSample = new ComplexTypeSample();

		if (AnotherSampleList == null)
			AnotherSampleList = new List<ComplexTypeSample>();

		if (AnotherSampleArray == null)
			AnotherSampleArray = new ComplexTypeSample[0];

		AnotherSampleList.Sort();
	}
}


class ComplexTypeSample
{
	public string AnotherThing { get; set; }
}
// You can define other methods, fields, classes and namespaces here
