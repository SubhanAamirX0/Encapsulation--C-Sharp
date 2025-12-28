# Encapuslation-C#
My class project, which involves my first ever code push on github along with a description about the topic which is **_Encapsulation_**.
---

## Encapsulation

The meaning of Encapsulation, is to make sure that *"sensitive data"* is hidden from users. It refers to the practice of binding data (fields) and the methods that operate on that data into a single unit, while *restricting* direct access to some components. This ensures controlled interaction with an object’s internal state. To achieve this, we need to follow the following steps:

-	Data members are declared **_"private"_**, **_"protected"_**, **_"internal"_** and **_"protected internal"_**.
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

#### Output

<img width="110" height="36" alt="Private Output" src="https://github.com/user-attachments/assets/01b28dc3-93e8-4ae0-a94c-23dda1ffa6b0" />


### "Protected" Access Modifier

Protected access specifier allows a child class to access the member variables and member functions of its base class. This way it helps in implementing inheritance. We will discuss this in more details in the inheritance chapter.

#### Example

<img width="374" height="332" alt="Protected Example" src="https://github.com/user-attachments/assets/14d86c73-7549-4a83-aa7c-61e2fe9c2da8" />


#### Explanation

- The variable **"accountType"** is marked as **_protected_**.
- It cannot be accessed from **"Main()"**.
- It can be accessed inside the derived class **"PremiumAccount"**.

#### Output

<img width="100" height="35" alt="Protected Output" src="https://github.com/user-attachments/assets/cb993e33-9c54-4504-98c2-b4e2ca5a852e" />

###  "Internal" Access Modifier

Internal access specifier allows a class to expose its member variables and member functions to other functions and objects in the current assembly. In other words, any member with internal access specifier can be accessed from any class or method defined within the application in which the member is defined.

#### Example

<img width="353" height="241" alt="InternalExample" src="https://github.com/user-attachments/assets/c6bde68f-3ac7-49c4-8c97-829af24dcc40" />

#### Explanation

- The variable **"bankName"** is accessible anywhere within the same project.
- It cannot be accessed from another project or assembly.

#### Output

<img width="148" height="38" alt="Internal output" src="https://github.com/user-attachments/assets/3bac3056-75e5-4ff3-810f-c1ba1c722b2d" />

###  "Internal Protected" Access Modifier 

The protected internal access specifier allows a class to hide its member variables and member functions from other class objects and functions, except a child class within the same application. This is also used while implementing inheritance.

#### Example

<img width="410" height="367" alt="ProtectedInternalExample" src="https://github.com/user-attachments/assets/c168583c-4324-42ec-89de-c09b6c911450" />

#### Explanation

- The variable can be accessed:
   - Anywhere in the **"same"** project
   - In **"derived"** classes (even outside the project)


#### Output

<img width="186" height="57" alt="ProtectedInternaloutput" src="https://github.com/user-attachments/assets/d2033007-0f69-42d9-8a2c-f6cc7c3b5ff6" />

## Encapsulation Using *"Properties"*
There is another way to implement encapsulation by using the properties (set and get).

#### Example

<img width="380" height="380" alt="GetSetExample" src="https://github.com/user-attachments/assets/e090fe9b-2dda-492a-b89b-640b9fc10be4" />

#### Explanation
- The field **"age"** is kept **_private_**.
- The property **"Age"** provides controlled access.
- Validation ensures invalid values are rejected.

#### Output

<img width="158" height="54" alt="GetSetoutput" src="https://github.com/user-attachments/assets/7670472b-7094-40f4-a10e-cb2646c9173a" />

## Advantages

- **Data Protection**: Prevents unauthorized access to fields.
- **Controlled Access**: Exposes only required operations.
- **Code Flexibility**: Internal implementation can change without affecting external code.
- **Maintainability**: Reduces coupling between classes.

## Disadvantages
- Using getters and setters adds extra code compared to accessing fields directly.
- Accessing data through methods may be a bit slower than direct access.
- Since data is hidden, it can sometimes be difficult to quickly inspect or change values during debugging.



