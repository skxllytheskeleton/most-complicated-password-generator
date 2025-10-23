// My most COMPLICATED password generator
// Written by Logan Knowles, age 13

// Settings
let length = 20;
let includecapitals = true;
let includenumbers = true;
let includesymbols = true;
let includeemojis = true;
let includenonlatin = true;
let includestupidity = true;
let includeunicode = true;
// Set-up
let allchars = "";
function randomchar() {
  let index = Math.floor(Math.random() * allchars.length);
  return allchars.charAt(index);
}
// Pools (this is where it gets crazy)
let alphabet = "abcdefghijklmnopqrstuvwxyz";
let numbers = "0123456789";
let symbols = "`~!@#$%^&*()-_=+{}[]|;:'<>,./?";
let emojis = "💿🍁🧂😠😭🪑😛💔🥀🕊️✌️🙏"; // If you think I'm gonna type every single emoji here you're mistaken.
let nonlatin = "ΑαΔδΗηθΘεΕβΒΓγΖζΙιπΠνΝκΚΛλΞξΡρςΣοΟμΜΤτΧχσϠϡψΨυΥΦφΩωϜϝέΈ"; // I am NOT typing every single non-latin character 😭🙏
let stupidity = "–—€£¥©²°•é→←—№™®℗©℃−§¦⌈⌉⌊⌋‖⟬⟭⟧⟦⟫⟪‰⁂✓✕⁐¿�¡";
let unicode = "☂☎☘☢☣☪☮☯☻☀☬♻"; // HELL NO IM NOT TYPING THEM ALL 💔💔
// Set-up²
allchars += alphabet;
// Apply settings
// Fucking look at these fucking if statements.
if (includecapitals) {
  allchars += alphabet.toUpperCase();
}
if (includenumbers) {
  allchars += numbers;
}
if (includesymbols) {
  allchars += symbols;
}
if (includeemojis) {
  allchars += emojis;
}
if (includenonlatin) {
  allchars += nonlatin;
}
if (includestupidity) {
  allchars += stupidity;
}
if (includeunicode) {
  allchars += unicode;
}
// Create password
let password = "";
for (let i = 0; i < length; i++) {
  password += randomchar();
}
// Output
console.log(password);
// Never again.