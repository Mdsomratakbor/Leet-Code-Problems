# Capitalize the Title

## Problem Description
Given a string `title`, you are tasked with capitalizing the words in the title according to the following rules:

1. Words with **length greater than 2** should have their first letter in uppercase and the remaining letters in lowercase.
2. Words with **length 2 or less** should be converted to lowercase.
3. Return the modified title as a single string, preserving spaces between words.

### Example Input and Output:
#### Example 1:
- **Input**: `"capiTalIze tHe titLe"`
- **Output**: `"Capitalize The Title"`

#### Example 2:
- **Input**: `"First leTTeR of EACH Word"`
- **Output**: `"First Letter Of Each Word"`

#### Example 3:
- **Input**: `"i lOvE proGramming"`
- **Output**: `"i love Programming"`

---

## Solution

### Approach 1: Using Manual Parsing
This approach processes the input string character by character and constructs the output by keeping track of words. It uses a temporary string to store the current word and determines whether to capitalize or lowercase based on word length.

#### Key Steps:
1. Traverse the string while identifying words separated by spaces.
2. For each word:
   - If the length is greater than 2, capitalize the first letter and lowercase the rest.
   - Otherwise, convert the entire word to lowercase.
3. Append each processed word to a `StringBuilder`, adding spaces between them.
4. Handle the last word after traversal if no trailing space exists.

#### Code:
```csharp
public string CapitalizeTitle(string title)
{
    StringBuilder convertedTitle = new StringBuilder();
    int length = 0;
    bool isSpaceFound = true; // Start as if a space was found to handle the first word
    string temporaryWord = "";

    while (length < title.Length)
    {
        if (title[length] == ' ') // Space encountered
        {
            if (temporaryWord.Length > 2) // Capitalize if word length > 2
            {
                convertedTitle.Append(char.ToUpper(temporaryWord[0]));
                convertedTitle.Append(temporaryWord.Substring(1).ToLower());
                convertedTitle.Append(' ');
            }
            else if (temporaryWord.Length > 0) // Append short words as lowercase
            {
                convertedTitle.Append(temporaryWord.ToLower());
                convertedTitle.Append(' ');
            }
            else
            {
                convertedTitle.Append(' '); // Preserve multiple spaces
            }
            temporaryWord = ""; // Reset temporary word
            isSpaceFound = true;
        }
        else // Character encountered
        {
            if (isSpaceFound)
            {
                temporaryWord += title[length]; // Start a new word
                isSpaceFound = false;
            }
            else
            {
                temporaryWord += title[length]; // Continue the current word
            }
        }

        length++;
    }

    // Handle the last word (if there's no trailing space)
    if (temporaryWord.Length > 2)
    {
        convertedTitle.Append(char.ToUpper(temporaryWord[0]));
        convertedTitle.Append(temporaryWord.Substring(1).ToLower());
    }
    else if (temporaryWord.Length > 0)
    {
        convertedTitle.Append(temporaryWord.ToLower());
    }

    return convertedTitle.ToString();
}
```

---

### Approach 2: Using String Split and Join
This approach splits the input string into words, processes each word, and joins the result into a single string. It's more concise and leverages built-in methods.

#### Key Steps:
1. Split the input string into an array of words using spaces as delimiters.
2. For each word:
   - Capitalize the first letter and lowercase the rest if the word's length is greater than 2.
   - Convert the entire word to lowercase if its length is 2 or less.
3. Join the processed words into a single string, separated by spaces.

#### Code:
```csharp
public string CapitalizeTitle_Second(string title)
{
    StringBuilder convertedTitle = new StringBuilder();
    string[] words = title.Split(' '); // Split the title into words by spaces

    foreach (string word in words)
    {
        if (word.Length > 2) // Capitalize words with more than 2 characters
        {
            convertedTitle.Append(char.ToUpper(word[0]));
            convertedTitle.Append(word.Substring(1).ToLower());
        }
        else // Keep shorter words lowercase
        {
            convertedTitle.Append(word.ToLower());
        }
        convertedTitle.Append(' '); // Add space after each word
    }

    return convertedTitle.ToString().TrimEnd(); // Trim the trailing space
}
```

---

## Complexity Analysis
- **Time Complexity**:  
  - Approach 1: \(O(n)\), where \(n\) is the length of the input string (single traversal).
  - Approach 2: \(O(n)\), where \(n\) is the total length of the input string and its words.
  
- **Space Complexity**:  
  - Both approaches: \(O(n)\) for the `StringBuilder` or array storage.

---

## Usage
1. Clone or download the repository.
2. Add the `Capitalize_the_Title` class to your project.
3. Call the `CapitalizeTitle` or `CapitalizeTitle_Second` method with your input string.

---

## Test Cases
You can add these test cases to validate the implementation:

```csharp
public void TestCapitalizeTitle()
{
    var obj = new Capitalize_the_Title();

    Console.WriteLine(obj.CapitalizeTitle("hello world") == "Hello World");
    Console.WriteLine(obj.CapitalizeTitle("i love programming") == "i love Programming");
    Console.WriteLine(obj.CapitalizeTitle_Second("First leTTeR of EACH Word") == "First Letter Of Each Word");
}
```

Feel free to contribute or suggest improvements! 🎉
