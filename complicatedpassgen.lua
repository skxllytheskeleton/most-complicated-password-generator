--My most COMPLICATED password generator
--Written by Logan Knowles, age 13
--REQUIRES THE UTF8 LIBRARY TO WORK
local utf8 = require("utf8")
function utf8sub(str,char1,char2)
  local start = utf8.offset(str,char1)
  local endb = utf8.offset(str,char2 + 1) - 1
  return string.sub(str,start,endb)
end
--Settings
local length = 20
local includecapitals = true
local includenumbers = true
local includesymbols = true
local includeemojis = true
local includenonlatin = true
local includestupidity = true
local includeunicode = true
local includewhitespace = true
--Set-up
local allchars = ""
function randomchar()
  local index = math.random(1,utf8.len(allchars))
  return utf8sub(allchars,index,index)
end
--Pools
local alphabet = "abcdefghijklmnopqrstuvwxyz"
local numbers = "0123456789"
local symbols = "`~!@#$%^&*()-_=+{}[]|;:'<>,./?"
local emojis = "💿🍁🧂😠😭🪑😛💔🥀🕊️✌️🙏"
local nonlatin = "ΑαΔδΗηθΘεΕβΒΓγΖζΙιπΠνΝκΚΛλΞξΡρςΣοΟμΜΤτΧχσϠϡψΨυΥΦφΩωϜϝέΈ"
local stupidity = "–—€£¥©²°•é→←—№™®℗©℃−§¦⌈⌉⌊⌋‖⟬⟭⟧⟦⟫⟪‰⁂✓✕⁐¿�¡"
local unicode = "☂☎☘☢☣☪☮☯☻☀☬♻"
local whitespace = "  "
--Set-up²
allchars = allchars..alphabet
--Apply settings
if includecapitals then
  allchars = allchars..string.upper(alphabet)
end
if includenumbers then
  allchars = allchars..numbers
end
if includesymbols then
  allchars = allchars..symbols
end
if includeemojis then
  allchars = allchars..emojis
end
if includenonlatin then
  allchars = allchars..nonlatin
end
if includestupidity then
  allchars = allchars..stupidity
end
if includeunicode then
  allchars = allchars..unicode
end
if includewhitespace then
  allchars = allchars..whitespace
end
--Create password
local password = ""
for i = 1, length do
  password = password..randomchar()
end
--Output
print(password)