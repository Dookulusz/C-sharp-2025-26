# Véletlen számok

Véletlen számok készítéséhez szükségünk van egy véletlenszám-generátorra.

```csharp
Random generátor = new Random();
```

## Példa

Készítsünk egy függvényt, ami véletlen számot állít elő egy tartományból!

```csharp
int Szám(int küszöb, int plafon)
{
    Random rng = new Random();

    int véletlen = rng.Next(küszöb, plafon);

    return véletlen;
}

/* függvény hívása */
int eredmény = Szám(0, 10);
```

---

## Tesztelés

Minden függvényt tesztelj! Például:

```csharp
Console.WriteLine("Számjegy: " + Számjegy());
Console.WriteLine("Százalék: " + Százalék());
Console.WriteLine("Szöveg: " + Szöveg(10));
Console.WriteLine("Jelszó: " + Jelszó(12));
```

---

## 1. Egyszerű függvények

### Számjegy()

Függvény, amely visszaad egy véletlen decimális számjegyet!
(0-9 közötti szám, a két szélsőértéket is beleértve).

---

### Dobókocka()

Függvény, ami visszaad egy véletlen számot az [1;6] zárt intervallumból!

---

### Százalék()

Függvény, ami visszaad egy véletlen egész számot 0 és 100 között!
(a két szőlső értéket is beleértve).

---

### Pénzérem()

Függvény, ami véletlenszerűen `true` vagy `false` értéket ad vissza.

---

## 2. Karakter és szöveg függvények

### Kisbetű()
Függvény, amit visszaad egy véletlen kisbetűt ('a'-tól 'z'-ig).

**Tipp:** Az 'a' karakter ASCII kódja 97, és 26 betű van az angol ábécében.

```csharp
// egy adott betű Unicode sorszáma
int szam = (int) 'a';

// adott sorszámahoz tartozó karakter
char betu = (char) 97;
```

---

### Nagybetű()

Függvény, ami visszaad egy véletlen nagybetűt ('A'-tól 'Z'-ig).

**Tipp**: a char osztály metódusait a pont operátorral érjük el.

---

### Betű()

Függvény, ami visszaad egy véletlen betűt (kis- vagy nagybetű véletlenszerűen).

**Tipp:** Pénzfeldobással dönthetnénk, hogy kicsi vagy nagybetűt adunk vissza...

---

### Szöveg(int hossz)

Függvény, ami visszaad egy megadott hosszúságú véletlen szöveget.
Az első betűje nagybetű legyen, a többi karakter kisbetűs.
Tételezzük fel, hogy a hossz értéke egy pozitív egész szám.

**Tipp:** Használj ciklust és a  függvényt!

**Példa hívás:** `Szöveg(8)`  
**Példa kimenet:** `"Abcdefgh"`
---

### Jelszó(int hossz)

Függvény, ami visszaad egy megadott hosszúságú véletlen jelszót.
Kis- és nagybetűk, valamint számjegyek keveréke.
Tételezzük fel, hogy a hossz értéke egy pozitív egész szám.

**Példa hívás:** `Jelszó(10)`  
**Példa kimenet:** `"aB7xK2mQp9"`
**Tipp** Legyen 30% esély a kisbetűre, 30% a nagybetűre, 40% a számjegyre.

---

## 3. Összetett függvények

### Dátum

Függvény, ami visszaad egy véletlen dátumot.
Az egíszerűség kedvéért tekintsük a hónapokat 28 naposnak.

**Példa hívás:** `Dátum()`  
**Példa kimenet:** `"2024.07.23"`

---

### 4.3 RGB()

Függvény, ami visszaad egy véletlen RGB színkódot szöveg formátumban.

**Példa kimenet:** `"RGB(142, 73, 201)"`

---

### Hex()

Függvény, ami visszaad egy véletlen hexadecimális színkódot.

**Példa kimenet:** `"#A3F52C"`

---

### Telefonszám()

Függvény, ami visszaad egy véletlen magyar telefonszámot "+36 XX XXX XXXX" formátumban.

**Példa kimenet:** `"+36 20 456 7823"`

---

### IPCím()

Függvény, ami generál egy véletlen IPv4 címet (pl. "192.168.0.1" formátumban).

**Példa kimenet:** `"172.16.254.1"`