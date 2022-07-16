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

![image](https://user-images.githubusercontent.com/5400940/179348788-0859f3a5-36f9-4dd0-a573-0d0b57f4a287.png)

W tej zakładce można wylistować wszystkich użytkowników oraz stworzyć nowego.

### Kontrola logowania

W ostatniej zakładce istnieje możliwość podglądu historii logowania i wylogowania wszystkich użytkowników w systemie.

![image](https://user-images.githubusercontent.com/5400940/179348839-cf0c4aae-1e98-49db-9ecb-cc83597cbd94.png)

### Definicje części

W zakładce "Części" można zdefiniować nazwy i wagi części, które będą sprawdzane w systemie.

![image](https://user-images.githubusercontent.com/5400940/179348884-3d9f959b-0b7a-40c5-85c9-9d9a96456571.png)

Pola edytujemy klikając podwójnie, można dodać wiersz wybierając ostatni - pusty - wiersz.

### Raporty

W zakładce "Raporty" istnieje możliwość wylistowania i stworzenia raportów kontroli jakości.

![image](https://user-images.githubusercontent.com/5400940/179348924-3894d211-cd9a-40fe-8051-09575d7acd67.png)

Przy dodawaniu raportu widzimy spodziewaną masę danej części, więc możemy ją porównać.

![image](https://user-images.githubusercontent.com/5400940/179348931-cd6aab47-1d7c-4778-b460-a2eef0fa3b5d.png)



### 



