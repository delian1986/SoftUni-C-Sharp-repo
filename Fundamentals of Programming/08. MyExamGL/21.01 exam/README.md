<a href="https://judge.softuni.bg/Contests/919/Practical-Exam-21-January-2018"># 1.Exam &quot;Fundamentals of programming with C#&quot; – 21January 2018</a>

# Problem 1. Underground Waters

1. 1.History

You just love the rain and you have the amazing opportunity to examine the underground waters that were formed from the last rainy month. You are in search of something unordinary. **Your job is to understand if there is something that is worth a further investigation or not.**

1. 2.Description

### You are going to receive two input lines. Each one consists of integer numbers separated by a single space which you must parse to an Integer array. For more information, read the Input section.

Those two input lines represent two arrays: **Air Array** and **Raindrops Array**.

**Air Array** : You have almost nothing to do with this array except to understand the number of **\*local maximum**** values.**

**Raind**** rops Array: **You must** subtract **the count of** \*local maximum values (of Air Array****)** from **each element** and then discard all elements which are less than or equal to 0 (&lt;= 0).

**\*Local Maximum Value:** A value in an array which is **greater than** its left and its right neighbor. If there is no left or right neighbor count their values as 0.                                                                                                                              Examples: [1, 10, 8] -&gt; 10 (because 10 is bigger than 1 and 8)

      [18, 2, 4, 1, 15, 15] -&gt; 18 (because left neighbor is 0) and 4

      [1] -&gt; 1 (because it is bigger than 0 on the left and 0 on the right)

When you finish the work with the **Raindrops Array** you must find the **biggest value** out **of** the **local maximum values** from both the **Air Array** and the edited **Raindrops Array.** If there are **no local maximum values** for any of the arrays, consider the **biggest value** to be **0**.

Finally, you must compare the **two**** biggest values **from the** two arrays **and print an output with the format described in the** Output section**.

Example: [18, 2, 4, 1, 15, 15] -&gt; Two local maximum values [18, 4] -&gt; 18 is the **Biggest Local Maximum Value**.

### Input

Exactly two input lines:

1. **Air Array –** a string containing integers separated by a single space **. May be an empty string** **(„&quot;)****.**
2. **Raindrops Array** – a string containing integers separated by a single space **. May be an empty string** **(„&quot;)****.**

### Output

**If** the Total Maximum Value from the Air Array and the one from the Raindrops array **are equal,** you must print the following **two strings (the second one must be on a new line):**

&quot; **Something interesting was found!**&quot;

&quot; **Sum:**  **{0}**&quot; ({0} is the **sum** of the two **biggest local maximums** )

If the **biggest value** out of thelocal maximum values from the Air Array and the one from the Raindrops array **are NOT equal,** you must print the following **two strings (the second one must be on a new line):**

**&quot;**** There is nothing unordinary! ****&quot;**

**&quot;**** Difference: { ****0**** } ****&quot;** ({0} is the **Absolute Difference** of the **biggest local maximums** )

Examples:

| **Input** | **Output** | **Description** |
| --- | --- | --- |
| 4 8 2 3 1 10 513 2 0 | Something interesting was found! Sum: 20 | **There are**  **3**  **local max values from the Air Array –**  **8**** , **** 3 ****,**  **10****. **** You have 3 elements in the **** Raindrops Array **** and you subtract the value **** 3 **** from each **** Raindrop Array **** element. So the transformation looks like this: ****13, 2, 0**  **-&gt;**  **10**** , -1, -3 -&gt; **** 10 ****.**** You discard all numbers which are &lt;= 0 and you are left with the number **** 10 ****.**** The total local maximum element from the Air Array is **** 10 **** and the total local maximum element from the Raindrops Array is **** 10 ****.**** 10 **** is equal to **** 10 **** and the sum is 20.** |
| **Input** | **Output** | **Description** |
| 1 8 2 10 10 15 12 3 12 8 | There is nothing unordinary! Difference: 5 | **There are**  **2**  **local max values from the Air Array –**  **8**** , **** 15 ****.**  **You have 4 elements in the**  **Raindrops Array**  **and you subtract the value**  **2**  **from each**  **Raindrop Array**  **element. So the transformation looks like this:** 2, 3, 12, 8 **-&gt; 0, 1, 10, 6 -&gt;**  **1, 10, 6****. ****You discard all numbers which are &lt;= 0 and you are left with the array**  **1, 10, 6****. ****The total local maximum element from the Air Array is**  **15**  **and the total local maximum element from the Raindrops Array is**  **10****. ****15**  **is NOT equal to**  **10**  **and the absolute difference is 5.** |
| **Input** | **Output** |
| 10 2 1012 | Something interesting was found! Sum: 20 |



# Problem 2. Rainbow Raindrop

1. 1.History

Somewhere out there, in a parallel universe, there is a different way in which the rainbow raindrops are formed. Your job is to **count the raindrops that can reflect light in such a way that they can be a part of a rainbow**** and the ones that can&#39;t**. Unfortunately, you can&#39;t travel to this parallel universe, but you have a very good friend which will send you all the information he gathers in real time. Be careful because the connection may be poor.

