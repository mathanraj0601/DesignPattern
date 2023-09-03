# Design Pattern

Design patterns are general solutions to commonly occurring problems in a context (software development)

## Why should we learn design patterns?

1. Avoid re-inventing wheel: There is already an existing solution to the problem that arises in software development so using that saves time.

1. Better Communication: It is easier to communicate via design pattern name our intent over a code rather than through low-level discussion

 Example : 
- Conversation one: As the database access layer is tightly coupled to the database we can extract an interface and put the necessary method declaration in it. Implementing the interface in the class and providing a definition help us to replace all the local instantiation of the object with an interface 
- Conversation Two : As the database access layer is tightly coupled to the database we can go for a repository pattern
- Conversation two feels good and better than conversation one

1. Better and optimal code: Help us write a clean and more optimal code that boosts the performance of the application

## Document structure for every pattern

- Name: name of the pattern
- Intent: Intent or goal it trying to achieve
- Alias: Other name for the pattern if exists
- Motivation/applicability or scenario: The context or scenerio the pattern suits very well.
- Participant : what are the classes or interface etc., it going to have
- Collabration : How the participant going to interface with each other
- Consequences : As every pattern have some tradeoff alomg with it
- Implemetation : How to implement in programming language 
- Sample code : Sample code for implementation
- Real time : Is there application using tthe pattern in real world

## How to learn pattern

As Experienced people suggest, there are four stages to learn a design pattern or anything

1. Ignorance : Not knowing anything starting from basic  
1. Awakening : knowing about the pattern exist but don't know how to implement (knowing name, indent, Motivation)
1. OverZealous: Particing the pattern in a controlled environment ( Not in the production code)
1.  Mastery : After become expert we try to find the pattern fit the application very easily and make better coding

## T shaped learing

there are dozen of design pattern in industry mastery everything is not easy
So having a awakening stage kind of understanding over wide pattern and having mastery in few pattern helps a alot in software development journey

## Few Pattern to mastery by Experienced people are

1. Strategy
1. Repository
1. Adapter
1. Proxy/decorator
1. Builder
1. Singleton 

> Note : Sometime we need to combine two or more pattern to have more optimal solution .