# Encapuslation-C#
My class project, which involves my first ever code push on github along with a description about the topic which is **_Encapsulation_**.
---

## Encapsulation

The meaning of Encapsulation, is to make sure that *"sensitive data"* is hidden from users. It refers to the practice of binding data (fields) and the methods that operate on that data into a single unit, while *restricting* direct access to some components. This ensures controlled interaction with an object’s internal state. To achieve this, we need to follow the following steps:

-	Data members are declared *"private"*, *"protected"*, *internal"* and *"protected internal"*.
-	Access is provided through **public methods**

This ensures data security and controlled modification.


## Key Concepts

-	Encapsulation hides the internal representation of an object and exposes the necessary operations.
-	Fields are often kept private, while access is provided through public properties or methods.
-	It improves data security, code maintainability and flexibility.
-	Access Modifiers (private, public, protected and internal) control visibility of members.

## Encapsulation using different *"Access Modifiers"*

### "Private" Access Modifier

Private access specifier allows a class to hide its member variables and member functions from other functions and objects. Only functions of the same class can access its private members. Even an instance of a class cannot access its private members.

#### Example

<img width="367" height="333" alt="PrivateExample" src="https://github.com/user-attachments/assets/02b07928-5cf9-48ef-bde5-567c34d11443" />

#### Explanation

- **"marks"** is declared as **_private_**, so it is <ins>**hidden**</ins> from outside classes.
- The value can only be accessed through the **_public_** method **"ShowMarks()."**
- Direct access like **"student.marks"** = 100 is not allowed.


### "Protected" Access Modifier

Protected access specifier allows a child class to access the member variables and member functions of its base class. This way it helps in implementing inheritance. We will discuss this in more details in the inheritance chapter.

#### Example

###  "Internal" Access Modifier

Internal access specifier allows a class to expose its member variables and member functions to other functions and objects in the current assembly. In other words, any member with internal access specifier can be accessed from any class or method defined within the application in which the member is defined.

#### Example

###  "Internal Protected" Access Modifier 

The protected internal access specifier allows a class to hide its member variables and member functions from other class objects and functions, except a child class within the same application. This is also used while implementing inheritance.

#### Example


## Encapsulation Using *"Properties"*
There is another way to implement encapsulation by using the properties (set and get).

#### Example

## Advantages

- *Data Protection*: Prevents unauthorized access to fields.
- *Controlled Access*: Exposes only required operations.
- *Code Flexibility*: Internal implementation can change without affecting external code.
- *Maintainability*: Reduces coupling between classes.

## Disadvantages
- Using getters and setters adds extra code compared to accessing fields directly.
- Accessing data through methods may be a bit slower than direct access.
- Since data is hidden, it can sometimes be difficult to quickly inspect or change values during debugging.



