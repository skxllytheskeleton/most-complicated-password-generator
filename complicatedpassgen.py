# My most COMPLICATED password generator
# Written by skxllytheskeleton - https://github.com/skxllytheskeleton/

# Settings
length = 20
includecapitals = True
includenumbers = True
includesymbols = True
includeemojis = True
includenonlatin = True
includestupidity = True
includeunicode = True
# Set-up
import random
allchars = ""
def randomchar():
  return random.choice(allchars)
# Pools
alphabet = "abcdefghijklmnopqrstuvwxyz"
numbers = "0123456789"
symbols = "`~!@#$%^&*()-_=+{}[]|;:'<>,./?"
emojis = "💿🍁🧂😠😭🪑😛💔🥀🕊️✌️🙏"
nonlatin = "ΑαΔδΗηθΘεΕβΒΓγΖζΙιπΠνΝκΚΛλΞξΡρςΣοΟμΜΤτΧχσϠϡψΨυΥΦφΩωϜϝέΈ"
stupidity = "–—€£¥©²°•é→←—№™®℗©℃−§¦⌈⌉⌊⌋‖⟬⟭⟧⟦⟫⟪‰⁂✓✕⁐¿�¡"
uni = "☂☎☘☢☣☪☮☯☻☀☬♻"
# Set-up²
allchars += alphabet
# Apply Settings
if includecapitals:
  allchars += alphabet.upper()
if includenumbers:
  allchars += numbers
if includesymbols:
  allchars += symbols
if includeemojis:
  allchars += emojis
if includenonlatin:
  allchars += nonlatin
if includestupidity:
  allchars += stupidity
if includeunicode:
  allchars += uni
# Create password
password = ""
for i in range(1, (length + 1)):
  password += randomchar()
# Output
print(password)
