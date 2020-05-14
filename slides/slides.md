---
theme: "black"
separator: '^\r?\n---\r?\n$'
verticalSeparator: '^\r?\n--\r?\n$'
controls: false
menu: false
history: true
progress: false
slideNumber: false
mouseWheel: true
enableMenu: false
enableChalkboard: false
enableTitleFooter: false
---

# C# Source Generators

_by Jakub Šturc_

---

## About me 🤓

* Principal SW Developer @ ERNI
* Doing .NET for almost 20 years
* Father of 👧👦👶

---

## Disclaimer ⚠

* This is 2 weeks old preview
  * Tooling is not ready yet
  * Things will change
  * Not 1.0 quality
* I am not expert

---

## Prerequisites 📌

* .NET 5 Preview
* Visual Studio 2019 Preview
  * I am using 16.6.0 Preview 6

note:
VS won't be required in a future versions

---

## What is a Source Generator

Roslyn Analyzer that can emit C# source code during compilation.

--

![Source Generator](slides/source-generator.png)

---

## Demo 👨‍💻

---

## Some good use cases ✅

* Generate C# from non-C# files
* 
* 
* ... your idea 💡

---

## Not good fit ⛔

* Modify source code
* Implement a new language feature

---

## Comparison with T4 ⚖

* Both are not rewriting existing code
* T4 can generate any file (not just C#)
* T4 depends on Visual Studio & Windows
* Source Generators runs inside compiler

---

## Research Topics 🔬

* Reflecting generated code
* Debugging generated code
* Applying generators recursively

---

## References 🔗

* [Introducing C# Source Generators](https://devblogs.microsoft.com/dotnet/introducing-c-source-generators/)
* [Source Generators Cookbook](https://github.com/dotnet/roslyn/blob/master/docs/features/source-generators.cookbook.md)

---

## Questions 🤔

---

## Thank you 🍻
