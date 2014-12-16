BIF/SWE 1 Prüfungsvorlage
=========================

C# Template für die Prüfung. Damit die Prüfung erfolgreich abgegeben werden kann müssen folgende Kriterien erfüllt sein:

* Benutzen Sie bitte die Vorlage. Sie ist so vorbereitet, dass sie am Jenkins verwendet werden kann.
* Richten Sie ein Repository ein und geben Sie durch hochladen (git push) ab.

Diese Vorlage wurde für Visual Studio 2013 erstellt. Sie können aber jede andere Entwicklungsumgebung benutzen, solange BIF-SWE1.sln am Jenkins kompilierbar bleibt.

> Bereiten Sie bitte alles **VOR** der Prüfung vor!

Repository
----------
https://inf-swe-git.technikum-wien.at/

Das Repository ist selbst anzulegen: 

* my dashboard 
* owned 
* new repository 
* if00x000/BIF-WS??-SWE1-Exam

Das Repository hat die URL: https://if00x000@inf-swe-git.technikum-wien.at/?r=~if00x000/BIF-WS??-SWE1-Exam.git

* if00x000 ist durch Ihre if-Nummer zu ersetzen
* BIF-WS??-SWE1-Exam durch das Jahr (WS 14/15 -> BIF-WS14-SWE1)

Setup des Projektes
-------------------
https://inf-swe-git.technikum-wien.at/summary/?r=BIF/SWE1-CS-Exam.git

Clonen Sie das Template in ein Verzeichnis Ihrer wahl und ändern Sie anschließend den remote/origin auf Ihr Repository
	
	git clone https://inf-swe-git.technikum-wien.at/r/BIF/SWE1-CS-Exam.git
	cd SWE1-CS-Exam
	git remote set-url origin https://if00x000@inf-swe-git.technikum-wien.at/r/~if00x000/BIF-WS??-SWE1-Exam.git
    git push origin master

Überprüfen Sie im Anschluss, ob Jenkins Ihre erste "Abgabe" erkannt hat und fehlerfrei kompilieren konnte.

Prüfung
-------
Alle weitere Angaben zur Prüfung finden Sie in einem gesonderten Dokument.