1. 2.Description

You must read all the lines of input until you receive the special termination command &quot; **End**&quot; ( **case-sensitive** ). Before the termination command, the input lines **may** contain information about a raindrop which you **must** gather. The way you can tell if a line of information is about a raindrop is the **format**. It should be as follows:

**&quot;{volume} {red color value} {green color value} {blue color value}&quot;**

You don&#39;t need to validate the data types, just **make sure that there are 4 fragments separated by a single space**. **Skip** the input line **if** it **doesn&#39;t contain** raindrop information.

A raindrop **color values**** must **be** between ****0** and **255 inclusive**. If a color value is **not in** the given **range**** set **it** to 0**.

There is special type of raindrop called &quot; **rainbow raindrop&quot; which is formed** when it has **only one** colorvalue **greater than 200** and **two color values less than 100****. **You must** collect only the rainbow raindrops **and** print a report **in a strict** format **which is described in the** Output section.**

### Input

Each raindrop information input line contains:

- **Volume** – the volume of the raindrop – **floating-point number in range**** [****0.20**  **...**** 100.00]**
- **Red color value** – the amount of red lightit can reflect – **integer number in range**** [****-2,147,483,648 … 2,147,483,647****]**
- **Green color value** – the amount of green light it can reflect – **integer number in range**** [****-2,147,483,648 … 2,147,483,647****]**
- **Blue color value** – the amount of blue light it can reflect – **integer number in range**** [****-2,147,483,648 … 2,147,483,647****]**

### Output

The **rainbow**** raindrops must be numbered from 1 to N **and must be** ordered by their volume (ascending) **. The** volume must be rounded to two digits** after the decimal separator.

Rainbow Raindrops: {Count of rainbow raindrops}

1. V:{Volume} -&gt; R:{Red Color Value} G:{Green Color Value} B:{Blue Color Value}
2. V:{Volume} -&gt; R:{Red Color Value} G:{Green Color Value} B:{Blue Color Value}

…

### Example

| **Input** | **Output** | **Description** |
| --- | --- | --- |
| 3.1381 40 109 10766.0125 280 176 29476.3311 201 88 1303.2415 109 151 20271.312 37 78 10328.2557 48 95 21232.5235 213 128 105.9957 46 -1 16495.948 -3 44 18067.0745 226 19 107End | Rainbow Raindrops: 11. V:28.26 -&gt; R:48 G:95 B:212 | **There is only one rainbow raindrop because its blue color value is greater than 200 and the other two color values are less than 100.**** Raindrop number 5 has Red Color Value and Blue Color Value set to 0 because they were not in the given range.** |
| **Input** | **Output** |
| 3.1381 40 109 10766.0125 280 176 29476.3311 201 88 1303.2415 6 51 202non-raindrop-info-input-line28.2557 48 95 21232.5235 213 128 10end95.948 -3 44 18067.0745 226 19 107End | Rainbow Raindrops: 21. V:3.24 -&gt; R:6 G:51 B:2022. V:28.26 -&gt; R:48 G:95 B:212 |
| **Input** | **Output** |
| 3.1381 40 109 1073.2415 214 51 24.215 26 251 202.255 48 201 028.2557 248 95 467.0745 226 19 107End | Rainbow Raindrops: 41. V:2.26 -&gt; R:48 G:201 B:02. V:3.24 -&gt; R:214 G:51 B:23. V:4.22 -&gt; R:26 G:251 B:204. V:28.26 -&gt; R:248 G:95 B:4  |



# Problem 3. Friends from Rainy Universe

1. 1.History

Hey, it&#39;s been a while and your friend and some of his friends from the parallel universe are coming home and they have something very interesting for you. They found that thanks to the different types of raindrops there are also different types of water. They are coming with packs full of jars holding different types of water. However, there is a small problem... they have placed all the jars in only one bag and… this bag is going to arrive a week later… They don&#39;t like to unpack everything because they are lazy, so they send you a message in which is described which jar to whom belongs. Your job is to create a machine which unpacks the bag and separates the jars in a pile for every person. How does the machine know how to separate the jars? **You must implement an algorithm which organizes the information from the message.**

1. 2.Description

You must read input lines until you receive the **termination command &quot;End&quot;.** On every input line (except the termination one) you will receive information in the following format:

**&quot;{person name} -&gt; {liquid name}: {jars count}&quot;**

You must **split** the input and **extract** the needed information. Everything will be **valid** in the format described in the Input section.

You must **collect** all the **different**** types **of** liquids **for a** person **and** sum the count **of jars of every** liquid **for** every ****person**.

### Input

The information will be in the following format:

