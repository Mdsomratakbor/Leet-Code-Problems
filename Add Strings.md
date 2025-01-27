# Add Strings

## Problem Description
Given two non-negative integers `num1` and `num2` represented as strings, return their sum as a string. You must solve this problem without converting the input strings to integers directly.

### Example Input and Output:

#### Example 1:
- **Input**: `num1 = "11"`, `num2 = "123"`
- **Output**: `"134"`

#### Example 2:
- **Input**: `num1 = "456"`, `num2 = "77"`
- **Output**: `"533"`

#### Example 3:
- **Input**: `num1 = "0"`, `num2 = "0"`
- **Output**: `"0"`

---

## Constraints
1. Both `num1` and `num2` consist only of digits (`'0'`–`'9'`).
2. Both `num1` and `num2` do not have leading zeros except for the number `0` itself.
3. The lengths of `num1` and `num2` are in the range `[1, 10^4]`.

---

## Solution

### Approach
This solution mimics the manual process of adding numbers digit by digit from the least significant digit (rightmost) to the most significant digit (leftmost), taking care of the carry value.

#### Key Steps:
1. **Initialization**:
   - Use pointers `i` and `j` to traverse the strings `num1` and `num2` from right to left.
   - Initialize a variable `carry` to keep track of the carry from each addition.
   - Initialize an empty string `result` to store the final sum.

2. **Iterative Addition**:
   - For each digit from the rightmost position:
     - Convert the character at position `i` in `num1` and `j` in `num2` to integers (`digit1` and `digit2`).
     - Compute the sum of `digit1`, `digit2`, and `carry`.
     - Update `carry` with `sum / 10`.
     - Append the least significant digit of the sum (`sum % 10`) to the result.

3. **Handle Remaining Carry**:
   - If a carry remains after processing all digits, append it to the result.

4. **Return Result**:
   - Since the result is constructed in reverse order, return its reverse as the final output.

---

### Code Implementation
Here’s the C# implementation:

```csharp
using System;

namespace LeetCodeProblems
{
    internal class AddString
    {
        public string AddStrings(string num1, string num2)
        {
            int i = num1.Length - 1, j = num2.Length - 1, carry = 0;
            string result = "";

            while (i >= 0 || j >= 0 || carry > 0)
            {
                int digit1 = i >= 0 ? (int)num1[i] - '0' : 0;
                int digit2 = j >= 0 ? (int)num2[j] - '0' : 0;
                int total = digit1 + digit2 + carry;
                carry = total / 10;
                result = (total % 10) + result;
                i--;
                j--;
            }
            return result;
        }
    }
}
```

---

## Complexity Analysis

- **Time Complexity**:  
  \(O(\max(n, m))\), where \(n\) and \(m\) are the lengths of `num1` and `num2`. The solution iterates through the digits of the longer string.

- **Space Complexity**:  
  \(O(\max(n, m))\), as the result string will store up to \( \max(n, m) + 1 \) digits, including the carry.

---

## Test Cases
Here are some test cases to validate the implementation:

```csharp
public void TestAddStrings()
{
    var addString = new AddString();

    Console.WriteLine(addString.AddStrings("11", "123") == "134"); // Example 1
    Console.WriteLine(addString.AddStrings("456", "77") == "533"); // Example 2
    Console.WriteLine(addString.AddStrings("0", "0") == "0"); // Example 3
    Console.WriteLine(addString.AddStrings("999", "1") == "1000"); // Carry over all digits
    Console.WriteLine(addString.AddStrings("1", "9999") == "10000"); // Unequal lengths
}
```

---

## Edge Cases
1. **Different lengths**:
   - Example: `num1 = "1"`, `num2 = "9999"`
   - Output: `"10000"`

2. **Single-digit inputs**:
   - Example: `num1 = "8"`, `num2 = "7"`
   - Output: `"15"`

3. **Large numbers**:
   - Example: `num1 = "12345678901234567890"`, `num2 = "98765432109876543210"`
   - Output: `"111111111011111111100"`

4. **Trailing zeros**:
   - Example: `num1 = "1000"`, `num2 = "0"`
   - Output: `"1000"`
