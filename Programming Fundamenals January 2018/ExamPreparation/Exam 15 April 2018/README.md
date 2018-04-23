Practice here https://judge.softuni.bg/Contests/986/Programming-Fundamentals-Extended-Exam-15-April-2018-Part-I


# Problem 1. Band Members

Orgolt&#39;s Final Revenge is a cool Bulgarian Rock band. They are young and ambitious and they take their music path seriously. So now they are planning their upcoming year and would increase their band with fresh members, consisting of **guitars, drums and microphone**. They want you to help them to calculate their **expenses for**** one year**.

First you will be given **members count** in the band. You have to calculate how many **guitarists and drummers** are there, you know that the **vocalist is always one**. The **guitarists are 1/3 from the members, rounded down** to whole number. The **rest of the band are drummers**.

On the next line you will receive the **guitar price**. You have to calculate the drum and microphone price. The **drum price is with 50% greater than the guitar&#39;s price**. The **microphone price** is the **difference between the**  **total price**  **of drums and the**  **total price**  **of guitars**.

The band have to pay **rent** , too. The price of their **rent for one month is the average price of all of the items** – drums, guitars and microphone.

## Input/Constraints

The input data should be read from the console. It will consist of **exactly 5 lines** :

- On the first line you receive **members count:** an integerin the range **[3;**  **1**** ,000]**
- On the second line you receive **guitar price:** a floating – point numberin the range **[1.00; 3000.00]**

The **input data will always be valid**. **There is no need to check it explicitly**.

## Output

The output should be printed on the console.

- You should print a single line with text: **&quot;Total cost: {totalCost}lv.&quot;**
- **The expenses** must be **rounded to two digits after the decimal point.**

Allowed working **time** / **memory** : **100ms** / **16MB**.

## Examples

| **Input** | **Output** | **Comments** |
| --- | --- | --- |
| 610.00 | Total cost: 270.00lv. | Members of group = 6Vocalist = 1; Guitarists = 1/3 \* 6 = 2; Drummers = 6 - 1 - 2 = 3drumPrice = (guitarPrice) + 50% = 15.00microphonePrice = (3\*15) – (2\*10) = 25.00Rent per month = (45 + 20 + 25) / 6 = 15.00;Rent for 1 year = 15 \* 12 = 180.00;Total expenses = (price of all instruments + rent for 1 year) = (90 + 180.00) = 270lv. |
| **Input** | **Output** | **Comments** |
| 15200 | Total cost: 9720.00lv. |   |

_...We&#39;re not gonna take it…
Anymore!..._



# Problem 2 – Drum set

Gabsy is Orgolt&#39;s Final Revenge charming drummer. She has a drum set but the different drums have different origins – some she bought, some are gifts, so they are all with **different quality**. Every day she practices on each of them, so she does damage and reduces the drum`s quality. Sometimes a drum brakes, so she needs to buy new one. Help her keep her drum set organized.

You will receive Gabsy&#39;s **savings** , the money she can spend on new drums. Next you receive a **sequence**** of integers **which represent the** initial quality** of each drumin Gabsy&#39;s drum set.

Until you receive the command **&quot;Hit it again, Gabsy!&quot;** , you will be receiving integer: the **hit power** Gabsy applies **on each drum** while practicing. When the power is applied you should **decrease** the value of the drum&#39;s quality with the current power.

When a certain drum **reaches 0 quality** , it breaks. Then Gabsy should buy a replacement.She needs to buy the exact same model. Therefore, its quality will be **the same as the initial quality** of the broken drum. The price is calculated by the formula: {initialQuality} \* 3. Gabsy will always replace her broken drums **until the moment she can no longer afford it**. If she doesn&#39;t have enough money for a replacement, the broken drum is **removed** from the drum set.

When you receive the command **&quot;Hit it again, Gabsy!&quot;** ,the program ends and you should print the current state of the drum set. On the second line you should print the **remaining money** in Gabsy&#39;s savings account.

## Input

- On the **first line** you receive the **savings** – a floating-point number;
- On the **second line** you recieve the **drum set** : **sequence** of **integers** , **separated** by **spaces**.
- Until you receive the command **&quot;Hit it again, Gabsy!&quot;** you will be receiving **integers** – the hit power Gabsy applies on each drum.

## Output

- On the first line you should print **each drum** in the drum set, **separated** by **space**.
- Then you must print the **money** that are left on the **second line** in the format **&quot;Gabsy has {money left}lv.&quot;** , formatted with two digits after the decimal point.

## Constraints

- The **savings –** **floating-point number in the range [0.00, 10000.00]**
- The **quality**  **of each drum in the drum set** – integer in the range **[1, 1000]**.
- The **hit**** power **will be in the** range [0, 1000]**

- Allowed working **time** / **memory** : **100ms** / **16MB**.

## Examples

| **Input** | **Output** | **Comment** |
| --- | --- | --- |
| 1000.0058 65 3311121810Hit it again, Gabsy! | 7 14 23Gabsy has 901.00lv. | DrumSet – 58 65 33.Day 1: hit power applied = 11 =&gt; 47 54 22;Day 2: hit power applied = 12 =&gt; 35 42 10;Day 3: hit power applied = 18 =&gt; 17 24 -8;The third drum breaks. But Gabsy has enough savings so she replaces it =&gt; 17 24 33;Day 4: hit power applied = 10 =&gt; 7 14 23;We print the current state of the drum set and what&#39;s left in Gabsy&#39;s bank account.   |
| 154.0055 111 3 5 8 502        508231Hit it again, Gabsy! | 27 2 4 7Gabsy has 10.00lv. |   |


# Problem 3 – First Album

Orgolt&#39;s Final Revenge are finally ready to record their first album. The problem is that they have more songs than the 4 they have the funds to record. So you should browse through the messy diary of the band members and find the first 4 songs or less that are valid.

