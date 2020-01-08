# C# Notes (Solution:Aesthetics)
## UML
### Visibility:
* \- private
cannot be accessed by any other class or subclass
* \+ public
opposite: can be accessed by anything
* \# protected
can only be accessed by the same class or subclasses
* \~ package/default
can be used by any other class, as long as it’s in the same package

### Abstract classes
* names in italics
* you don’t instantiate abs classes
* you don’t make an “animal”
* you make “otters”, “tortoises”, and “slow lorises”

### Relationships
* inheritances
* association
* “otter” animal ---> eats ---> “sea urchin” animal

## Fields vs. Properties ([link to StackOverflow](https://stackoverflow.com/questions/295104/what-is-the-difference-between-a-field-and-a-property))

``` public class MyClass
{
    // this is a field.  It is private to your class and stores the actual data.
    private string _myField;

    // this is a property. When accessed it uses the underlying field,
    // but only exposes the contract, which will not be affected by the underlying field
    public string MyProperty
    {
        get
        {
            return _myField;
        }
        set
        {
            _myField = value;
        }
    }

    // This is an AutoProperty (C# 3.0 and higher) - which is a shorthand syntax
    // used to generate a private field for you
    public int AnotherProperty{get;set;} 
} ```

## Too many constructors?
```
        /* https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/params
         * Searching for a way to combine ShowSpacer() into one method. The following method
         * doesn't work since it would require many IF statements to determine the types.
         * It may still prove useful in this project. */
        public static void UseParams2(params object[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
        }
```

## Class Sketch
# Spacer
* int numChars
* char spacerChar
* object[] spacer

* (GetSpecs() - to let user define spacer properties)
* BuildSpacer
* ShowSpacer()

# Header : Spacer
* string title
* string tagLine
x