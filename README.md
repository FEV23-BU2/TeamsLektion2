---
author: Lektion 2
---

# Teams lektion 2

Hej och välkommen!

## Agenda

1. Svar på frågor
2. Repetition
3. Genomgång av övningar
4. *Fortsättning på skolsystem*
5. Övning

---

# Fråga

Kan vi blanda React och Angular när vi bygger frontend?

# Svar

Vi kan försöka, men om det inte finns tid så fokuserar vi på backend och sedan React.

---

# Fråga

Om man vill spara vem man har loggat in som, behöver man göra det i backend? Ska det ligga direkt i API:et?

# Svar

Ja och nej. Det finns olika system för att hantera autentisering.

---

# Fråga

Kan man ha controllers i flera olika filer?

# Svar

Ja!

---

# Fråga

Behöver man ha `[Route("?")]`? Behöver man ha extra vägar som i video lektion 1 för todos, det vill säga koppla till id och todos?

# Svar

Nej. Routes krävs endast när man skall ha fler endpoints med samma namn och metod (så att de inte kolliderar).

När det kommer till `id` path variabeln så är det också bara ett val, man kan lika gärna använda en kropp, query parametrar eller headers.

---

# Fråga

Kan vi gå igenom och titta mer på hur olika appar fungerar mer? Som exempelvis facebook och instagram.

# Svar

Halvt. De flesta appar gör inte backend synlig, utan endast API:et.

---

# Fråga

Kan du förklara modeller mer? Kan det liknas/jämföras med komponenter? Hur läggs de in i kod?

Blir det `public class User` på en user modell exempelvis?

# Svar

En modell är en samling med egenskaper och data som representerar något i en applikation.

De läggs oftast in genom klasser.
