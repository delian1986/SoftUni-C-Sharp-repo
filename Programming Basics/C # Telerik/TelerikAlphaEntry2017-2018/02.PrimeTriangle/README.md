### 1/

Telerik Academy Alpha 2017-2018 - C# Entry Exam

# Task 2 - Prime Triangle

We know that you love math, so we have prepared a very interesting task, that involves both geometry and
prime numbers.
By a given N number, from which you need to generate a sequence of 1 to N inclusive. For every prime
number in that sequence, you need to print out all the other numbers before it (and the number itself), wether
they are prime or not.
For example, you are given 10 as the number N. Meaning that we have the sequence 1, 2, 3, 4, 5, 6, 7,
8, 9, 10.
The prime numbers in this sequence are 1, 2, 3, 5, 7. Following this we have 5 prime numbers and we
need to print 5 rows.
Each row contains all the numbers from 1 to the current prime number.
Following the algorithm, we get this result: (each bolded number is prime)
1
1 2
1 2 3
1 2 3 4 5
1 2 3 4 5 6 7
To make things more simple, we don't want to just print out the numbers. We want to print out 0 if the
number is not prime, or 1 if the number is prime. So, we get this:
1
1 1
1 1 1
1 1 1 0 1
1 1 1 0 1 0 1

Input

```
The input data consists of single line holding an integer number: N.
The input data will always be valid and in the format described. There is no need to check it explicitly.
```

### 2/

```
Input Output
10 1
11
111
11101
1110101
```
```
Input Output
27 1
11
111
11101
1110101
11101010001
1110101000101
11101010001010001
1110101000101000101
11101010001010001010001
```
Output

```
The output should consist of several lines of digits without any space between them, each of which
can be either 1 or 0
```
Constraints

```
The number N will be in the range [1..500] inclusive.
```
## Examples


