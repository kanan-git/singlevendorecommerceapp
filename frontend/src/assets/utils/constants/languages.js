const languages = {
    az: {
        language: "azerbaijani",
        languageOriginal: "azərbaycanca",
        countryName: "azerbaijan",
        countryNameOriginal: "azərbaycan",
        countryIsoCode: "az"
    },
    tr: {
        language: "turkish",
        languageOriginal: "türkçe",
        countryName: "turkey",
        countryNameOriginal: "türkiye",
        countryIsoCode: "tr"
    },
    gb: {
        language: "english",
        languageOriginal: "english",
        countryName: "united kingdom",
        countryNameOriginal: "united kingdom",
        countryIsoCode: "gb"
    },
    us: {
        language: "english",
        languageOriginal: "english",
        countryName: "united states",
        countryNameOriginal: "united states",
        countryIsoCode: "us"
    },
    es: {
        language: "spanish",
        languageOriginal: "español",
        countryName: "spain",
        countryNameOriginal: "españa",
        countryIsoCode: "es"
    },
    it: {
        language: "italian",
        languageOriginal: "italiano",
        countryName: "italy",
        countryNameOriginal: "italia",
        countryIsoCode: "it"
    },
    fr: {
        language: "french",
        languageOriginal: "français",
        countryName: "france",
        countryNameOriginal: "france",
        countryIsoCode: "fr"
    },
    ge: {
        language: "georgian",
        languageOriginal: "ქართული",
        countryName: "georgia",
        countryNameOriginal: "საქართველო",
        countryIsoCode: "ge"
    },
    de: {
        language: "german",
        languageOriginal: "deutsch",
        countryName: "germany",
        countryNameOriginal: "deutschland",
        countryIsoCode: "de"
    },
    ru: {
        language: "russian",
        languageOriginal: "русский",
        countryName: "russia",
        countryNameOriginal: "россия",
        countryIsoCode: "ru"
    },
    ua: {
        language: "ukrainian",
        languageOriginal: "українська",
        countryName: "ukraine",
        countryNameOriginal: "україна",
        countryIsoCode: "ua"
    },
    pl: {
        language: "polish",
        languageOriginal: "polski",
        countryName: "poland",
        countryNameOriginal: "polska",
        countryIsoCode: "pl"
    },
    nl: {
        language: "dutch",
        languageOriginal: "nederlands",
        countryName: "netherlands",
        countryNameOriginal: "nederland",
        countryIsoCode: "nl"
    },
    be: {
        language: "dutch",
        languageOriginal: "nederlands",
        countryName: "belgium",
        countryNameOriginal: "belgië",
        countryIsoCode: "be"
    },
    pt: {
        language: "portuguese",
        languageOriginal: "português",
        countryName: "portugal",
        countryNameOriginal: "portugal",
        countryIsoCode: "pt"
    },
    gr: {
        language: "greek",
        languageOriginal: "ελληνικά",
        countryName: "greece",
        countryNameOriginal: "ελλάδα",
        countryIsoCode: "gr"
    },
    ro: {
        language: "romanian",
        languageOriginal: "română",
        countryName: "romania",
        countryNameOriginal: "românia",
        countryIsoCode: "ro"
    },
    bg: {
        language: "bulgarian",
        languageOriginal: "български",
        countryName: "bulgaria",
        countryNameOriginal: "българия",
        countryIsoCode: "bg"
    },
    rs: {
        language: "serbian",
        languageOriginal: "српски",
        countryName: "serbia",
        countryNameOriginal: "србија",
        countryIsoCode: "rs"
    },
    hr: {
        language: "croatian",
        languageOriginal: "hrvatski",
        countryName: "croatia",
        countryNameOriginal: "hrvatska",
        countryIsoCode: "hr"
    },
    hu: {
        language: "hungarian",
        languageOriginal: "magyar",
        countryName: "hungary",
        countryNameOriginal: "magyarország",
        countryIsoCode: "hu"
    },
    cz: {
        language: "czech",
        languageOriginal: "čeština",
        countryName: "czech republic",
        countryNameOriginal: "česko",
        countryIsoCode: "cz"
    },
    sk: {
        language: "slovak",
        languageOriginal: "slovenčina",
        countryName: "slovakia",
        countryNameOriginal: "slovensko",
        countryIsoCode: "sk"
    },
    si: {
        language: "slovene",
        languageOriginal: "slovenščina",
        countryName: "slovenia",
        countryNameOriginal: "slovenija",
        countryIsoCode: "si"
    },
    at: {
        language: "german",
        languageOriginal: "deutsch",
        countryName: "austria",
        countryNameOriginal: "österreich",
        countryIsoCode: "at"
    },
    ch: {
        language: "german",
        languageOriginal: "deutsch",
        countryName: "switzerland",
        countryNameOriginal: "schweiz",
        countryIsoCode: "ch"
    },
    dk: {
        language: "danish",
        languageOriginal: "dansk",
        countryName: "denmark",
        countryNameOriginal: "danmark",
        countryIsoCode: "dk"
    },
    se: {
        language: "swedish",
        languageOriginal: "svenska",
        countryName: "sweden",
        countryNameOriginal: "sverige",
        countryIsoCode: "se"
    },
    no: {
        language: "norwegian",
        languageOriginal: "norsk",
        countryName: "norway",
        countryNameOriginal: "norge",
        countryIsoCode: "no"
    },
    fi: {
        language: "finnish",
        languageOriginal: "suomi",
        countryName: "finland",
        countryNameOriginal: "suomi",
        countryIsoCode: "fi"
    },
    ie: {
        language: "irish",
        languageOriginal: "gaeilge",
        countryName: "ireland",
        countryNameOriginal: "éire",
        countryIsoCode: "ie"
    },
    ca: {
        language: "english",
        languageOriginal: "english",
        countryName: "canada",
        countryNameOriginal: "canada",
        countryIsoCode: "ca"
    },
    mx: {
        language: "spanish",
        languageOriginal: "español",
        countryName: "mexico",
        countryNameOriginal: "méxico",
        countryIsoCode: "mx"
    },
    br: {
        language: "portuguese",
        languageOriginal: "português",
        countryName: "brazil",
        countryNameOriginal: "brasil",
        countryIsoCode: "br"
    },
    ar: {
        language: "spanish",
        languageOriginal: "español",
        countryName: "argentina",
        countryNameOriginal: "argentina",
        countryIsoCode: "ar"
    },
    cl: {
        language: "spanish",
        languageOriginal: "español",
        countryName: "chile",
        countryNameOriginal: "chile",
        countryIsoCode: "cl"
    },
    co: {
        language: "spanish",
        languageOriginal: "español",
        countryName: "colombia",
        countryNameOriginal: "colombia",
        countryIsoCode: "co"
    },
    pe: {
        language: "spanish",
        languageOriginal: "español",
        countryName: "peru",
        countryNameOriginal: "perú",
        countryIsoCode: "pe"
    },
    cn: {
        language: "chinese",
        languageOriginal: "中文",
        countryName: "china",
        countryNameOriginal: "中国",
        countryIsoCode: "cn"
    },
    jp: {
        language: "japanese",
        languageOriginal: "日本語",
        countryName: "japan",
        countryNameOriginal: "日本",
        countryIsoCode: "jp"
    },
    kr: {
        language: "korean",
        languageOriginal: "한국어",
        countryName: "south korea",
        countryNameOriginal: "대한민국",
        countryIsoCode: "kr"
    },
    in: {
        language: "hindi",
        languageOriginal: "हिन्दी",
        countryName: "india",
        countryNameOriginal: "भारत",
        countryIsoCode: "in"
    },
    pk: {
        language: "urdu",
        languageOriginal: "اردو",
        countryName: "pakistan",
        countryNameOriginal: "پاکستان",
        countryIsoCode: "pk"
    },
    bd: {
        language: "bengali",
        languageOriginal: "বাংলা",
        countryName: "bangladesh",
        countryNameOriginal: "বাংলাদেশ",
        countryIsoCode: "bd"
    },
    id: {
        language: "indonesian",
        languageOriginal: "bahasa indonesia",
        countryName: "indonesia",
        countryNameOriginal: "indonesia",
        countryIsoCode: "id"
    },
    my: {
        language: "malay",
        languageOriginal: "bahasa melayu",
        countryName: "malaysia",
        countryNameOriginal: "malaysia",
        countryIsoCode: "my"
    },
    th: {
        language: "thai",
        languageOriginal: "ไทย",
        countryName: "thailand",
        countryNameOriginal: "ประเทศไทย",
        countryIsoCode: "th"
    },
    vn: {
        language: "vietnamese",
        languageOriginal: "tiếng việt",
        countryName: "vietnam",
        countryNameOriginal: "việt nam",
        countryIsoCode: "vn"
    },
    sa: {
        language: "arabic",
        languageOriginal: "العربية",
        countryName: "saudi arabia",
        countryNameOriginal: "المملكة العربية السعودية",
        countryIsoCode: "sa"
    },
    ae: {
        language: "arabic",
        languageOriginal: "العربية",
        countryName: "united arab emirates",
        countryNameOriginal: "الإمارات العربية المتحدة",
        countryIsoCode: "ae"
    },
    eg: {
        language: "arabic",
        languageOriginal: "العربية",
        countryName: "egypt",
        countryNameOriginal: "مصر",
        countryIsoCode: "eg"
    },
    za: {
        language: "english",
        languageOriginal: "english",
        countryName: "south africa",
        countryNameOriginal: "south africa",
        countryIsoCode: "za"
    },
    lu: {
        language: "luxembourgish",
        languageOriginal: "lëtzebuergesch",
        countryName: "luxembourg",
        countryNameOriginal: "lëtzebuerg",
        countryIsoCode: "lu"
    },
    is: {
        language: "icelandic",
        languageOriginal: "íslenska",
        countryName: "iceland",
        countryNameOriginal: "ísland",
        countryIsoCode: "is"
    },
    ee: {
        language: "estonian",
        languageOriginal: "eesti",
        countryName: "estonia",
        countryNameOriginal: "eesti",
        countryIsoCode: "ee"
    },
    lv: {
        language: "latvian",
        languageOriginal: "latviešu",
        countryName: "latvia",
        countryNameOriginal: "latvija",
        countryIsoCode: "lv"
    },
    lt: {
        language: "lithuanian",
        languageOriginal: "lietuvių",
        countryName: "lithuania",
        countryNameOriginal: "lietuva",
        countryIsoCode: "lt"
    },
    by: {
        language: "belarusian",
        languageOriginal: "беларуская",
        countryName: "belarus",
        countryNameOriginal: "беларусь",
        countryIsoCode: "by"
    },
    md: {
        language: "romanian",
        languageOriginal: "română",
        countryName: "moldova",
        countryNameOriginal: "moldova",
        countryIsoCode: "md"
    },
    al: {
        language: "albanian",
        languageOriginal: "shqip",
        countryName: "albania",
        countryNameOriginal: "shqipëria",
        countryIsoCode: "al"
    },
    me: {
        language: "montenegrin",
        languageOriginal: "crnogorski",
        countryName: "montenegro",
        countryNameOriginal: "crna gora",
        countryIsoCode: "me"
    },
    mk: {
        language: "macedonian",
        languageOriginal: "македонски",
        countryName: "north macedonia",
        countryNameOriginal: "северна македонија",
        countryIsoCode: "mk"
    },
    ba: {
        language: "bosnian",
        languageOriginal: "bosanski",
        countryName: "bosnia and herzegovina",
        countryNameOriginal: "bosna i hercegovina",
        countryIsoCode: "ba"
    },
    mt: {
        language: "maltese",
        languageOriginal: "malti",
        countryName: "malta",
        countryNameOriginal: "malta",
        countryIsoCode: "mt"
    },
    cy: {
        language: "greek",
        languageOriginal: "ελληνικά",
        countryName: "cyprus",
        countryNameOriginal: "κύπρος",
        countryIsoCode: "cy"
    },
    am: {
        language: "armenian",
        languageOriginal: "հայերեն",
        countryName: "armenia",
        countryNameOriginal: "հայաստան",
        countryIsoCode: "am"
    },
    ir: {
        language: "persian",
        languageOriginal: "فارسی",
        countryName: "iran",
        countryNameOriginal: "ایران",
        countryIsoCode: "ir"
    },
    af: {
        language: "pashto",
        languageOriginal: "پښتو",
        countryName: "afghanistan",
        countryNameOriginal: "افغانستان",
        countryIsoCode: "af"
    },
    sy: {
        language: "arabic",
        languageOriginal: "العربية",
        countryName: "syria",
        countryNameOriginal: "سوريا",
        countryIsoCode: "sy"
    },
    lb: {
        language: "arabic",
        languageOriginal: "العربية",
        countryName: "lebanon",
        countryNameOriginal: "لبنان",
        countryIsoCode: "lb"
    },
    ye: {
        language: "arabic",
        languageOriginal: "العربية",
        countryName: "yemen",
        countryNameOriginal: "اليمن",
        countryIsoCode: "ye"
    },
    sd: {
        language: "arabic",
        languageOriginal: "العربية",
        countryName: "sudan",
        countryNameOriginal: "السودان",
        countryIsoCode: "sd"
    },
    tz: {
        language: "swahili",
        languageOriginal: "kiswahili",
        countryName: "tanzania",
        countryNameOriginal: "tanzania",
        countryIsoCode: "tz"
    },
    ug: {
        language: "swahili",
        languageOriginal: "kiswahili",
        countryName: "uganda",
        countryNameOriginal: "uganda",
        countryIsoCode: "ug"
    },
    zw: {
        language: "english",
        languageOriginal: "english",
        countryName: "zimbabwe",
        countryNameOriginal: "zimbabwe",
        countryIsoCode: "zw"
    },
    zm: {
        language: "english",
        languageOriginal: "english",
        countryName: "zambia",
        countryNameOriginal: "zambia",
        countryIsoCode: "zm"
    },
    mu: {
        language: "french",
        languageOriginal: "français",
        countryName: "mauritius",
        countryNameOriginal: "maurice",
        countryIsoCode: "mu"
    },
    cu: {
        language: "spanish",
        languageOriginal: "español",
        countryName: "cuba",
        countryNameOriginal: "cuba",
        countryIsoCode: "cu"
    },
    ec: {
        language: "spanish",
        languageOriginal: "español",
        countryName: "ecuador",
        countryNameOriginal: "ecuador",
        countryIsoCode: "ec"
    },
    py: {
        language: "spanish",
        languageOriginal: "español",
        countryName: "paraguay",
        countryNameOriginal: "paraguay",
        countryIsoCode: "py"
    },
    cr: {
        language: "spanish",
        languageOriginal: "español",
        countryName: "costa rica",
        countryNameOriginal: "costa rica",
        countryIsoCode: "cr"
    },
    pa: {
        language: "spanish",
        languageOriginal: "español",
        countryName: "panama",
        countryNameOriginal: "panamá",
        countryIsoCode: "pa"
    }
};

export default languages;

// write post fetch inside loop, send all these data to backend to create data on db
// create txt file for this file and all static information like this as backup for possible database drop issue
// remove this file and all fix all frontend lines uses this
