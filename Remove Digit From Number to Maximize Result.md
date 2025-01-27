# Remove Digit From Number to Maximize Result

## Problem Description
You are given a string `number` representing a non-negative integer, and a character `digit`. The goal is to remove **exactly one occurrence** of `digit` from the string `number` in order to maximize the resulting number. Return the largest possible number as a string after removing one occurrence of `digit`.

### Example Input and Output:

#### Example 1:
- **Input**: 
  ```csharp
  number = "1231", digit = '1'
  ```
- **Output**: 
  ```csharp
  "231"
  ```

#### Example 2:
- **Input**: 
  ```csharp
  number = "551", digit = '5'
  ```
- **Output**: 
  ```csharp
  "51"
  ```

---

## Constraints
- \( 1 \leq \text{number.length} \leq 100 \)
- \( \text{digit} \) is a character that appears in the `number` string at least once.
- The number string is a non-negative integer and doesn't contain leading zeros.

---

## Solution

### Approach
The strategy is to iterate over the digits of the string `number` and for each occurrence of the `digit` to remove it. After each removal, we compare the modified number with the current maximum number found and update the result accordingly.

#### Key Steps:
1. **Initialize Maximum Result**:
   - Start with an empty string `maxResult` to keep track of the largest number found.

2. **Iterate Over the String**:
   - For each character in `number`, if the character matches `digit`, remove that character from the string and compare the modified number with `maxResult`.

3. **Update Maximum**:
   - If the modified number is greater than the current `maxResult`, update `maxResult` to store the new larger number.

4. **Return Result**:
   - After iterating through all characters of `number`, return the largest possible number found.

---

### Code Implementation
Here’s the C# implementation:

```csharp
using System;

namespace LeetCodeProblems
{
    internal class Remove_Digit_From_Number_to_Maximize_Result
    {
        public string RemoveDigit(string number, char digit)
        {
            string maxResult = "";
            for (int i = 0; i < number.Length; i++)
            {
                string modifiedString = "";
                if (number[i] == digit)
                {
                    modifiedString = number.Remove(i, 1);
                    if (string.Compare(modifiedString, maxResult) > 0)
                    {
                        maxResult = modifiedString;
                    }
                }
            }

            return maxResult;
        }
    }
}
```

---

## Complexity Analysis

- **Time Complexity**:  
  \( O(n^2) \), where \(n\) is the length of the `number` string. In the worst case, for each character in the string, the `Remove` operation is called, which itself takes \(O(n)\) time.

- **Space Complexity**:  
  \( O(n) \), because we are storing the modified string after each removal and comparing it with the `maxResult`.

---

## Test Cases
Here are some test cases to validate the implementation:

```csharp
public void TestRemoveDigit()
{
    var solution = new Remove_Digit_From_Number_to_Maximize_Result();

    Console.WriteLine(solution.RemoveDigit("1231", '1') == "231"); // Example 1
    Console.WriteLine(solution.RemoveDigit("551", '5') == "51"); // Example 2
    Console.WriteLine(solution.RemoveDigit("100", '0') == "10"); // Remove 0 from "100"
    Console.WriteLine(solution.RemoveDigit("987", '9') == "87"); // Remove 9 from "987"
    Console.WriteLine(solution.RemoveDigit("54321", '3') == "5421"); // Remove 3 from "54321"
}
```

---

## Edge Cases
1. **Multiple Occurrences of the Digit**:
   - Example: `number = "1231", digit = '1'`
   - In this case, removing either occurrence of `1` should yield the largest result.

2. **Removing the Last Digit**:
   - Example: `number = "100", digit = '0'`
   - The largest number after removing `0` would be `"10"`.

3. **No Change to Number**:
   - Example: `number = "987", digit = '9'`
   - The largest number would be `"87"` after removing `9`.

4. **Single Occurrence of the Digit**:
   - Example: `number = "100", digit = '0'`
   - The largest possible result is `"10"`.

