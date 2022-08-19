# sekamar-tugas3
Anggota: Ferdian Priambodho dan Harryanto

List fitur:

## Scene:
	- Main Menu
	- Gameplay
	- Leaderboard
- Kalau masuk top 10 isi nama, ga masuk top ten = ga usah
- Leaderboard dengan custom name (bisa menampilkan top 10) yang ditampilkan di main menu.
Perpindahan scene dikerjakan oleh Harryanto.

## Gameplay
### Ada Player 1 (Optional: Player 2)
	- Player bisa gerak kiri kanan - Ferdian
	- Player ada move speednya - Ferdian
	- Player bisa nembak (jika peluru kena batas atas, maka nonaktif) - Harry
	- Player nyawa awal ada 3. (2 icon darah + 1 ga pake icon) - Ferdian
- Highscore = tertinggi di leaderboard - Harry
- Terdapat Power Up yang mengubah peluru agar bisa menembus 2 musuh. Power Up memiliki durasi, tidak permanen. >> Mungkin kasih darah untuk peluru, ketika hit 1 musuh, darah peluru kurang 1. Sehingga, masih bisa jalan untuk kena ke musuh kedua. - Ferdian
- Destructible Obstacle - Ferdian
- Ada BGM Looping (1 BGM untuk semuanya dari main menu - gameplay - leaderboard) - Ferdian
### SFX
	- Player nembak - Ferdian
	- Musuh nembak - Ferdian
	- UFO lewat - Ferdian

## Musuh:
### 4 jenis musuh - Harry:
	- ufo = random score, random spawn, bisa ke kiri atau ke kanan. muncul di paling atas. (pooling 1 object)
	- enemy 1 = 30 point, spawn 1 baris aja (pooling 11 object)
	- enemy 2 = 20 point, spawn 2 baris dibawah enemy 1 (pooling 11 x 2 object)
	- enemy 3 = 10 point, spawn 2 baris dibawah enemy 2 (pooling 11 x 2 object)
### Musuh paling bawah / yang tidak ada musuh lain di bawahnya bisa nembak.
	- nembaknya ada interval, semakin posisi musuh turun, intervalnya berkurang - Harry
	- musuh yang nembak random. jadi jalanin interval -> cari musuh yang tidak ada musuh lagi dibawahnya -> pilih random buat nembak. - Harry
	- peluru musuh jika kena batas bawah, hancur (nonaktif) - Harry
- Musuh ketika mentok kiri/kanan: maka akan turun ke bawah 1 baris, speednya nambah (termasuk interval nembak), berjalan lawan arah sebelumnya - Ferdian
- Setiap level baru, musuh turun 1 baris dari baris teratas dia spawn sebelumnya - Ferdian
