<div align="center">

# 🔥 OdinProtocol — Samsung Advanced Flasher

**أداة فلاش حديثة لنظام Windows لأجهزة سامسونج — مبنية على بروتوكول ODIN**  
*Modern Windows flasher for Samsung Galaxy — built on the Odin download-mode protocol*

[![License: MIT](https://img.shields.io/badge/License-MIT-green.svg)](LICENSE)
![.NET Framework](https://img.shields.io/badge/.NET_Framework-4.8-5C2D91)
![Language](https://img.shields.io/badge/Language-C%23-239120)
![Platform](https://img.shields.io/badge/Platform-Windows-0078D6)
![UI](https://img.shields.io/badge/UI-Guna.UI2-6A0DAD)
![Protocol](https://img.shields.io/badge/Protocol-Odin-FF6F00)

**👑 صنع بواسطة أنس بن مالك يفوز** — *Crafted by Anas Malik*

</div>

---

## 🌍 نبذة — About

> **العربية:** التجربة الأقرب إلى الأداة الأصلية، بتصميم داكن عصري. حمّل حزم البرامج الثابتة
> (BL / AP / CP / CSC) بمختلف صيغها، اختر أو اقرأ ملف `PIT` من الجهاز مباشرة، ثم ابدأ الفلاش
> مع سجلّ أوامر حيٍّ وعداد تقدّم — كل ذلك بواجهة WinForms أنيقة من Guna.UI2.

> **English:** The closest experience to the stock tool, wrapped in a sleek dark theme.
> Load your firmware bundles (BL / AP / CP / CSC), pick or read a `PIT` file straight from
> the device, then flash LZ4-compressed partitions with a live color-coded console and a
> per-file progress bar — from a polished Guna.UI2 desktop UI.

> ⚠️ **تحذير / Warning:** الفلاش الخاطئ قد يدمر جهازك نهائياً (brick).
> **Flashing wrong firmware can permanently damage your device.** أنت المسؤول وحدك عن كل ما تفعله.
> See [Safety & Disclaimer](#-safety--disclaimer) before using.

---

## ✨ المميزات — Features

### 🇸🇦 بالعربية

| | | |
|---|---|---|
| 📦 | **تحميل حزم البرامج الثابتة** — BL (bootloader)، AP (PDA/Android)، CP (مودم)، CSC (حسب المنطقة)، بصيغ `.tar` / `.md5` / `.limra`. |
| 🗺️ | **دعم PIT** — اختر ملف `.pit` من القرص، أو دع التطبيق يعثر عليه داخل حزمة TAR ويتحقق منه تلقائياً. |
| 📖 | **قراءة PIT من الجهاز** — اسحب جدول الأقسام الحقيقي من هاتفك واحفظه على القرص. |
| ⚡ | **كشف أقسام LZ4** — يقرأ محتويات حزمة TAR، يكتشف كتل `.lz4` ويحسب أحجامها الحقيقية غير المضغوطة. |
| 🛠️ | **خيارات الفلاش** — إعادة التقسيم (Repartition)، تحديث BOOT، مسح EFS، إعادة تشغيل تلقائية (Auto Reboot). |
| 🖥️ | **كونسول حيّ** — سجلّ أوامر ملوّن لأي خطوة في البروتوكول، مع شريط تقدّم لكل ملف. |
| 🎨 | **واجهة داكنة عصرية** — نافذة بدون إطار، زوايا دائرية، وعناصر Guna.UI2. |
| 🛡️ | **حارس أمان EFS** — نافذة تحذير قبل أي عملية تمسّ أقسام EFS. |
| ✅ | **جدول أقسام قابل للتفعيل** — كل قسم يظهر مثبّتاً، يمكنك إلغاء تحديد ما لا تريد فلاشه بسهولة. |

### 🇬🇧 In English

- **Load firmware packages** — BL (bootloader), AP (PDA/Android), CP (modem/baseband), and CSC (country-specific) as `.tar`, `.md5`, or `.limra` bundles.
- **PIT support** — select a `.pit` file from disk, or let the app find and validate one hidden inside a TAR package.
- **Read PIT from device** — pull the live partition table off your phone and save it.
- **LZ4 partition detection** — parses TAR contents, detects `.lz4` blobs, and computes their real uncompressed sizes.
- **Flash options** — Repartition, Update BOOT, Clear EFS, Auto Reboot.
- **Live console** — color-coded log of every protocol step, with a per-file progress bar.
- **Dark modern UI** — frameless window, rounded corners, Guna.UI2 controls.
- **EFS safety guard** — a warning dialog before any operation that clears EFS.
- **Interactive partition grid** — every partition is pre-checked; uncheck what you don't want to flash.

---

## 📸 لقطات — Screenshots

*(أضف لقطات للنافذة الرئيسية هنا / Add screenshots of the main window here — ستنشر مع الـ Releases)*

---

## 🧩 المتطلبات — Requirements

- **Windows 7 / 8 / 8.1 / 10 / 11**
- **[.NET Framework 4.8](https://dotnet.microsoft.com/download/dotnet-framework/net48)** (أو أحدث)
- جهاز سامسونج في **وضع الداونلود** والكابل موصول:
  - الأجهزة القديمة: `خفض الصوت + الرئيسي + التشغيل`
  - الأجهزة الأحدث: `خفض الصوت + رفع الصوت + توصيل USB`
- حزمة برامج ثابتة مطابقة لموديل جهازك **بالضبط**

---

## 🛠️ البناء من المصدر — Building from source

1. افتح `OdinProtocol C# .Net By Anas Malik.slnx` في **Visual Studio 2022 (17.10+)**
2. تُستعاد حزم NuGet تلقائياً عند البناء
3. ابنِ الحل في وضع `Release`

> المشروع يدعم أيضاً استعادة `packages.config` التقليدية لتعمل مع الأدوات الأقدم.
> البيان (`app.manifest`) يطلب صلاحيات **المسؤول (Administrator)** — وهذا إلزامي للتخاطب
> مع تعريف الجهاز أثناء الفلاش.

---

## 🚀 الاستخدام — Usage

| الخطوة | الوصف |
|---|---|
| 1 | شغّل التطبيق (يجب تشغيله كمسؤول). |
| 2 | ضع جهازك في **وضع الداونلود** ووصّله. |
| 3 | حمّل حزم البرامج الثابتة: **BL** ← بوت لودر · **AP** ← نظام أندرويد · **CP** ← المودم · **CSC** ← حزمة المنطقة |
| 4 | تظهر أقسام الحزم في الجدول مثبّتة — ألغِ تحديد ما لا تريد فلاشه. |
| 5 | اختياري: **Select PIT** (ضروري لإعادة التقسيم) أو **Read PIT** لحفظ الجدول الحالي. |
| 6 | اختر خيارات الفلاش: **Auto Reboot**، **Repartition** (يتطلب PIT)، **Update BOOT**، **Clear EFS** ⚠️ |
| 7 | اضغط **Flash** وانتظر — يعرض الكونسول كل خطوة والنتيجة النهائية OK/Failed. |

---

## 🗂️ هيكل المشروع — Project structure

```
├── Controllers/
│   └── FlashController.cs        UI orchestration between view and services
├── Services/
│   ├── FirmwarePackageService.cs PIT selection + TAR package opening
│   ├── FirmwareRepository.cs     In-memory store of loaded partitions
│   ├── FlashSession.cs           Facade wiring flash + PIT managers
│   ├── FlashOptions.cs           Flash configuration DTO
│   └── PitSelectionResult.cs     PIT selection outcome
├── odin/
│   ├── FlashManager.cs           Core flashing workflow (SharpOdinClient wrapper)
│   ├── PitManager.cs             Read-PIT-from-device workflow
│   ├── TarPartitionReader.cs     TAR/LZ4 parsing + PIT extraction/validation
│   └── FlashFileItem.cs          Partition model
├── UI/
│   ├── FlashView.cs              View-model binding over the form controls
│   ├── LogConsole.cs             Thread-safe console logging
│   ├── PartitionGridView.cs      DataGridView binding + row coloring
│   ├── ProgressIndicator.cs      Progress bar updates
│   ├── FlashControlsState.cs     Button/control enable-state manager
│   ├── UiDispatcher.cs           Cross-thread UI marshaling
│   ├── UserPrompts.cs            Dialogs (PIT, EFS warnings)
│   └── WindowChromeHelper.cs     Frameless window dragging
├── Form1.cs / Form1.Designer.cs  Main window (Guna.UI2)
└── Program.cs                    Entry point
```

التصميم طبقي نظيف: **Form (View) → FlashController → Services → Odin layer**،
والمعالجة المنخفضة المستوى للبروتوكول مفوَّضة إلى مكتبة `SharpOdinClient`.

---

## 📦 تبعيات NuGet — Dependencies

| الحزمة | الغرض |
|---|---|
| [Guna.UI2.WinForms](https://www.nuget.org/packages/Guna.UI2.WinForms) 2.0.4.8 | عناصر واجهة حديثة |
| [SharpOdinClient](https://www.nuget.org/packages/SharpOdinClient) 1.0.2 | محرك بروتوكول Odin |
| K4os.Compression.LZ4 (+ Legacy, Streams) | فك ضغط LZ4 لكتل البرامج الثابتة |
| K4os.Hash.xxHash | التحقق من التجزئة أثناء قراءة TARs |

---

## ⚠️ توافق وملاحظات — Compatibility notes

- حزم البرامج الثابتة يجب أن تطابق موديل جهازك ومنطقتك **بالضبط** — الفلاش الخاطئ قد **يُتلف** الجهاز.
- بعض الموديلات (موجّهة لشركات اتصالات أمريكية أو أجهزة أحدث) قد تحتاج خطوات إضافية غير مشمولة هنا.
- هذا تنفيذ مستقل لبروتوكول Odin مبني على المشروع مفتوح المصدر `SharpOdinClient`؛ **غير تابع لشركة سامسونج ولا معتمد منها**.

---

## 🛡️ السلامة وإخلاء المسؤولية — Safety & Disclaimer

- **استخدم على مسؤوليتك.** برامج ثابتة خاطئة، أو فلاش متقطع، أو مسح EFS قد يتلف جهازك، يمسح IMEI، أو يبطل الضمان.
- احتفظ دائماً **بنسخة EFS احتياطية كاملة** قبل أي عملية تلامس EFS.
- **لا تفصل الجهاز عن الكابل أثناء الفلاش.**
- لا يتحمل المؤلف أي مسؤولية عن أي ضرر ناتج عن استخدام هذه الأداة.

---

## 📜 الرخصة — License

هذا المشروع مرخّص بموجب **رخصة MIT** — انظر ملف [LICENSE](LICENSE).
لاحظ أن مكونات الطرف الثالث (Guna.UI2، SharpOdinClient، مكتبات K4os) تخضع لتراخيصها الخاصة.

---

## 🙌 تواصل معي — Connect with me

| المنصة | الرابط |
|---|---|
| <img src="https://img.shields.io/badge/Telegram-2CA5E0?logo=telegram&logoColor=white" alt="Telegram"> | [t.me/v6f_z](https://t.me/v6f_z) |
| <img src="https://img.shields.io/badge/Instagram-E4405F?logo=instagram&logoColor=white" alt="Instagram"> | [instagram.com/v6f_z](https://instagram.com/v6f_z) |
| <img src="https://img.shields.io/badge/Facebook-1877F2?logo=facebook&logoColor=white" alt="Facebook"> | [facebook.com/anasmalikdev](https://facebook.com/anasmalikdev) |
| <img src="https://img.shields.io/badge/GitHub-181717?logo=github&logoColor=white" alt="GitHub"> | [github.com/v6f-z](https://github.com/v6f-z) |
| <img src="https://img.shields.io/badge/Email-D14836?logo=gmail&logoColor=white" alt="Email"> | [anasmalikopop@gmail.com](mailto:anasmalikopop@gmail.com) |

**AMProTeam** — أنس بن مالك يفوز | *Anas Malik*

---

<div align="center">

**وصلنا بنهاية الأداة إلى الريليز القادم 🚀** — *Stay tuned for the Releases!*

</div>