
<h1 align="center">Adapter Pattern</h1>
<p align="center">
  A Simple Implementation Of Adapter Pattern Usage <br />
</p>

## Prerequisites
Have the knowledge of object-oriented programming.

## Main Idea of the Adapter Pattern
The Adapter design pattern is a structural pattern which allows incompatible interfaces to work together. By doing so, we allow objects from different interfaces to exchange data.

## What is the Problem Require the Adapter Pattern 
Consider we get xml data from a source (called XmlSource.cs in project) and send it to a service (called MyService.cs in project) to print this data. Now, we need to send this data in json format. By the way, we can't do anything about source (SourceXml.cs) and destination (MyService.cs) files since sometimes our destination requires xml data.

There is a best practice solution for these problems and this one called as Adapter Pattern :)

Have a look at my project for more detailed review.

###### I've tried to explain as short as possible. I hope everything is clear :) 
