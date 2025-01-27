# Maximum Number of Words Found in Sentences

## Problem Description
You are given a list of sentences. Each sentence is a string consisting of words separated by a single space. Your task is to determine the maximum number of words that appear in any single sentence.

### Example Input and Output:

#### Example 1:
- **Input**: `sentences = ["alice and bob love leetcode", "i think so too", "this is great thanks very much"]`
- **Output**: `6`

#### Example 2:
- **Input**: `sentences = ["please wait", "continue to fight", "continue to win"]`
- **Output**: `3`

---

## Constraints
1. \( 1 \leq \text{sentences.length} \leq 100 \)
2. \( 1 \leq \text{sentences[i].length} \leq 100 \)
3. Each sentence consists only of lowercase English letters and spaces.
4. Words in a sentence are separated by a single space.

---

## Solution

### Approach
This solution iterates through each sentence, splits the sentence into words based on spaces, and calculates the word count. The maximum word count among all sentences is tracked and returned.

#### Key Steps:
1. **Initialization**:
   - Start with `maximumCount = 0` to track the largest number of words found so far.

2. **Iterate Over Sentences**:
   - For each sentence in the array, split it into words using the `Split` method with a space character as the delimiter.
   - Count the number of words in the split array.

3. **Update Maximum**:
   - Compare the current sentence's word count with `maximumCount` and update it if the current count is greater.

4. **Return Result**:
   - After processing all sentences, return the value of `maximumCount`.

---

### Code Implementation
Here’s the C# implementation:

```csharp
using System;

namespace LeetCodeProblems
{
    public class Maximum_Number_of_Words_Found_in_Sentences
    {
        public int MostWordsFound(string[] sentences)
        {
            int maximumCount = 0;
            foreach (string sentence in sentences)
            {
                string[] sentenceWords = sentence.Split(' ');
                int length = sentenceWords.Length;
                if (length > maximumCount)
                {
                    maximumCount = length;
                }
            }
            return maximumCount;
        }
    }
}
```

---

## Complexity Analysis

- **Time Complexity**:  
  \(O(n \cdot m)\), where \(n\) is the number of sentences, and \(m\) is the average number of characters in each sentence. Splitting a sentence into words involves iterating through all characters in the sentence.

- **Space Complexity**:  
  \(O(k)\), where \(k\) is the maximum number of words in any sentence, as the `Split` method creates an array of words for each sentence.

---

## Test Cases
Here are some test cases to validate the implementation:

```csharp
public void TestMostWordsFound()
{
    var solution = new Maximum_Number_of_Words_Found_in_Sentences();

    Console.WriteLine(solution.MostWordsFound(new[] { "alice and bob love leetcode", "i think so too", "this is great thanks very much" }) == 6); // Example 1
    Console.WriteLine(solution.MostWordsFound(new[] { "please wait", "continue to fight", "continue to win" }) == 3); // Example 2
    Console.WriteLine(solution.MostWordsFound(new[] { "one two three", "four five", "six" }) == 3); // Mixed-length sentences
    Console.WriteLine(solution.MostWordsFound(new[] { "a" }) == 1); // Single word
    Console.WriteLine(solution.MostWordsFound(new[] { "a b c d e", "f g", "h" }) == 5); // Different word counts
}
```

---

## Edge Cases
1. **Single Sentence**:
   - Example: `sentences = ["a single sentence"]`
   - Output: `3`

2. **Single Word Sentences**:
   - Example: `sentences = ["a", "b", "c"]`
   - Output: `1`

3. **Varying Length Sentences**:
   - Example: `sentences = ["short", "long sentence example with more words"]`
   - Output: `6`

4. **Empty Sentence Array**:
   - Input: `sentences = []`
   - Expected behavior: Handled gracefully if the problem constraints allow empty input.

