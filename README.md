# Bot-Manager by Gerry Franco

This project demonstrates the powerful capabilities of C++/CLI for native and managed interoperability 
using a real-world development scenario. All code was written from scratch and all UI graphics designed in Photoshop
by me for the purposes of this demo.

## Introduction

If you've ever developed for a company specializing in electronics or national defense, you've probably encountered your fair share 
of C++. Heck, C++'s proximity to hardware, speed and expanded feature set makes it the obvious development choice for modern embedded devices and the increasingly complex and challenging applications consuming them.

Yet, the world's most important systems and institutions also run on C++. Systems such as Linux, Windows, the Java Virtual Machine (JVM) and .NET Framework CLR were all written in C++. Relational database programs such as MySQL and Microsoft SQL Server were written in C++. Even well-known non-relational (NO-SQL) database programs, 
such as MongoDB were also written in C++. In fact, even portions of the Apple OS have been written in C++! 
There's no question about it, the language seems to either form the foundation of well-known modern systems or it permeates them. If the best tools lead to the best inventions, then C++ has proven to be the most powerful and flexible tool available in modern software development.

So, with the advent of these systems, we now end up with this massive marketplace of different technologies attempting to perfect, consume, build-upon, or communicate with these systems. Such interactions between systems (of any kind) is known as interoperability. In the software realm, we call it interop. An unrestricted bridge for information exchange.

## Real World Scenario

US Robots Corporation has invested $2 billion dollars over a period of five years to develop helper robots for the US Military. Given the complexity of the program, engineers at US Robots used C++ to develop the entire software system.

Over time, the cost to manufacture the robots has decreased and other lucrative markets (such as home automation) have started to express interest in robot technology. As such, US Robots is now considering repurposing their robots for this broader market.

Home Automation LLC has expressed huge interest in the robots and also sees a market opportunity. In fact, Home Automation LLC wants to be the first home automation service to interface with the state-of-the-art robot technology. Unfortunately, all of Home Automation's systems are written in managed .NET languages such as C#, so they're having a very hard time interfacing with the robot native libraries and APIs.

Since US Robots is also looking into developing its own home automation systems, it has decided that it will not rewrite any of its code or develop a special API to assist Home Automation LLC. As such, Home Automation LLC will have to solve the problem by itself.

To help solve the problem, they enlisted your help to develop a way to interface the robots with their home automation
systems. You devise a solution to use a powerful programming language known as C++/CLI, that will allow you to use .NET constructs in existing C++ code, effectively extending US Robots native C++ libraries with .NET features. You will develop
a C++/CLI managed bridge between the native robot binaries and home automation systems. 

As a proof of concept, you develop a sample prototype application called Robot Manager and deliver to Home Automation LLC. to demostrate how engineers at Home Automation LLC. can use the new C++/CLI bridge library to interface with the robots and perform a variety of complex tasks.

This is a typical example of a real-world use case for interoperability. In the real-world, large and complex software
systems that took years to develop and cost millions of dollars cannot simply be rewritten or replaced for any reason. Engineers need to figure out how to interface such systems with other tools, languages and technologies that might not seem compatible at first glance, but can provide great improvements through interop. Simply forgoing interoperability might not be an option.

In this particular example, we present a typical development scenario that contains the following 3 layers:

### Third Party Native Library

This is the C++ library you're trying to interop with. It's usually a third-party library or an internal company library. 
It may be one monolithic library or several of them, ideally containing easy-to-use APIs, if you're lucky. 
Regardless, you'll probably never be able to modify such libraries or rewrite them to fit your needs. You're stuck with
what you're given and you'll have to interface with it, no matter what.

For our demonstration, US Robots has provided us with a native C++ library called "Bots.Native" that contains all the code and  APIs needed to interact with their robots.

### Your Managed Library (or Managed Application)

This is the code that needs to interop with the native library. It's probably something you developed or helped develop either as a library or an application. Most likely, it runs on the world's most popular runtime, the CLI, and 
since the Microsoft .NET Framework is the most popular implementation of the CLI, it's probably written in some .NET language.

For our demonstration, we have built a simple Winform prototype application developed in C# called "Bot Manager". With this app, users can connect to their robots by name, assign them complex tasks, and also track those tasks. Recall that the purpose of this prototype app is to show Home Automation LLC how easy it is for their managed systems to talk to those native robot APIs.

### C++/CLI Bridge Library (API and Implementation)

Recall that C++/CLI is a language that allows you to easily extend a C++ code base with .NET features. Since C++/CLI is superset of C++, any program written in C++/CLI is also a valid C++ program. This is why C++/CLI is now the industry standard native-to-managed migration strategy.

In this layer, you'll develop code that bridges the gap between your managed code and the native code you're trying to talk to.  Your managed code layer will interface with this bridge layer, which in turn, will interface with the native code layer. Since interop is all about interfacing, you'll have to develop a well-designed API for your managed code to consume. This implies keeping your C++/CLI interfaces and their implementations separate. 

For our demonstration, we developed two C++/CLI libraries, one to house the interfaces and the other for the implementation of those interfaces. The first library is called "Bots.Interfaces". This library contains the C++/CLI interfaces (the API) that Bot Manager will use to interact with the robot library. 

The second library is called "Bots.Managed". This library contains the implementation of "Bots.Interfaces.dll" and
is written in both C++ and C++/CLI. It serves as the actual bridge where all the managed and native type conversions and native calls take place.

## How to Build

Visual Studio 2015 was used to develop the Bot Manager and all the libraries. To open and build the solution in Visual Studio, ensure the 2015 platform toolset (v140) is installed. Visual C++ support will also be required. Once built, three DLL files will be generated (Bots.Native.dll, Bots.Managed.dll, and Bots.Interfaces.dll) and an executable called "Bot Manager App.exe". For persistence, the application will generate a simple JSON file called "BotsLog.json". All files get generated in the same directory.

## How to Use Bot Manager

US Robots identifies its robots by name and type. It specifies 6 types of robots: 

- Unipedal 
- Bipedal 
- Quadripedal 
- Arachnid 
- Radial
- Aeronautical 

In order to connect to a robot, Bot Manager collects its name and its robot type. Since this is a demo application, you can enter any robot name and specify any type and Bot Manager will "automatically" connect to that robot. According to US Robots, robot names are always unique and serve as their serial number. As such, Bot Manager cannot connect to more than one robot with the same name, so users must ensure every name is unique.

Once Bot Manager collects the robot name and type, the user can connect to a robot by clicking the "Connect to Bot" button. Bot Manager then proceeds to automatically assign 5 random and complex tasks for the robot to complete and then tracks those tasks in the "Task List". Some tasks take more time to complete than others, but once a task is completed by a robot, it is removed from the list.

The user can also assign tasks to each robot by using the "New Task" drop down box to select a task and then clicking the "Assign Task" button.

Every connected robot can be managed and tracked in the "Bot List". The user can select a given robot to see what tasks
it has assigned to it. The user can remove or disconnect from a robot by selecting the robot from the bot list and clicking the "Delete Bot" button. Any pending tasks are immediately cancelled.

Bot Manager also has "Bot Messages". This feature allows a user to receive robot messages to know when a robot started a task and when it finished it in real time. 

According to US Robots, and the robots API, users can only assign robots the following complex tasks:

- Do the dishes
- Sweep the house
- Do the laundry
- Take out the recycling
- Make a sandwich
- Mow the lawn
- Rake the leaves
- Give the dog a bath
- Bake some cookies
- Wash the car























