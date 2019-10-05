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
a C++/CLI bridge between the native robot binaries and home automation systems. 

As a proof of concept, you develop a sample prototype application called Robot Manager and deliver to Home Automation Inc. to demostrate how engineers at Home Automation Inc. can use the new C++/CLI bridge library to interface with the robots and perform a variety of complex tasks.

This is just a simple example of a real-world use case for interoperability. In the real-world, large and complex software
systems that took years to develop and cost a lot money cannot simply be rewritten or replaced for any reason. Engineers need to figure out how to interface such systems with other tools, languages and technologies that might not seem compatible at first glance, but can provide great improvements through interop.

