- Person name – **unique** string which will **not contain** any of the characters that you have to split by (space, &#39;-&#39;, &#39;&gt;&#39;, &#39;:&#39;)
- Liquid name – **unique** string which will **not contain** any of the characters that you have to split by (space, &#39;-&#39;, &#39;&gt;&#39;, &#39;:&#39;)
- Jars count – **integer** number in range[0 … 100]

### Output

You must print **all liquids** for a **single person** with their **count of jars**.

**Order** the **people by** their **name (ascending)** and the **liquids by** their **count (ascending).**

{Person Name} Liquids:

--- {Liquid Name}: {Count}

--- {Liquid Name}: {Count}

…



Examples:

| **Input** | **Output** | **Description** |
| --- | --- | --- |
| Morgana -&gt; Truelock: 2Morgana -&gt; Truelock: 89Garrard -&gt; Perigeaux: 96Morgana -&gt; Tott: 36Arleta -&gt; Sinnie: 15Arleta -&gt; Hutchin: 21Emlyn -&gt; Winslett: 92Arleta -&gt; Eam: 68End | Arleta Liquids:--- Sinnie: 15--- Hutchin: 21--- Eam: 68Emlyn Liquids:--- Winslett: 92Garrard Liquids:--- Perigeaux: 96Morgana Liquids:--- Tott: 36--- Truelock: 91 | **Arleta is first because of the ordering (by names). The liquids are ordered by count of jars (ascending).** |
| **Input** | **Output** |
| Dino -&gt; Wasiel: 100Hallie -&gt; Bellefonte: 50Hallie -&gt; Bellefonte: 25Hallie -&gt; Bellefonte: 25Dino -&gt; Banana: 94Dino -&gt; Banana: 6End | Dino Liquids:--- Wasiel: 100--- Banana: 100Hallie Liquids:--- Bellefonte: 100 |



#Problem 4. Make it Rain

1. 1.History

You had an amazing success with the Liquid Sorting Algorithm and you decide to create a new Crypto Currency called – &quot;Roin&quot; (short from &quot;Rain-coin&quot;). Your goal is to make as much money as you can from this currency, so you want it to be perfect. **Your job is to implement an innovative algorithm for the new &quot;Roin&quot;.**

1. 2.Description

On the first line you will receive an integer – **N**. On the next **N\*3** lines you are going to receive triplets (pack of three) of integers – **A** , **B** and **C, each on a new line**.

The algorithm you came up is the following:

First check **IF YOU CAN** divide **A** by **B** and get a result equal to **C.** The result of the check should be **&quot;True&quot;** or **&quot;False&quot;.** You get the first letter of the result (either **&#39;T&#39;** or **&#39;F&#39;** ) and you must increment a **counter for each occurrence** of the two letters **but in a special way** :

1. Each time you get a &#39; **T**&#39; you add to its count the **ASCII code** of the symbol &#39; **T**&#39; and modify the count of &#39; **F**&#39; by the following \ ***special formula** - **fCount = fCount / (ASCII code of &#39;T&#39;****/ 10).**
2. Each time you get a &#39; **F**&#39; you add to its count the **ASCII code** of the symbol &#39; **F**&#39; and modify the count of &#39; **T**&#39; by the following \ ***special formula** - **tCount = tCount / (ASCII code of &#39;F&#39;****/ 10**).

In the end you need to understand if you have mined a &quot;Roin&quot;. The way you do that is by **dividing**&#39; **T**&#39; count by &#39; **F**&#39; count. **IF YOU CAN** do that and the **result**** is **an** even ****number** you have a &quot;Roin&quot;. The result of the check must also be &quot; **True&quot;** or **&quot;False&quot;**.

You must print **your output** in a special **format** which is described in the **Output section**.

### Input

1. **N** – integer [1 … 100]
2. On the next **N\*3** lines you will receive triplets of integers: **A** , **B** and **C**. **Each integer will be on a new line!**

### Output

You must print the following three strings, **each on a new line** :

&quot; **T: {0}**&quot; ({0} is the calculated count of the &#39;T&#39; symbols)

&quot; **F: {0}**&quot; ({0} is the calculated count of the &#39;F&#39; symbols)

&quot; **Got a Roin coin: {0}**&quot; ({0} is either &quot;True&quot; or &quot;False&quot;)





Examples:

| **Input** | **Output** | **Description** |
| --- | --- | --- |
| 3121863224122 | T: 168F: 1Got a Roin coin: True | 12 / 1 is not equal to 8 so you get a &#39;F&#39;.You add 70 to the &#39;F&#39; count and calculate &#39;T&#39; count by the **\*special formula**. T: 0 and F: 706 / 3 is equal to 2 so you get a &#39;T&#39;.You add 84 to the &#39;T&#39; count and calculate &#39;F&#39; count by the **\*special formula**. T: 84 and F: 824 / 12 is equal to 2 so you get a &#39;T&#39;.You add 84 to the &#39;T&#39; count and calculate &#39;F&#39; count by the **\*special formula**. T: 168 and F: 1168 / 1 = 168 which is an even number so the result is &quot;True&quot; |
| **Input** | **Output** | **Description** |
| 2894525247 | T: 0F: 140Got a Roin coin: True | 89 / 45 is not equal to 2 so you get an &#39;F&#39;.You add 70 to the &#39;F&#39; count and calculate &#39;T&#39; count by the **\*special formula**. T: 0 and F: 7052 / 4 is not equal to 2 so you get an &#39;F&#39;.You add 70 to the &#39;F&#39; count and calculate &#39;T&#39; count by the **\*special formula**. T: 0 and F: 1400 / 140 = 0 which is an even number so the result is &quot;True&quot; |
