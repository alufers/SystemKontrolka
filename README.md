---
title: "System Kontrolka - aplikacja WPF"
subtitle: "Albert Koczy, Numer indeksu: 13942"
toc: yes
---

# SystemKontrolka 

## Albert Koczy, numer indeksu: 13942

System kontrolka jest rozwiązaniem pozwalającym na zapis usterek w procesie kontroli jakości. Taki system może być zastosowany w każdej firmie, która produkuje jakieś elementy w celu wyeliminowania defektów produkcyjnych.

## Szczegóły techniczne

System napisany jest w języku c# z użyciem frameworka WPF (Windows Presentation Foundation). Wszystkie dane programu trzymane są w bazie SQLite przy pomocy rozwiązania Entity Framework.

## Użycie

### Logowanie

Przed uzyskaniem dostępu do jakichkolwiek funkcji programu wymagane jest zalogowanie się. Dlatego najpierw pojawia się okno logowania. Przy pierwszym uruchmieniu programu tworzony jest użytkownik o nazwie `admin` i haśle `admin`. Użytkownik ten ma najwyższe uprawnienia.

![image](https://user-images.githubusercontent.com/5400940/179348365-9d94dba1-ad02-479c-b50c-1dde07d3b55c.png)

Po zalogowaniu zobaczymy ekran powitalny:

![image](https://user-images.githubusercontent.com/5400940/179348403-056a552d-2955-42b4-a62f-cb2b53440139.png)


### Zarządzanie użytkownikami

Pierwszą rzeczą jaką będzie musiał zrobić administrator systemu jest stwrozenie kont dla poszczególnych pracowników firmy. Takie zadanie można wykonań w zakładce "Użytkownicy".

