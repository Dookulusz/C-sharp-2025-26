# Véletlen számok
## Függvény gyakorló feladatsor

## 2. Paraméterezett függvények

### 2.1 VéletlenSzámTartományban(int min, int max)
Írj egy függvényt, amely visszaad egy véletlen egész számot a megadott minimum és maximum értékek között (minimum inclusive, maximum exclusive).

**Szignatúra:** `int VéletlenSzámTartományban(int min, int max)`

**Példa hívás:** `VéletlenSzámTartományban(10, 20)`  
**Példa kimenet:** `15`

---

### 2.2 VéletlenParosSzám(int max)
Írj egy függvényt, amely visszaad egy véletlen páros számot 0 és a megadott maximum érték között.

**Szignatúra:** `int VéletlenParosSzám(int max)`

**Példa hívás:** `VéletlenParosSzám(20)`  
**Példa kimenet:** `14`

**Tipp:** Generálj egy véletlen számot 0 és max/2 között, majd szorozd meg 2-vel!

---

### 2.3 VéletlenPáratlanSzám(int max)
Írj egy függvényt, amely visszaad egy véletlen páratlan számot 1 és a megadott maximum érték között.

**Szignatúra:** `int VéletlenPáratlanSzám(int max)`

**Példa hívás:** `VéletlenPáratlanSzám(20)`  
**Példa kimenet:** `13`

---

### 2.4 Kockadobás(int oldalak)
Írj egy függvényt, amely szimulálja egy N oldalú kocka dobását (1-től N-ig).

---

## 3. Karakter és szöveg függvények

### 3.1 Kisbetű()
Írj egy függvényt, amely visszaad egy véletlen kisbetűt ('a'-tól 'z'-ig).

---

### 3.2 Nagybetű()
Írj egy függvényt, amely visszaad egy véletlen nagybetűt ('A'-tól 'Z'-ig).

---

### 3.3 Betű()
Írj egy függvényt, amely visszaad egy véletlen betűt (kis- vagy nagybetű véletlenszerűen).

---

### 3.4 Szöveg(int hossz)
Írj egy függvényt, amely visszaad egy megadott hosszúságú véletlen szöveget (csak kisbetűkből).

**Példa hívás:** `VéletlenSzöveg(8)`  
**Példa kimenet:** `"kpmqwzxa"`

---

### 3.5 Jelszó(int hossz)
Írj egy függvényt, amely visszaad egy megadott hosszúságú véletlen jelszót (kis- és nagybetűk, valamint számjegyek keveréke).

**Példa hívás:** `VéletlenJelszó(10)`  
**Példa kimenet:** `"aB7xK2mQp9"`

---

## 4. Összetett függvények

### 4.2 VéletlenDátum(int év)
Írj egy függvényt, amely visszaad egy véletlen dátumot a megadott évből (1-365 nap között, szökőévet ne vedd figyelembe).

**Példa hívás:** `VéletlenDátum(2024)`  
**Példa kimenet:** `"2024.07.23"`

---

### 4.3 RGB()
Írj egy függvényt, amely visszaad egy véletlen RGB színkódot szöveg formátumban.

**Példa kimenet:** `"RGB(142, 73, 201)"`

**Tipp:** Minden színkomponens 0-255 közötti érték!

---

### 4.4 Hex()
Írj egy függvényt, amely visszaad egy véletlen hexadecimális színkódot.

**Példa kimenet:** `"#A3F52C"`

**Tipp:** Generálj 6 véletlen hexadecimális karaktert (0-9, A-F)!

---

### 4.5 Telefonszám()
Írj egy függvényt, amely visszaad egy véletlen magyar telefonszámot "+36 XX XXX XXXX" formátumban.

**Szignatúra:** `string VéletlenTelefonszám()`

**Példa kimenet:** `"+36 20 456 7823"`

---

## 5. Bónusz kihívások

---

### 5.2 IPCím()
Írj egy függvényt, amely generál egy véletlen IPv4 címet (pl. "192.168.0.1" formátumban).

**Szignatúra:** `string VéletlenIPCím()`

**Példa kimenet:** `"172.16.254.1"`