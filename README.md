# Ping-Pong Web Application

#### _Playing "Ping-Pong" with User Input_

#### By _**Alexandra Holcombe && Caitlin Hines**_

## Description

This web application will take a number from a user and return a range of numbers from 1 to the chosen number with the following exceptions:
* Numbers divisible by 3 are replaced with "ping"
* Numbers divisible by 5 are replaced with "pong"
* Numbers divisible by 15 are replaced with "ping-pong"

View this project on [GitHub Pages](https://alexandraholcombe.github.io/cr-intro-week3/)

## Setup/Installation Requirements

* Requires DNU, DNX, and Mono
* Clone to local machine
* Use command "dnu restore" in command prompt/shell
* Use command "dnx kestrel" to start server
* Navigate to http://localhost:5004 in web browser of choice

## Specifications

**The application will only accept numerical user input.**
* Example Input: Hello!
* Example Output:

**The application will take a user input of "1" and print it to the page.**
* Example Input: 1
* Example Output: [1]

**The application will count up to the user-provided number.**
* Example Input: 2
* Example Output: [1, 2]

**The application will return all numbers divisible by 3 as "ping."**
* Example Input: 4
* Example Output: [1, 2, ping, 4]

**The application will return all numbers divisible by 5 as "pong."**
* Example Input: 6
* Example Output: [1, 2, ping, 4, pong, ping]

**The application will return all numbers divisible by 15 as "ping-pong."**
* Example Input: 15
* Example Output: [1, 2, ping, 4, pong, ping, 7, 8, ping, pong, 11, ping, 13, 14, ping-pong]

## Support and contact details

Please contact Allie Holcombe at alexandra.holcombe@gmail.com or Caitlin Hines at caitlinhines@me.com with any questions, concerns, or suggestions.

## Technologies Used

This web application uses:
* Nancy
* Mono
* DNVM
* C#
* Razor

### License

*This project is licensed under the MIT license.*

Copyright (c) 2017 **_Alexandra Holcombe && Caitlin Hines_**
