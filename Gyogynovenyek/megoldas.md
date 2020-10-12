# Megoldás

# Osztály létrehozása
- Kétféle mó közül bármelyik
	x- ctrl + .
	x- Adjunk hozzá egy osztályt
- 5 tulajdonság
	x- public get, private set
- 1 konstruktor
	x- 1 paraméter --> string
	x- példa paraméter --> "Acsalapu;levél;6;8"
	x- ;-vel vannak elválasztva
	x- 4db adat --> 5 tulajdonság?
	- átadott, fájlból beolvasott sort:
		x- ; mentén tagoljuk
		x- [0] --> nev
		x- [1] --> resz
		x- [2] --> kezd
		x- [3] --> veg
		x- idotartam --> számolás (lásd következő pont)
- 5dik tulajdonság --> időtartam
		x- Konstruktorban számoljuk
		x- számolása: veg-kezd ha veg > kezd
		x- veg > kezd --> (veg-kezd) +1
		x- egyébként --> 12- kezd + veg + 1

## Adatok beolvasása és eltárolása
x- Listában tároljuk az objektum példányait
- Olvassuk be:
	x- System.IO
	x- Streamreader
	x- while ciklussal --> amíg tart a fájl
	x- Cikluson belül listához adunk egy új objektum példányt (beolvasott sor lesz a paraméter)

## 1.feladat
x- Hány növény van --> Lista.Count

## 2.feladat
x- Milyen gyűjthető részek vannak?
x- Hány db van ezekből?
x- Dictionary kell
x- 1 Milyen gyűjthető részek
	x- foreach "noveny"
	x- ha a rész nem kulcs --> adjuk hozzá 0-val
x- 2 hány darab van ezekből
x- foreach noveny
x- Ha resz == key --> value++;


## 3.feladat
- Maximum keresés --> idotartam alapján
- Növények amely(ek)et a legtöbb ideig szedhetjük

## 4.feladat
- Idotartam átlagszámítás