You will be **receiving input lines** which may contain **any ASCII character**. Your task is to find **the songs that will be included in the debut album of the band**.

A **Valid Song** consists of three elements:

- Name
- Lyrics
- Length

The **Name** may consist of **any word character, whitespace characters and dashes(&#39;-&#39;), but should neither start nor end with whitespace character or dash** (&#39; **-**&#39;). The song name should be between square brackets(**[])**.

The **Lyrics** are between double quotes (&quot;) and may contain **any word character and whitespace characters.**

The **Length** is valid when found in one of the following formats:

- In minutes – {minutes}:{seconds}m -&gt; example: 0:44m; 10:05m;
- In seconds- {seconds}s -&gt; example: 35s; 123s;

For a song to be valid, all three elements of a song should be present, but **their order may vary.**

Your program must end either when **4 valid songs are found** or when you receive the command &quot; **Rock on!**&quot;. You must print **all valid songs** you&#39;ve found, each on a **new line in the following format:**

**{name} -&gt; {length} =&gt; {lyrics}**

## Input

- The input will come in several input lines, which may contain any ASCII character.
- The input ends when you receive the command &quot; **Rock on!**&quot;.

## Output

- As output you must print the valid songs you&#39;ve found, each on a new line.
- The format is: &quot; **{song} -&gt; {length} =&gt; {lyrics}&quot;**
- The length should consist of two digits for the minutes and two for the seconds, separated by &#39;:&#39; -&gt; **&quot;{minutes}:{seconds}&quot;.**

## Constraints

- The input may contain **any ASCII character**.
- A song name and lyrics contain minimum **3 characters**.
- A song length will be between 1 second and 1 hour;
- There will be **no more** than **100 input lines**.

- Allowed working **time** / **memory** : **100ms** / **16MB**.

## Examples

| **Input** | **Output** |
| --- | --- |
| &quot;Love me or hate me&quot;jh#kefjhs#2fass$jfaahiu[Love and Hate]222snfaiufaui213544b[Faith restored]&quot;Orgolts Final Revenge&quot;faniufsa8218217@2a0o99sRock&#39;n&#39;RollGuns&#39;n&#39;Tulips[SweetChildO&#39;Nine]1:22maffsa########22:14mfafa@@##@#@%^&amp;\*\*\*\*\*\*[Sweet girl]&quot;OFR&quot;asffsasafsfaRock on!   | Love and Hate -&gt; 03:42 =&gt; Love me or hate meFaith restored -&gt; 01:39 =&gt; Orgolts Final RevengeSweet girl -&gt; 22:14 =&gt; OFR |
| [SoftUniSong]&quot;Flower Jokes are cool&quot;student@softuni.bg66shttps://judge.softuni.bg/Contests/988[PESHO]&quot;IS GOSH@&quot;200sRock on! | SoftUniSong -&gt; 01:06 =&gt; Flower Jokes are cool |


# Problem 4 – Lora&#39;s fan club

Lora is Orgolt&#39;s Final Revenge bass player. She is the hottie of the band, she&#39;s just so cute! So she has quite a lot of boys hitting on her and she needs your help to figure out who she should give a chance to.

You will receive input lines in one of the following formats:

- {name} {trait} {traitValue}
- {name} does Gyubek!

The **n**** ame **** and trait **are a one-word strings. The** trait value** is an integer in the range [0; 100].

If you receive a **trait** for the same **boy** twice, you should replace the existing **trait value** only if the new one is greater.

The following **traits** are considered **negative** by Lora so their **value should become a negative integer** :

- Greedy
- Rude
- Dumb

The following traits are considered **positive** so their value should be multiplied by a multiplier:

- Kind =&gt; multiplier \*2
- Handsome =&gt; multiplier \*3
- Smart =&gt; multiplier \*5

If you receive the command &quot;{name} does Gyubek!&quot;, Lora becomes really upset with this boy. If this boy already exists in our database all positive traits added so far are erased! If the boy doesn&#39;t exist in the database yet, he won`t be affected if added later.

The input ends when you receive the command &quot; **Make a decision already!**&quot;. You must **print all boys** , **ordered** by **the total sum of their traits&#39; values** in **descending order** , and then alphabetically.

The **traits** must be ordered by their value in **descending order**.

## Input

- The input consists of several input lines in the format specified above.
- The input ends when you receive the command **&quot;Make a decision already!&quot;.**

## Output

- As an output you must print all the boys ordered in the way specified above.
- The format is:

  **# {boy&#39;s name}: {total sum of traits values}**

**!!! {trait} -&gt; {trait value}**

## Constraints

- The **boy&#39;s name profession and trait** will be strings, consisting of one word each.
- The **trait value** is an integer in the range [0; 100].
- There will be **no invalid input lines**.

- Allowed working **time** / **memory** : **100ms** / **16MB**.

## Examples

| **Input** | **Output** |
| --- | --- |
| Tony Handsome 40Johnny Cool 23Johnny does Gyubek!Asen Kind 33Ivan Greedy 1Ivan Smart 5Asen Greedy 20Make a decision already! | # Tony: 120!!! Handsome -&gt; 120# Asen: 46!!! Kind -&gt; 66!!! Greedy -&gt; -20# Ivan: 24!!! Smart -&gt; 25!!! Greedy -&gt; -1# Johnny: 0 |
| Pesho Cool 20Gosho Rude 20Kiro Kind 10Stamat does Gyubek!Stamat Big 20Make a decision already! | # Kiro: 20!!! Kind -&gt; 20# Pesho: 20!!! Cool -&gt; 20# Stamat: 20!!! Big -&gt; 20# Gosho: -20!!! Rude -&gt; -20 |
