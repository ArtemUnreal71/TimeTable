# 📅 Úkolníček – Osobní plánovač ve Windows Forms

## 📝 Popis

Tento projekt vznikl z vlastní iniciativy jako cvičení pro zlepšení práce s **Windows Forms** a poznání nových funkcí komponenty `DataGridView`. Jedná se o jednoduchý **denní úkolníček**, do kterého si uživatel může zadávat úkoly na libovolný den v rozmezí let **2004 až 2104**.

Aplikace umožňuje:

- ➕ Vytvářet, upravovat a spravovat úkoly podle data
- 📊 Sledovat, na kolik procent jsou jednotlivé úkoly splněny
- ⏱️ Spouštět **časovač** pro aktivní úkoly
- 🔥 Sleduje tzv. **streak counter** – počet dní, kdy byly všechny úkoly daného dne splněny

## ⚙️ Funkce

- 📆 **Výběr dne** z kalendáře (levý panel)
- 📝 **Zobrazení úkolů** pro vybraný den (pravý panel)
- ✏️ **Režim úprav** dne:
  - 📅 *Minulé a dnešní dny*: úkoly lze pouze prohlížet a měnit stav splnění
  - 📈 *Budoucí dny*: možnost přidávat, upravovat a mazat úkoly
- 🔍 **Detail úkolu** obsahuje:
  - 🏷️ Název a popis
  - ⏳ Časová náročnost
  - ⭐ Prioritu (důležitý / volitelný)
  - ✅ Stav splnění (rozčleněno na čtvrtiny)
- ▶️ **Startovací tlačítko** pro spuštění odpočtu času u aktivních úkolů
- 💾 **Automatické ukládání** veškerých dat do JSON souborů ve složce `AppData`

## 🛠️ Technologie

- 💻 **Jazyk**: C#
- 🖼️ **UI**: Windows Forms
- 🗃️ **Formát ukládání dat**: JSON (`AppData` adresář)

## 🎯 Cíl projektu

Cílem bylo samostatně:
- 🧠 Procvičit práci s `Windows Forms`
- 📊 Naučit se využívat `DataGridView` v praxi
- 🕓 Zopakovat si a prohloubit práci s časovačem a souborovým uložištěm
