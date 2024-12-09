# Web Services Programming University Course Tasks

Welcome to my repository where I store all tasks and projects related to the Web Services Programming course I took at my university.

## About the Course

I had the honor of being in the very first batch to take  APIs as a university course. This is a very rare opportunity since not many universities offer Web Services Programming in their course work. As a matter of fact, very few universities in the world offer similar courses, hence it was so unique to have such an experience.

## Purpose of This Repository

I don't usually create repositories for course assignments, but this course was so unique—one that not many institutions offer—that I decided to make an exception. This repository is built to show and maintain all the work done in different assignments throughout this course. This is something of a personal collection of knowledge and abilities that I have developed in API development that may be useful to other students or persons who look to learn or research this topic.

# Assignment 1: SOAP Web Service for Student Data

In this assignment, we were tasked with designing a Student class containing the following attributes:

- Id: int
- Name: string
- Department: string
- City: string
- Average: string

The purpose was to design a SOAP web service that would transfer the data of a Student object among various applications. The interface included a method labeled GetStudent().

Besides, depending upon the city of residence, a specific discount had to be given:

- Amman: 15%
- Zarqa: 10%
- Other cities: 5%

It was also necessary to modify the web service later on to return only the Id, Name, and City of each student, and to include a method called GetStudentById(int id) that would allow retrieving a student by their ID from a list of students.
