# Hashing

You are given two strings s1 and s2.

Before processing, both strings must be normalized:
- remove all characters except letters (`A-Z`, `a-z`),
- convert all letters to lowercase,
- remove spaces.

After normalization, the strings must be checked for *enhanced isomorphism*.

Two strings are considered isomorphic if the following conditions hold:

1. There exists a bijective mapping between characters of s1 and s2.  
   (Each character of one string maps to a unique character of the other.)

2. Their frequency profiles match.  
   (The multiset of character frequencies is identical.)

### Input Format
Two strings, each on a separate line.

### Output Format
One number:
- 1 if the strings are isomorphic  
- 0 otherwise

### Constraints
- String length: 1–200000  
- Any ASCII characters allowed  
- Expected complexity: O(n)
