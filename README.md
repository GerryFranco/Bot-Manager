# Bot-Manager by Gerry Franco

This project demonstrates the powerful capabilities of C++/CLI for native and managed interoperability 
using a real-world development scenario.

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

For our demonstration, US Robots has provided us with a native C++ library called "Bots.Native.dll" that contains all the code and  APIs needed to interact with their robots.

### Your Managed Library (or Managed Application)

This is the code that needs to interop with the native library. It's probably something you developed or helped develop either as a library or an application. Most likely, it runs on the world's most popular runtime, the CLI, and 
since the Microsoft .NET Framework is the most popular implementation of the CLI, it's probably written in some .NET language.

For our demonstration, we have built a simple Winform prototype application developed in C# called "Bot Manager". With this app, users can connect to their robots by name, assign them complex tasks, and also track those tasks. Recall that the purpose of this prototype app is to show Home Automation LLC how easy it is for their managed systems to talk to those native robot APIs.

### C++/CLI Bridge Library (API and Implementation)

Recall that C++/CLI is a language that allows you to easily extend a C++ code base with .NET features. Since C++/CLI is superset of C++, any program written in C++/CLI is also a valid C++ program. This is why C++/CLI is now the industry standard native-to-managed migration strategy.

In this layer, you'll develop code that bridges the gap between your managed code and the native code you're trying to talk to.  Your managed code layer will interface with this bridge layer, which in turn, will interface with the native code layer. Since interop is all about interfacing, you'll have to develop a well-designed API for your managed code to consume. This implies keeping your C++/CLI interfaces and their implementations separate. 

For our demonstration, we developed two C++/CLI libraries, one to house the interfaces and the other for the implementation of those interfaces. The first library is called "Bots.Interfaces.dll". This library contains the C++/CLI interfaces (the API) that Bot Manager will use to interact with the robot library. 

The second library is called "Bots.Managed.dll". This library contains the implementation of "Bots.Interfaces.dll" and
is written in both C++ and C++/CLI. It serves as the actual bridge where all the managed and native type conversions and native calls take place.



























