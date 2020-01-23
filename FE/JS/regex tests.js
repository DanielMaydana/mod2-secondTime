/*
  .   - Any char but new line
  \d  - Digit (0-9)
  \D  - Not a digit
  \w  - Word char (a-z, A-Z, 0-9, _)
  \W  - Not a word char
  \s  - Whitespace (space, tab, newline)
  \S  - Not a whitespace

  \b  - Word boundary
  \B  - Not word boundary
  ^   - Begginning of a string
  $   - End of string

  []  - Matches characters inside
  [^] - matches characters not inside
  |   - Either or
  ()  - Group

  ?   - 0 or one
  *   - 0 or more
  +   - 1 or more
  {n} - Exact qty
  {n,m} - Qty inside range

  i   - Case-insensitive
  g   - All matches, not only the first one
  m   - Multiline
  s   - Dotall mode on, "." as "\n"
  u   - Full incode mode on
*/

/[(1-9)]{3}-[(1-9)]{3}-[(1-9)]{3}\b/g
/ [(A - z)((1 - 9){1})] + /g

/\b[a-z1-9]+\b/g

/CS.?4/g
/1.?-.?5/g

/^Mary.*lamb$/gm

/^(?=.*[1-9])(?=.*[a-z])([a-z1-9]+)$/g