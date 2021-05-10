using System.ComponentModel;

namespace Laerdal.Dfu.Sample.Helpers
{
    /// <summary>
    ///     https://www.bluetooth.com/specifications/assigned-numbers/company-identifiers/
    /// </summary>
    public enum ManufacturerIdConstants : short
    {
        
        [Description("None")]
        None = -1, // None
        
        [Description("Ericsson Technology Licensing")]
        Ericsson_Technology_Licensing = 0, // Ericsson Technology Licensing
        
        [Description("Nokia Mobile Phones")]
        Nokia_Mobile_Phones = 1, // Nokia Mobile Phones
        
        [Description("Intel Corp.")]
        Intel_Corp = 2, // Intel Corp.
        
        [Description("IBM Corp.")]
        IBM_Corp = 3, // IBM Corp.
        
        [Description("Toshiba Corp.")]
        Toshiba_Corp = 4, // Toshiba Corp.
        
        [Description("3Com")]
        ThreeCom = 5, // 3Com
        
        [Description("Microsoft")]
        Microsoft = 6, // Microsoft
        
        [Description("Lucent")]
        Lucent = 7, // Lucent
        
        [Description("Motorola")]
        Motorola = 8, // Motorola
        
        [Description("Infineon Technologies AG")]
        Infineon_Technologies_AG = 9, // Infineon Technologies AG
        
        [Description("Cambridge Silicon Radio")]
        Cambridge_Silicon_Radio = 10, // Cambridge Silicon Radio
        
        [Description("Silicon Wave")]
        Silicon_Wave = 11, // Silicon Wave
        
        [Description("Digianswer A/S")]
        Digianswer_A_S = 12, // Digianswer A/S
        
        [Description("Texas Instruments Inc.")]
        Texas_Instruments_Inc = 13, // Texas Instruments Inc.
        
        [Description("Ceva, Inc. (formerly Parthus Technologies, Inc.)")]
        Ceva_Inc_formerly_Parthus_Technologies_Inc = 14, // Ceva, Inc. (formerly Parthus Technologies, Inc.)
        
        [Description("Broadcom Corporation")]
        Broadcom_Corporation = 15, // Broadcom Corporation
        
        [Description("Mitel Semiconductor")]
        Mitel_Semiconductor = 16, // Mitel Semiconductor
        
        [Description("Widcomm, Inc")]
        Widcomm_Inc = 17, // Widcomm, Inc
        
        [Description("Zeevo, Inc.")]
        Zeevo_Inc = 18, // Zeevo, Inc.
        
        [Description("Atmel Corporation")]
        Atmel_Corporation = 19, // Atmel Corporation
        
        [Description("Mitsubishi Electric Corporation")]
        Mitsubishi_Electric_Corporation = 20, // Mitsubishi Electric Corporation
        
        [Description("RTX Telecom A/S")]
        RTX_Telecom_A_S = 21, // RTX Telecom A/S
        
        [Description("KC Technology Inc.")]
        KC_Technology_Inc = 22, // KC Technology Inc.
        
        [Description("NewLogic")]
        NewLogic = 23, // NewLogic
        
        [Description("Transilica, Inc.")]
        Transilica_Inc = 24, // Transilica, Inc.
        
        [Description("Rohde & Schwarz GmbH & Co. KG")]
        Rohde_And_Schwarz_GmbH_And_Co_KG = 25, // Rohde & Schwarz GmbH & Co. KG
        
        [Description("TTPCom Limited")]
        TTPCom_Limited = 26, // TTPCom Limited
        
        [Description("Signia Technologies, Inc.")]
        Signia_Technologies_Inc = 27, // Signia Technologies, Inc.
        
        [Description("Conexant Systems Inc.")]
        Conexant_Systems_Inc = 28, // Conexant Systems Inc.
        
        [Description("Qualcomm")]
        Qualcomm = 29, // Qualcomm
        
        [Description("Inventel")]
        Inventel = 30, // Inventel
        
        [Description("AVM Berlin")]
        AVM_Berlin = 31, // AVM Berlin
        
        [Description("BandSpeed, Inc.")]
        BandSpeed_Inc = 32, // BandSpeed, Inc.
        
        [Description("Mansella Ltd")]
        Mansella_Ltd = 33, // Mansella Ltd
        
        [Description("NEC Corporation")]
        NEC_Corporation = 34, // NEC Corporation
        
        [Description("WavePlus Technology Co., Ltd.")]
        WavePlus_Technology_Co_Ltd = 35, // WavePlus Technology Co., Ltd.
        
        [Description("Alcatel")]
        Alcatel = 36, // Alcatel
        
        [Description("NXP Semiconductors (formerly Philips Semiconductors)")]
        NXP_Semiconductors_formerly_Philips_Semiconductors = 37, // NXP Semiconductors (formerly Philips Semiconductors)
        
        [Description("C Technologies")]
        C_Technologies = 38, // C Technologies
        
        [Description("Open Interface")]
        Open_Interface = 39, // Open Interface
        
        [Description("R F Micro Devices")]
        R_F_Micro_Devices = 40, // R F Micro Devices
        
        [Description("Hitachi Ltd")]
        Hitachi_Ltd = 41, // Hitachi Ltd
        
        [Description("Symbol Technologies, Inc.")]
        Symbol_Technologies_Inc = 42, // Symbol Technologies, Inc.
        
        [Description("Tenovis")]
        Tenovis = 43, // Tenovis
        
        [Description("Macronix International Co. Ltd.")]
        Macronix_International_Co_Ltd = 44, // Macronix International Co. Ltd.
        
        [Description("GCT Semiconductor")]
        GCT_Semiconductor = 45, // GCT Semiconductor
        
        [Description("Norwood Systems")]
        Norwood_Systems = 46, // Norwood Systems
        
        [Description("MewTel Technology Inc.")]
        MewTel_Technology_Inc = 47, // MewTel Technology Inc.
        
        [Description("ST Microelectronics")]
        ST_Microelectronics = 48, // ST Microelectronics
        
        [Description("Synopsys, Inc.")]
        Synopsys_Inc = 49, // Synopsys, Inc.
        
        [Description("Red-M (Communications) Ltd")]
        Red_M_Communications_Ltd = 50, // Red-M (Communications) Ltd
        
        [Description("Commil Ltd")]
        Commil_Ltd = 51, // Commil Ltd
        
        [Description("Computer Access Technology Corporation (CATC)")]
        Computer_Access_Technology_Corporation_CATC = 52, // Computer Access Technology Corporation (CATC)
        
        [Description("Eclipse (HQ Espana) S.L.")]
        Eclipse_HQ_Espana_S_L = 53, // Eclipse (HQ Espana) S.L.
        
        [Description("Renesas Electronics Corporation")]
        Renesas_Electronics_Corporation = 54, // Renesas Electronics Corporation
        
        [Description("Mobilian Corporation")]
        Mobilian_Corporation = 55, // Mobilian Corporation
        
        [Description("Terax")]
        Terax = 56, // Terax
        
        [Description("Integrated System Solution Corp.")]
        Integrated_System_Solution_Corp = 57, // Integrated System Solution Corp.
        
        [Description("Matsushita Electric Industrial Co., Ltd.")]
        Matsushita_Electric_Industrial_Co_Ltd = 58, // Matsushita Electric Industrial Co., Ltd.
        
        [Description("Gennum Corporation")]
        Gennum_Corporation = 59, // Gennum Corporation
        
        [Description("BlackBerry Limited (formerly Research In Motion)")]
        BlackBerry_Limited_formerly_Research_In_Motion = 60, // BlackBerry Limited (formerly Research In Motion)
        
        [Description("IPextreme, Inc.")]
        IPextreme_Inc = 61, // IPextreme, Inc.
        
        [Description("Systems and Chips, Inc.")]
        Systems_and_Chips_Inc = 62, // Systems and Chips, Inc.
        
        [Description("Bluetooth SIG, Inc.")]
        Bluetooth_SIG_Inc = 63, // Bluetooth SIG, Inc.
        
        [Description("Seiko Epson Corporation")]
        Seiko_Epson_Corporation = 64, // Seiko Epson Corporation
        
        [Description("Integrated Silicon Solution Taiwan, Inc.")]
        Integrated_Silicon_Solution_Taiwan_Inc = 65, // Integrated Silicon Solution Taiwan, Inc.
        
        [Description("CONWISE Technology Corporation Ltd")]
        CONWISE_Technology_Corporation_Ltd = 66, // CONWISE Technology Corporation Ltd
        
        [Description("PARROT SA")]
        PARROT_SA = 67, // PARROT SA
        
        [Description("Socket Mobile")]
        Socket_Mobile = 68, // Socket Mobile
        
        [Description("Atheros Communications, Inc.")]
        Atheros_Communications_Inc = 69, // Atheros Communications, Inc.
        
        [Description("MediaTek, Inc.")]
        MediaTek_Inc = 70, // MediaTek, Inc.
        
        [Description("Bluegiga")]
        Bluegiga = 71, // Bluegiga
        
        [Description("Marvell Technology Group Ltd.")]
        Marvell_Technology_Group_Ltd = 72, // Marvell Technology Group Ltd.
        
        [Description("3DSP Corporation")]
        Three_DSP_Corporation = 73, // 3DSP Corporation
        
        [Description("Accel Semiconductor Ltd.")]
        Accel_Semiconductor_Ltd = 74, // Accel Semiconductor Ltd.
        
        [Description("Continental Automotive Systems")]
        Continental_Automotive_Systems = 75, // Continental Automotive Systems
        
        [Description("Apple, Inc.")]
        Apple_Inc = 76, // Apple, Inc.
        
        [Description("Staccato Communications, Inc.")]
        Staccato_Communications_Inc = 77, // Staccato Communications, Inc.
        
        [Description("Avago Technologies")]
        Avago_Technologies = 78, // Avago Technologies
        
        [Description("APT Licensing Ltd.")]
        APT_Licensing_Ltd = 79, // APT Licensing Ltd.
        
        [Description("SiRF Technology")]
        SiRF_Technology = 80, // SiRF Technology
        
        [Description("Tzero Technologies, Inc.")]
        Tzero_Technologies_Inc = 81, // Tzero Technologies, Inc.
        
        [Description("J&M Corporation")]
        JAndM_Corporation = 82, // J&M Corporation
        
        [Description("Free2move AB")]
        Free2move_AB = 83, // Free2move AB
        
        [Description("3DiJoy Corporation")]
        ThreeDiJoy_Corporation = 84, // 3DiJoy Corporation
        
        [Description("Plantronics, Inc.")]
        Plantronics_Inc = 85, // Plantronics, Inc.
        
        [Description("Sony Ericsson Mobile Communications")]
        Sony_Ericsson_Mobile_Communications = 86, // Sony Ericsson Mobile Communications
        
        [Description("Harman International Industries, Inc.")]
        Harman_International_Industries_Inc = 87, // Harman International Industries, Inc.
        
        [Description("Vizio, Inc.")]
        Vizio_Inc = 88, // Vizio, Inc.
        
        [Description("Nordic Semiconductor ASA")]
        Nordic_Semiconductor_ASA = 89, // Nordic Semiconductor ASA
        
        [Description("EM Microelectronic-Marin SA")]
        EM_Microelectronic_Marin_SA = 90, // EM Microelectronic-Marin SA
        
        [Description("Ralink Technology Corporation")]
        Ralink_Technology_Corporation = 91, // Ralink Technology Corporation
        
        [Description("Belkin International, Inc.")]
        Belkin_International_Inc = 92, // Belkin International, Inc.
        
        [Description("Realtek Semiconductor Corporation")]
        Realtek_Semiconductor_Corporation = 93, // Realtek Semiconductor Corporation
        
        [Description("Stonestreet One, LLC")]
        Stonestreet_One_LLC = 94, // Stonestreet One, LLC
        
        [Description("Wicentric, Inc.")]
        Wicentric_Inc = 95, // Wicentric, Inc.
        
        [Description("RivieraWaves S.A.S")]
        RivieraWaves_S_A_S = 96, // RivieraWaves S.A.S
        
        [Description("RDA Microelectronics")]
        RDA_Microelectronics = 97, // RDA Microelectronics
        
        [Description("Gibson Guitars")]
        Gibson_Guitars = 98, // Gibson Guitars
        
        [Description("MiCommand Inc.")]
        MiCommand_Inc = 99, // MiCommand Inc.
        
        [Description("Band XI International, LLC")]
        Band_XI_International_LLC = 100, // Band XI International, LLC
        
        [Description("Hewlett-Packard Company")]
        Hewlett_Packard_Company = 101, // Hewlett-Packard Company
        
        [Description("9Solutions Oy")]
        NineSolutions_Oy = 102, // 9Solutions Oy
        
        [Description("GN Netcom A/S")]
        GN_Netcom_A_S = 103, // GN Netcom A/S
        
        [Description("General Motors")]
        General_Motors = 104, // General Motors
        
        [Description("A&D Engineering, Inc.")]
        AAndD_Engineering_Inc = 105, // A&D Engineering, Inc.
        
        [Description("MindTree Ltd.")]
        MindTree_Ltd = 106, // MindTree Ltd.
        
        [Description("Polar Electro OY")]
        Polar_Electro_OY = 107, // Polar Electro OY
        
        [Description("Beautiful Enterprise Co., Ltd.")]
        Beautiful_Enterprise_Co_Ltd = 108, // Beautiful Enterprise Co., Ltd.
        
        [Description("BriarTek, Inc.")]
        BriarTek_Inc = 109, // BriarTek, Inc.
        
        [Description("Summit Data Communications, Inc.")]
        Summit_Data_Communications_Inc = 110, // Summit Data Communications, Inc.
        
        [Description("Sound ID")]
        Sound_ID = 111, // Sound ID
        
        [Description("Monster, LLC")]
        Monster_LLC = 112, // Monster, LLC
        
        [Description("connectBlue AB")]
        connectBlue_AB = 113, // connectBlue AB
        
        [Description("ShangHai Super Smart Electronics Co. Ltd.")]
        ShangHai_Super_Smart_Electronics_Co_Ltd = 114, // ShangHai Super Smart Electronics Co. Ltd.
        
        [Description("Group Sense Ltd.")]
        Group_Sense_Ltd = 115, // Group Sense Ltd.
        
        [Description("Zomm, LLC")]
        Zomm_LLC = 116, // Zomm, LLC
        
        [Description("Samsung Electronics Co. Ltd.")]
        Samsung_Electronics_Co_Ltd = 117, // Samsung Electronics Co. Ltd.
        
        [Description("Creative Technology Ltd.")]
        Creative_Technology_Ltd = 118, // Creative Technology Ltd.
        
        [Description("Laird Technologies")]
        Laird_Technologies = 119, // Laird Technologies
        
        [Description("Nike, Inc.")]
        Nike_Inc = 120, // Nike, Inc.
        
        [Description("lesswire AG")]
        lesswire_AG = 121, // lesswire AG
        
        [Description("MStar Semiconductor, Inc.")]
        MStar_Semiconductor_Inc = 122, // MStar Semiconductor, Inc.
        
        [Description("Hanlynn Technologies")]
        Hanlynn_Technologies = 123, // Hanlynn Technologies
        
        [Description("A & R Cambridge")]
        A_And_R_Cambridge = 124, // A & R Cambridge
        
        [Description("Seers Technology Co. Ltd")]
        Seers_Technology_Co_Ltd = 125, // Seers Technology Co. Ltd
        
        [Description("Sports Tracking Technologies Ltd.")]
        Sports_Tracking_Technologies_Ltd = 126, // Sports Tracking Technologies Ltd.
        
        [Description("Autonet Mobile")]
        Autonet_Mobile = 127, // Autonet Mobile
        
        [Description("DeLorme Publishing Company, Inc.")]
        DeLorme_Publishing_Company_Inc = 128, // DeLorme Publishing Company, Inc.
        
        [Description("WuXi Vimicro")]
        WuXi_Vimicro = 129, // WuXi Vimicro
        
        [Description("Sennheiser Communications A/S")]
        Sennheiser_Communications_A_S = 130, // Sennheiser Communications A/S
        
        [Description("TimeKeeping Systems, Inc.")]
        TimeKeeping_Systems_Inc = 131, // TimeKeeping Systems, Inc.
        
        [Description("Ludus Helsinki Ltd.")]
        Ludus_Helsinki_Ltd = 132, // Ludus Helsinki Ltd.
        
        [Description("BlueRadios, Inc.")]
        BlueRadios_Inc = 133, // BlueRadios, Inc.
        
        [Description("equinox AG")]
        equinox_AG = 134, // equinox AG
        
        [Description("Garmin International, Inc.")]
        Garmin_International_Inc = 135, // Garmin International, Inc.
        
        [Description("Ecotest")]
        Ecotest = 136, // Ecotest
        
        [Description("GN ReSound A/S")]
        GN_ReSound_A_S = 137, // GN ReSound A/S
        
        [Description("Jawbone")]
        Jawbone = 138, // Jawbone
        
        [Description("Topcon Positioning Systems, LLC")]
        Topcon_Positioning_Systems_LLC = 139, // Topcon Positioning Systems, LLC
        
        [Description("Gimbal Inc. (formerly Qualcomm Labs, Inc. and Qualcomm Retail Solutions, Inc.)")]
        Gimbal_Inc_formerly_Qualcomm_Labs_Inc_and_Qualcomm_Retail_Solutions_Inc = 140, // Gimbal Inc. (formerly Qualcomm Labs, Inc. and Qualcomm Retail Solutions, Inc.)
        
        [Description("Zscan Software")]
        Zscan_Software = 141, // Zscan Software
        
        [Description("Quintic Corp.")]
        Quintic_Corp = 142, // Quintic Corp.
        
        [Description("Telit Wireless Solutions GmbH (Formerly Stollman E+V GmbH)")]
        Telit_Wireless_Solutions_GmbH_Formerly_Stollman_E_V_GmbH = 143, // Telit Wireless Solutions GmbH (Formerly Stollman E+V GmbH)
        
        [Description("Funai Electric Co., Ltd.")]
        Funai_Electric_Co_Ltd = 144, // Funai Electric Co., Ltd.
        
        [Description("Advanced PANMOBIL Systems GmbH & Co. KG")]
        Advanced_PANMOBIL_Systems_GmbH_And_Co_KG = 145, // Advanced PANMOBIL Systems GmbH & Co. KG
        
        [Description("ThinkOptics, Inc.")]
        ThinkOptics_Inc = 146, // ThinkOptics, Inc.
        
        [Description("Universal Electronics, Inc.")]
        Universal_Electronics_Inc = 147, // Universal Electronics, Inc.
        
        [Description("Airoha Technology Corp.")]
        Airoha_Technology_Corp = 148, // Airoha Technology Corp.
        
        [Description("NEC Lighting, Ltd.")]
        NEC_Lighting_Ltd = 149, // NEC Lighting, Ltd.
        
        [Description("ODM Technology, Inc.")]
        ODM_Technology_Inc = 150, // ODM Technology, Inc.
        
        [Description("ConnecteDevice Ltd.")]
        ConnecteDevice_Ltd = 151, // ConnecteDevice Ltd.
        
        [Description("zer01.tv GmbH")]
        zer01_tv_GmbH = 152, // zer01.tv GmbH
        
        [Description("i.Tech Dynamic Global Distribution Ltd.")]
        i_Tech_Dynamic_Global_Distribution_Ltd = 153, // i.Tech Dynamic Global Distribution Ltd.
        
        [Description("Alpwise")]
        Alpwise = 154, // Alpwise
        
        [Description("Jiangsu Toppower Automotive Electronics Co., Ltd.")]
        Jiangsu_Toppower_Automotive_Electronics_Co_Ltd = 155, // Jiangsu Toppower Automotive Electronics Co., Ltd.
        
        [Description("Colorfy, Inc.")]
        Colorfy_Inc = 156, // Colorfy, Inc.
        
        [Description("Geoforce Inc.")]
        Geoforce_Inc = 157, // Geoforce Inc.
        
        [Description("Bose Corporation")]
        Bose_Corporation = 158, // Bose Corporation
        
        [Description("Suunto Oy")]
        Suunto_Oy = 159, // Suunto Oy
        
        [Description("Kensington Computer Products Group")]
        Kensington_Computer_Products_Group = 160, // Kensington Computer Products Group
        
        [Description("SR-Medizinelektronik")]
        SR_Medizinelektronik = 161, // SR-Medizinelektronik
        
        [Description("Vertu Corporation Limited")]
        Vertu_Corporation_Limited = 162, // Vertu Corporation Limited
        
        [Description("Meta Watch Ltd.")]
        Meta_Watch_Ltd = 163, // Meta Watch Ltd.
        
        [Description("LINAK A/S")]
        LINAK_A_S = 164, // LINAK A/S
        
        [Description("OTL Dynamics LLC")]
        OTL_Dynamics_LLC = 165, // OTL Dynamics LLC
        
        [Description("Panda Ocean Inc.")]
        Panda_Ocean_Inc = 166, // Panda Ocean Inc.
        
        [Description("Visteon Corporation")]
        Visteon_Corporation = 167, // Visteon Corporation
        
        [Description("ARP Devices Limited")]
        ARP_Devices_Limited = 168, // ARP Devices Limited
        
        [Description("Magneti Marelli S.p.A")]
        Magneti_Marelli_S_p_A = 169, // Magneti Marelli S.p.A
        
        [Description("CAEN RFID srl")]
        CAEN_RFID_srl = 170, // CAEN RFID srl
        
        [Description("Ingenieur-Systemgruppe Zahn GmbH")]
        Ingenieur_Systemgruppe_Zahn_GmbH = 171, // Ingenieur-Systemgruppe Zahn GmbH
        
        [Description("Green Throttle Games")]
        Green_Throttle_Games = 172, // Green Throttle Games
        
        [Description("Peter Systemtechnik GmbH")]
        Peter_Systemtechnik_GmbH = 173, // Peter Systemtechnik GmbH
        
        [Description("Omegawave Oy")]
        Omegawave_Oy = 174, // Omegawave Oy
        
        [Description("Cinetix")]
        Cinetix = 175, // Cinetix
        
        [Description("Passif Semiconductor Corp")]
        Passif_Semiconductor_Corp = 176, // Passif Semiconductor Corp
        
        [Description("Saris Cycling Group, Inc")]
        Saris_Cycling_Group_Inc = 177, // Saris Cycling Group, Inc
        
        [Description("Bekey A/S")]
        Bekey_A_S = 178, // Bekey A/S
        
        [Description("Clarinox Technologies Pty. Ltd.")]
        Clarinox_Technologies_Pty_Ltd = 179, // Clarinox Technologies Pty. Ltd.
        
        [Description("BDE Technology Co., Ltd.")]
        BDE_Technology_Co_Ltd = 180, // BDE Technology Co., Ltd.
        
        [Description("Swirl Networks")]
        Swirl_Networks = 181, // Swirl Networks
        
        [Description("Meso international")]
        Meso_international = 182, // Meso international
        
        [Description("TreLab Ltd")]
        TreLab_Ltd = 183, // TreLab Ltd
        
        [Description("Qualcomm Innovation Center, Inc. (QuIC)")]
        Qualcomm_Innovation_Center_Inc_QuIC = 184, // Qualcomm Innovation Center, Inc. (QuIC)
        
        [Description("Johnson Controls, Inc.")]
        Johnson_Controls_Inc = 185, // Johnson Controls, Inc.
        
        [Description("Starkey Laboratories Inc.")]
        Starkey_Laboratories_Inc = 186, // Starkey Laboratories Inc.
        
        [Description("S-Power Electronics Limited")]
        S_Power_Electronics_Limited = 187, // S-Power Electronics Limited
        
        [Description("Ace Sensor Inc")]
        Ace_Sensor_Inc = 188, // Ace Sensor Inc
        
        [Description("Aplix Corporation")]
        Aplix_Corporation = 189, // Aplix Corporation
        
        [Description("AAMP of America")]
        AAMP_of_America = 190, // AAMP of America
        
        [Description("Stalmart Technology Limited")]
        Stalmart_Technology_Limited = 191, // Stalmart Technology Limited
        
        [Description("AMICCOM Electronics Corporation")]
        AMICCOM_Electronics_Corporation = 192, // AMICCOM Electronics Corporation
        
        [Description("Shenzhen Excelsecu Data Technology Co.,Ltd")]
        Shenzhen_Excelsecu_Data_Technology_Co_Ltd = 193, // Shenzhen Excelsecu Data Technology Co.,Ltd
        
        [Description("Geneq Inc.")]
        Geneq_Inc = 194, // Geneq Inc.
        
        [Description("adidas AG")]
        adidas_AG = 195, // adidas AG
        
        [Description("LG Electronics")]
        LG_Electronics = 196, // LG Electronics
        
        [Description("Onset Computer Corporation")]
        Onset_Computer_Corporation = 197, // Onset Computer Corporation
        
        [Description("Selfly BV")]
        Selfly_BV = 198, // Selfly BV
        
        [Description("Quuppa Oy.")]
        Quuppa_Oy = 199, // Quuppa Oy.
        
        [Description("GeLo Inc")]
        GeLo_Inc = 200, // GeLo Inc
        
        [Description("Evluma")]
        Evluma = 201, // Evluma
        
        [Description("MC10")]
        MC10 = 202, // MC10
        
        [Description("Binauric SE")]
        Binauric_SE = 203, // Binauric SE
        
        [Description("Beats Electronics")]
        Beats_Electronics = 204, // Beats Electronics
        
        [Description("Microchip Technology Inc.")]
        Microchip_Technology_Inc = 205, // Microchip Technology Inc.
        
        [Description("Elgato Systems GmbH")]
        Elgato_Systems_GmbH = 206, // Elgato Systems GmbH
        
        [Description("ARCHOS SA")]
        ARCHOS_SA = 207, // ARCHOS SA
        
        [Description("Dexcom, Inc.")]
        Dexcom_Inc = 208, // Dexcom, Inc.
        
        [Description("Polar Electro Europe B.V.")]
        Polar_Electro_Europe_B_V = 209, // Polar Electro Europe B.V.
        
        [Description("Dialog Semiconductor B.V.")]
        Dialog_Semiconductor_B_V = 210, // Dialog Semiconductor B.V.
        
        [Description("TaixingbangTechnology (HK) Co,. LTD.")]
        TaixingbangTechnology_HK_Co_LTD = 211, // TaixingbangTechnology (HK) Co,. LTD.
        
        [Description("Kawantech")]
        Kawantech = 212, // Kawantech
        
        [Description("Austco Communication Systems")]
        Austco_Communication_Systems = 213, // Austco Communication Systems
        
        [Description("Timex Group USA, Inc.")]
        Timex_Group_USA_Inc = 214, // Timex Group USA, Inc.
        
        [Description("Qualcomm Technologies, Inc.")]
        Qualcomm_Technologies_Inc = 215, // Qualcomm Technologies, Inc.
        
        [Description("Qualcomm Connected Experiences, Inc.")]
        Qualcomm_Connected_Experiences_Inc = 216, // Qualcomm Connected Experiences, Inc.
        
        [Description("Voyetra Turtle Beach")]
        Voyetra_Turtle_Beach = 217, // Voyetra Turtle Beach
        
        [Description("txtr GmbH")]
        txtr_GmbH = 218, // txtr GmbH
        
        [Description("Biosentronics")]
        Biosentronics = 219, // Biosentronics
        
        [Description("Procter & Gamble")]
        Procter_And_Gamble = 220, // Procter & Gamble
        
        [Description("Hosiden Corporation")]
        Hosiden_Corporation = 221, // Hosiden Corporation
        
        [Description("Muzik LLC")]
        Muzik_LLC = 222, // Muzik LLC
        
        [Description("Misfit Wearables Corp")]
        Misfit_Wearables_Corp = 223, // Misfit Wearables Corp
        
        [Description("Google")]
        Google = 224, // Google
        
        [Description("Danlers Ltd")]
        Danlers_Ltd = 225, // Danlers Ltd
        
        [Description("Semilink Inc")]
        Semilink_Inc = 226, // Semilink Inc
        
        [Description("inMusic Brands, Inc")]
        inMusic_Brands_Inc = 227, // inMusic Brands, Inc
        
        [Description("L.S. Research Inc.")]
        L_S_Research_Inc = 228, // L.S. Research Inc.
        
        [Description("Eden Software Consultants Ltd.")]
        Eden_Software_Consultants_Ltd = 229, // Eden Software Consultants Ltd.
        
        [Description("Freshtemp")]
        Freshtemp = 230, // Freshtemp
        
        [Description("KS Technologies")]
        KS_Technologies = 231, // KS Technologies
        
        [Description("ACTS Technologies")]
        ACTS_Technologies = 232, // ACTS Technologies
        
        [Description("Vtrack Systems")]
        Vtrack_Systems = 233, // Vtrack Systems
        
        [Description("Nielsen-Kellerman Company")]
        Nielsen_Kellerman_Company = 234, // Nielsen-Kellerman Company
        
        [Description("Server Technology, Inc.")]
        Server_Technology_Inc = 235, // Server Technology, Inc.
        
        [Description("BioResearch Associates")]
        BioResearch_Associates = 236, // BioResearch Associates
        
        [Description("Jolly Logic, LLC")]
        Jolly_Logic_LLC = 237, // Jolly Logic, LLC
        
        [Description("Above Average Outcomes, Inc.")]
        Above_Average_Outcomes_Inc = 238, // Above Average Outcomes, Inc.
        
        [Description("Bitsplitters GmbH")]
        Bitsplitters_GmbH = 239, // Bitsplitters GmbH
        
        [Description("PayPal, Inc.")]
        PayPal_Inc = 240, // PayPal, Inc.
        
        [Description("Witron Technology Limited")]
        Witron_Technology_Limited = 241, // Witron Technology Limited
        
        [Description("Aether ThingsInc. (formerly Morse Project Inc.)")]
        Aether_ThingsInc_formerly_Morse_Project_Inc = 242, // Aether ThingsInc. (formerly Morse Project Inc.)
        
        [Description("Kent Displays Inc.")]
        Kent_Displays_Inc = 243, // Kent Displays Inc.
        
        [Description("Nautilus Inc.")]
        Nautilus_Inc = 244, // Nautilus Inc.
        
        [Description("Smartifier Oy")]
        Smartifier_Oy = 245, // Smartifier Oy
        
        [Description("Elcometer Limited")]
        Elcometer_Limited = 246, // Elcometer Limited
        
        [Description("VSN Technologies Inc.")]
        VSN_Technologies_Inc = 247, // VSN Technologies Inc.
        
        [Description("AceUni Corp., Ltd.")]
        AceUni_Corp_Ltd = 248, // AceUni Corp., Ltd.
        
        [Description("StickNFind")]
        StickNFind = 249, // StickNFind
        
        [Description("Crystal Code AB")]
        Crystal_Code_AB = 250, // Crystal Code AB
        
        [Description("KOUKAAM a.s.")]
        KOUKAAM_a_s = 251, // KOUKAAM a.s.
        
        [Description("Delphi Corporation")]
        Delphi_Corporation = 252, // Delphi Corporation
        
        [Description("ValenceTech Limited")]
        ValenceTech_Limited = 253, // ValenceTech Limited
        
        [Description("Reserved")]
        Reserved = 254, // Reserved
        
        [Description("Typo Products, LLC")]
        Typo_Products_LLC = 255, // Typo Products, LLC
        
        [Description("TomTom International BV")]
        TomTom_International_BV = 256, // TomTom International BV
        
        [Description("Fugoo, Inc")]
        Fugoo_Inc = 257, // Fugoo, Inc
        
        [Description("Keiser Corporation")]
        Keiser_Corporation = 258, // Keiser Corporation
        
        [Description("Bang & Olufsen A/S")]
        Bang_And_Olufsen_A_S = 259, // Bang & Olufsen A/S
        
        [Description("PLUS Locations Systems Pty Ltd")]
        PLUS_Locations_Systems_Pty_Ltd = 260, // PLUS Locations Systems Pty Ltd
        
        [Description("Ubiquitous Computing Technology Corporation")]
        Ubiquitous_Computing_Technology_Corporation = 261, // Ubiquitous Computing Technology Corporation
        
        [Description("Innovative Yachtter Solutions")]
        Innovative_Yachtter_Solutions = 262, // Innovative Yachtter Solutions
        
        [Description("William Demant Holding A/S")]
        William_Demant_Holding_A_S = 263, // William Demant Holding A/S
        
        [Description("Chicony Electronics Co., Ltd.")]
        Chicony_Electronics_Co_Ltd = 264, // Chicony Electronics Co., Ltd.
        
        [Description("Atus BV")]
        Atus_BV = 265, // Atus BV
        
        [Description("Codegate Ltd.")]
        Codegate_Ltd = 266, // Codegate Ltd.
        
        [Description("ERi, Inc.")]
        ERi_Inc = 267, // ERi, Inc.
        
        [Description("Transducers Direct, LLC")]
        Transducers_Direct_LLC = 268, // Transducers Direct, LLC
        
        [Description("Fujitsu Ten Limited")]
        Fujitsu_Ten_Limited = 269, // Fujitsu Ten Limited
        
        [Description("Audi AG")]
        Audi_AG = 270, // Audi AG
        
        [Description("HiSilicon Technologies Co., Ltd.")]
        HiSilicon_Technologies_Co_Ltd = 271, // HiSilicon Technologies Co., Ltd.
        
        [Description("Nippon Seiki Co., Ltd.")]
        Nippon_Seiki_Co_Ltd = 272, // Nippon Seiki Co., Ltd.
        
        [Description("Steelseries ApS")]
        Steelseries_ApS = 273, // Steelseries ApS
        
        [Description("Visybl Inc.")]
        Visybl_Inc = 274, // Visybl Inc.
        
        [Description("Openbrain Technologies, Co., Ltd.")]
        Openbrain_Technologies_Co_Ltd = 275, // Openbrain Technologies, Co., Ltd.
        
        [Description("Xensr")]
        Xensr = 276, // Xensr
        
        [Description("e.solutions")]
        e_solutions = 277, // e.solutions
        
        [Description("1OAK Technologies")]
        TenAK_Technologies = 278, // 1OAK Technologies
        
        [Description("Wimoto Technologies Inc")]
        Wimoto_Technologies_Inc = 279, // Wimoto Technologies Inc
        
        [Description("Radius Networks, Inc.")]
        Radius_Networks_Inc = 280, // Radius Networks, Inc.
        
        [Description("Wize Technology Co., Ltd.")]
        Wize_Technology_Co_Ltd = 281, // Wize Technology Co., Ltd.
        
        [Description("Qualcomm Labs, Inc.")]
        Qualcomm_Labs_Inc = 282, // Qualcomm Labs, Inc.
        
        [Description("Aruba Networks")]
        Aruba_Networks = 283, // Aruba Networks
        
        [Description("Baidu")]
        Baidu = 284, // Baidu
        
        [Description("Arendi AG")]
        Arendi_AG = 285, // Arendi AG
        
        [Description("Skoda Auto a.s.")]
        Skoda_Auto_a_s = 286, // Skoda Auto a.s.
        
        [Description("Volkswagen AG")]
        Volkswagen_AG = 287, // Volkswagen AG
        
        [Description("Porsche AG")]
        Porsche_AG = 288, // Porsche AG
        
        [Description("Sino Wealth Electronic Ltd.")]
        Sino_Wealth_Electronic_Ltd = 289, // Sino Wealth Electronic Ltd.
        
        [Description("AirTurn, Inc.")]
        AirTurn_Inc = 290, // AirTurn, Inc.
        
        [Description("Kinsa, Inc.")]
        Kinsa_Inc = 291, // Kinsa, Inc.
        
        [Description("HID Global")]
        HID_Global = 292, // HID Global
        
        [Description("SEAT es")]
        SEAT_es = 293, // SEAT es
        
        [Description("Promethean Ltd.")]
        Promethean_Ltd = 294, // Promethean Ltd.
        
        [Description("Salutica Allied Solutions")]
        Salutica_Allied_Solutions = 295, // Salutica Allied Solutions
        
        [Description("GPSI Group Pty Ltd")]
        GPSI_Group_Pty_Ltd = 296, // GPSI Group Pty Ltd
        
        [Description("Nimble Devices Oy")]
        Nimble_Devices_Oy = 297, // Nimble Devices Oy
        
        [Description("Changzhou Yongse Infotech Co., Ltd")]
        Changzhou_Yongse_Infotech_Co_Ltd = 298, // Changzhou Yongse Infotech Co., Ltd
        
        [Description("SportIQ")]
        SportIQ = 299, // SportIQ
        
        [Description("TEMEC Instruments B.V.")]
        TEMEC_Instruments_B_V = 300, // TEMEC Instruments B.V.
        
        [Description("Sony Corporation")]
        Sony_Corporation = 301, // Sony Corporation
        
        [Description("ASSA ABLOY")]
        ASSA_ABLOY = 302, // ASSA ABLOY
        
        [Description("Clarion Co., Ltd.")]
        Clarion_Co_Ltd = 303, // Clarion Co., Ltd.
        
        [Description("Warehouse Innovations")]
        Warehouse_Innovations = 304, // Warehouse Innovations
        
        [Description("Cypress Semiconductor Corporation")]
        Cypress_Semiconductor_Corporation = 305, // Cypress Semiconductor Corporation
        
        [Description("MADS Inc")]
        MADS_Inc = 306, // MADS Inc
        
        [Description("Blue Maestro Limited")]
        Blue_Maestro_Limited = 307, // Blue Maestro Limited
        
        [Description("Resolution Products, Inc.")]
        Resolution_Products_Inc = 308, // Resolution Products, Inc.
        
        [Description("Airewear LLC")]
        Airewear_LLC = 309, // Airewear LLC
        
        [Description("Seed Labs, Inc. (formerly ETC sp. z.o.o.)")]
        Seed_Labs_Inc_formerly_ETC_sp_z_o_o = 310, // Seed Labs, Inc. (formerly ETC sp. z.o.o.)
        
        [Description("Prestigio Plaza Ltd.")]
        Prestigio_Plaza_Ltd = 311, // Prestigio Plaza Ltd.
        
        [Description("NTEO Inc.")]
        NTEO_Inc = 312, // NTEO Inc.
        
        [Description("Focus Systems Corporation")]
        Focus_Systems_Corporation = 313, // Focus Systems Corporation
        
        [Description("Tencent Holdings Limited")]
        Tencent_Holdings_Limited = 314, // Tencent Holdings Limited
        
        [Description("Allegion")]
        Allegion = 315, // Allegion
        
        [Description("Murata Manufacuring Co., Ltd.")]
        Murata_Manufacuring_Co_Ltd = 316, // Murata Manufacuring Co., Ltd.
        
        [Description("Nod, Inc.")]
        Nod_Inc = 318, // Nod, Inc.
        
        [Description("B&B Manufacturing Company")]
        BAndB_Manufacturing_Company = 319, // B&B Manufacturing Company
        
        [Description("AlpineElectronics(China)Co.,Ltd")]
        AlpineElectronics_China_Co_Ltd = 320, // AlpineElectronics(China)Co.,Ltd
        
        [Description("FedEx Services")]
        FedEx_Services = 321, // FedEx Services
        
        [Description("Grape Systems Inc.")]
        Grape_Systems_Inc = 322, // Grape Systems Inc.
        
        [Description("Bkon Connect")]
        Bkon_Connect = 323, // Bkon Connect
        
        [Description("Lintech GmbH")]
        Lintech_GmbH = 324, // Lintech GmbH
        
        [Description("Novatel Wireless")]
        Novatel_Wireless = 325, // Novatel Wireless
        
        [Description("Ciright")]
        Ciright = 326, // Ciright
        
        [Description("Mighty Cast, Inc.")]
        Mighty_Cast_Inc = 327, // Mighty Cast, Inc.
        
        [Description("Ambimat Electronics")]
        Ambimat_Electronics = 328, // Ambimat Electronics
        
        [Description("Perytons Ltd.")]
        Perytons_Ltd = 329, // Perytons Ltd.
        
        [Description("Tivoli Audio, LLC")]
        Tivoli_Audio_LLC = 330, // Tivoli Audio, LLC
        
        [Description("Master Lock")]
        Master_Lock = 331, // Master Lock
        
        [Description("Mesh-Net Ltd")]
        Mesh_Net_Ltd = 332, // Mesh-Net Ltd
        
        [Description("Huizhou Desay SV Automotive CO., LTD.")]
        Huizhou_Desay_SV_Automotive_CO_LTD = 333, // Huizhou Desay SV Automotive CO., LTD.
        
        [Description("Tangerine, Inc.")]
        Tangerine_Inc = 334, // Tangerine, Inc.
        
        [Description("B&W Group Ltd.")]
        BAndW_Group_Ltd = 335, // B&W Group Ltd.
        
        [Description("Pioneer Corporation")]
        Pioneer_Corporation = 336, // Pioneer Corporation
        
        [Description("OnBeep")]
        OnBeep = 337, // OnBeep
        
        [Description("Vernier Software & Technology")]
        Vernier_Software_And_Technology = 338, // Vernier Software & Technology
        
        [Description("ROL Ergo")]
        ROL_Ergo = 339, // ROL Ergo
        
        [Description("Pebble Technology")]
        Pebble_Technology = 340, // Pebble Technology
        
        [Description("NETATMO")]
        NETATMO = 341, // NETATMO
        
        [Description("Accumulate AB")]
        Accumulate_AB = 342, // Accumulate AB
        
        [Description("Anhui Huami Information Technology Co., Ltd.")]
        Anhui_Huami_Information_Technology_Co_Ltd = 343, // Anhui Huami Information Technology Co., Ltd.
        
        [Description("Inmite s.r.o.")]
        Inmite_s_r_o = 344, // Inmite s.r.o.
        
        [Description("ChefSteps, Inc.")]
        ChefSteps_Inc = 345, // ChefSteps, Inc.
        
        [Description("micas AG")]
        micas_AG = 346, // micas AG
        
        [Description("Biomedical Research Ltd.")]
        Biomedical_Research_Ltd = 347, // Biomedical Research Ltd.
        
        [Description("Pitius Tec S.L.")]
        Pitius_Tec_S_L = 348, // Pitius Tec S.L.
        
        [Description("Estimote, Inc.")]
        Estimote_Inc = 349, // Estimote, Inc.
        
        [Description("Unikey Technologies, Inc.")]
        Unikey_Technologies_Inc = 350, // Unikey Technologies, Inc.
        
        [Description("Timer Cap Co.")]
        Timer_Cap_Co = 351, // Timer Cap Co.
        
        [Description("AwoX")]
        AwoX = 352, // AwoX
        
        [Description("yikes")]
        yikes = 353, // yikes
        
        [Description("MADSGlobal NZ Ltd.")]
        MADSGlobal_NZ_Ltd = 354, // MADSGlobal NZ Ltd.
        
        [Description("PCH International")]
        PCH_International = 355, // PCH International
        
        [Description("Qingdao Yeelink Information Technology Co., Ltd.")]
        Qingdao_Yeelink_Information_Technology_Co_Ltd = 356, // Qingdao Yeelink Information Technology Co., Ltd.
        
        [Description("Milwaukee Tool (formerly Milwaukee Electric Tools)")]
        Milwaukee_Tool_formerly_Milwaukee_Electric_Tools = 357, // Milwaukee Tool (formerly Milwaukee Electric Tools)
        
        [Description("MISHIK Pte Ltd")]
        MISHIK_Pte_Ltd = 358, // MISHIK Pte Ltd
        
        [Description("Bayer HealthCare")]
        Bayer_HealthCare = 359, // Bayer HealthCare
        
        [Description("Spicebox LLC")]
        Spicebox_LLC = 360, // Spicebox LLC
        
        [Description("emberlight")]
        emberlight = 361, // emberlight
        
        [Description("Cooper-Atkins Corporation")]
        Cooper_Atkins_Corporation = 362, // Cooper-Atkins Corporation
        
        [Description("Qblinks")]
        Qblinks = 363, // Qblinks
        
        [Description("MYSPHERA")]
        MYSPHERA = 364, // MYSPHERA
        
        [Description("LifeScan Inc")]
        LifeScan_Inc = 365, // LifeScan Inc
        
        [Description("Volantic AB")]
        Volantic_AB = 366, // Volantic AB
        
        [Description("Podo Labs, Inc")]
        Podo_Labs_Inc = 367, // Podo Labs, Inc
        
        [Description("F. Hoffmann-La Roche AG")]
        F_Hoffmann_La_Roche_AG = 368, // F. Hoffmann-La Roche AG
        
        [Description("Amazon Fulfillment Service")]
        Amazon_Fulfillment_Service = 369, // Amazon Fulfillment Service
        
        [Description("Connovate Technology Private Limited")]
        Connovate_Technology_Private_Limited = 370, // Connovate Technology Private Limited
        
        [Description("Kocomojo, LLC")]
        Kocomojo_LLC = 371, // Kocomojo, LLC
        
        [Description("Everykey LLC")]
        Everykey_LLC = 372, // Everykey LLC
        
        [Description("Dynamic Controls")]
        Dynamic_Controls = 373, // Dynamic Controls
        
        [Description("SentriLock")]
        SentriLock = 374, // SentriLock
        
        [Description("I-SYST inc.")]
        I_SYST_inc = 375, // I-SYST inc.
        
        [Description("CASIO COMPUTER CO., LTD.")]
        CASIO_COMPUTER_CO_LTD = 376, // CASIO COMPUTER CO., LTD.
        
        [Description("LAPIS Semiconductor Co., Ltd.")]
        LAPIS_Semiconductor_Co_Ltd = 377, // LAPIS Semiconductor Co., Ltd.
        
        [Description("Telemonitor, Inc.")]
        Telemonitor_Inc = 378, // Telemonitor, Inc.
        
        [Description("taskit GmbH")]
        taskit_GmbH = 379, // taskit GmbH
        
        [Description("Daimler AG")]
        Daimler_AG = 380, // Daimler AG
        
        [Description("BatAndCat")]
        BatAndCat = 381, // BatAndCat
        
        [Description("BluDotz Ltd")]
        BluDotz_Ltd = 382, // BluDotz Ltd
        
        [Description("XTel ApS")]
        XTel_ApS = 383, // XTel ApS
        
        [Description("Gigaset Communications GmbH")]
        Gigaset_Communications_GmbH = 384, // Gigaset Communications GmbH
        
        [Description("Gecko Health Innovations, Inc.")]
        Gecko_Health_Innovations_Inc = 385, // Gecko Health Innovations, Inc.
        
        [Description("HOP Ubiquitous")]
        HOP_Ubiquitous = 386, // HOP Ubiquitous
        
        [Description("To Be Assigned")]
        To_Be_Assigned = 387, // To Be Assigned
        
        [Description("Nectar")]
        Nectar = 388, // Nectar
        
        [Description("bel'apps LLC")]
        bel_apps_LLC = 389, // bel'apps LLC
        
        [Description("CORE Lighting Ltd")]
        CORE_Lighting_Ltd = 390, // CORE Lighting Ltd
        
        [Description("Seraphim Sense Ltd")]
        Seraphim_Sense_Ltd = 391, // Seraphim Sense Ltd
        
        [Description("Unico RBC")]
        Unico_RBC = 392, // Unico RBC
        
        [Description("Physical Enterprises Inc.")]
        Physical_Enterprises_Inc = 393, // Physical Enterprises Inc.
        
        [Description("Able Trend Technology Limited")]
        Able_Trend_Technology_Limited = 394, // Able Trend Technology Limited
        
        [Description("Konica Minolta, Inc.")]
        Konica_Minolta_Inc = 395, // Konica Minolta, Inc.
        
        [Description("Wilo SE")]
        Wilo_SE = 396, // Wilo SE
        
        [Description("Extron Design Services")]
        Extron_Design_Services = 397, // Extron Design Services
        
        [Description("Fitbit, Inc.")]
        Fitbit_Inc = 398, // Fitbit, Inc.
        
        [Description("Fireflies Systems")]
        Fireflies_Systems = 399, // Fireflies Systems
        
        [Description("Intelletto Technologies Inc.")]
        Intelletto_Technologies_Inc = 400, // Intelletto Technologies Inc.
        
        [Description("FDK CORPORATION")]
        FDK_CORPORATION = 401, // FDK CORPORATION
        
        [Description("Cloudleaf, Inc")]
        Cloudleaf_Inc = 402, // Cloudleaf, Inc
        
        [Description("Maveric Automation LLC")]
        Maveric_Automation_LLC = 403, // Maveric Automation LLC
        
        [Description("Acoustic Stream Corporation")]
        Acoustic_Stream_Corporation = 404, // Acoustic Stream Corporation
        
        [Description("Zuli")]
        Zuli = 405, // Zuli
        
        [Description("Paxton Access Ltd")]
        Paxton_Access_Ltd = 406, // Paxton Access Ltd
        
        [Description("WiSilica Inc")]
        WiSilica_Inc = 407, // WiSilica Inc
        
        [Description("VENGIT Korlátolt Felelősségű Társaság")]
        VENGIT_Korl_tolt_Felel_ss_g_T_rsas_g = 408, // VENGIT Korlátolt Felelősségű Társaság
        
        [Description("SALTO SYSTEMS S.L.")]
        SALTO_SYSTEMS_S_L = 409, // SALTO SYSTEMS S.L.
        
        [Description("TRON Forum (formerly T-Engine Forum)")]
        TRON_Forum_formerly_T_Engine_Forum = 410, // TRON Forum (formerly T-Engine Forum)
        
        [Description("CUBETECH s.r.o.")]
        CUBETECH_s_r_o = 411, // CUBETECH s.r.o.
        
        [Description("Cokiya Incorporated")]
        Cokiya_Incorporated = 412, // Cokiya Incorporated
        
        [Description("CVS Health")]
        CVS_Health = 413, // CVS Health
        
        [Description("Ceruus")]
        Ceruus = 414, // Ceruus
        
        [Description("Strainstall Ltd")]
        Strainstall_Ltd = 415, // Strainstall Ltd
        
        [Description("Channel Enterprises (HK) Ltd.")]
        Channel_Enterprises_HK_Ltd = 416, // Channel Enterprises (HK) Ltd.
        
        [Description("FIAMM")]
        FIAMM = 417, // FIAMM
        
        [Description("GIGALANE.CO.,LTD")]
        GIGALANE_CO_LTD = 418, // GIGALANE.CO.,LTD
        
        [Description("EROAD")]
        EROAD = 419, // EROAD
        
        [Description("Mine Safety Appliances")]
        Mine_Safety_Appliances = 420, // Mine Safety Appliances
        
        [Description("Icon Health and Fitness")]
        Icon_Health_and_Fitness = 421, // Icon Health and Fitness
        
        [Description("Asandoo GmbH")]
        Asandoo_GmbH = 422, // Asandoo GmbH
        
        [Description("ENERGOUS CORPORATION")]
        ENERGOUS_CORPORATION = 423, // ENERGOUS CORPORATION
        
        [Description("Taobao")]
        Taobao = 424, // Taobao
        
        [Description("Canon Inc.")]
        Canon_Inc = 425, // Canon Inc.
        
        [Description("Geophysical Technology Inc.")]
        Geophysical_Technology_Inc = 426, // Geophysical Technology Inc.
        
        [Description("Facebook, Inc.")]
        Facebook_Inc = 427, // Facebook, Inc.
        
        [Description("Nipro Diagnostics, Inc.")]
        Nipro_Diagnostics_Inc = 428, // Nipro Diagnostics, Inc.
        
        [Description("FlightSafety International")]
        FlightSafety_International = 429, // FlightSafety International
        
        [Description("Earlens Corporation")]
        Earlens_Corporation = 430, // Earlens Corporation
        
        [Description("Sunrise Micro Devices, Inc.")]
        Sunrise_Micro_Devices_Inc = 431, // Sunrise Micro Devices, Inc.
        
        [Description("Star Micronics Co., Ltd.")]
        Star_Micronics_Co_Ltd = 432, // Star Micronics Co., Ltd.
        
        [Description("Netizens Sp. z o.o.")]
        Netizens_Sp_z_o_o = 433, // Netizens Sp. z o.o.
        
        [Description("Nymi Inc.")]
        Nymi_Inc = 434, // Nymi Inc.
        
        [Description("Nytec, Inc.")]
        Nytec_Inc = 435, // Nytec, Inc.
        
        [Description("Trineo Sp. z o.o.")]
        Trineo_Sp_z_o_o = 436, // Trineo Sp. z o.o.
        
        [Description("Nest Labs Inc.")]
        Nest_Labs_Inc = 437, // Nest Labs Inc.
        
        [Description("LM Technologies Ltd")]
        LM_Technologies_Ltd = 438, // LM Technologies Ltd
        
        [Description("General Electric Company")]
        General_Electric_Company = 439, // General Electric Company
        
        [Description("i+D3 S.L.")]
        i_D3_S_L = 440, // i+D3 S.L.
        
        [Description("HANA Micron")]
        HANA_Micron = 441, // HANA Micron
        
        [Description("Stages Cycling LLC")]
        Stages_Cycling_LLC = 442, // Stages Cycling LLC
        
        [Description("Cochlear Bone Anchored Solutions AB")]
        Cochlear_Bone_Anchored_Solutions_AB = 443, // Cochlear Bone Anchored Solutions AB
        
        [Description("SenionLab AB")]
        SenionLab_AB = 444, // SenionLab AB
        
        [Description("Syszone Co., Ltd")]
        Syszone_Co_Ltd = 445, // Syszone Co., Ltd
        
        [Description("Pulsate Mobile Ltd.")]
        Pulsate_Mobile_Ltd = 446, // Pulsate Mobile Ltd.
        
        [Description("Hong Kong HunterSun Electronic Limited")]
        Hong_Kong_HunterSun_Electronic_Limited = 447, // Hong Kong HunterSun Electronic Limited
        
        [Description("pironex GmbH")]
        pironex_GmbH = 448, // pironex GmbH
        
        [Description("BRADATECH Corp.")]
        BRADATECH_Corp = 449, // BRADATECH Corp.
        
        [Description("Transenergooil AG")]
        Transenergooil_AG = 450, // Transenergooil AG
        
        [Description("Bunch")]
        Bunch = 451, // Bunch
        
        [Description("DME Microelectronics")]
        DME_Microelectronics = 452, // DME Microelectronics
        
        [Description("Bitcraze AB")]
        Bitcraze_AB = 453, // Bitcraze AB
        
        [Description("HASWARE Inc.")]
        HASWARE_Inc = 454, // HASWARE Inc.
        
        [Description("Abiogenix Inc.")]
        Abiogenix_Inc = 455, // Abiogenix Inc.
        
        [Description("Poly-Control ApS")]
        Poly_Control_ApS = 456, // Poly-Control ApS
        
        [Description("Avi-on")]
        Avi_on = 457, // Avi-on
        
        [Description("Laerdal Medical AS")]
        Laerdal_Medical_AS = 458, // Laerdal Medical AS
        
        [Description("Fetch My Pet")]
        Fetch_My_Pet = 459, // Fetch My Pet
        
        [Description("Sam Labs Ltd.")]
        Sam_Labs_Ltd = 460, // Sam Labs Ltd.
        
        [Description("Chengdu Synwing Technology Ltd")]
        Chengdu_Synwing_Technology_Ltd = 461, // Chengdu Synwing Technology Ltd
        
        [Description("HOUWA SYSTEM DESIGN, k.k.")]
        HOUWA_SYSTEM_DESIGN_k_k = 462, // HOUWA SYSTEM DESIGN, k.k.
        
        [Description("BSH")]
        BSH = 463, // BSH
        
        [Description("Primus Inter Pares Ltd")]
        Primus_Inter_Pares_Ltd = 464, // Primus Inter Pares Ltd
        
        [Description("August")]
        August = 465, // August
        
        [Description("Gill Electronics")]
        Gill_Electronics = 466, // Gill Electronics
        
        [Description("Sky Wave Design")]
        Sky_Wave_Design = 467, // Sky Wave Design
        
        [Description("Newlab S.r.l.")]
        Newlab_S_r_l = 468, // Newlab S.r.l.
        
        [Description("ELAD srl")]
        ELAD_srl = 469, // ELAD srl
        
        [Description("G-wearables inc.")]
        G_wearables_inc = 470, // G-wearables inc.
        
        [Description("Squadrone Systems Inc.")]
        Squadrone_Systems_Inc = 471, // Squadrone Systems Inc.
        
        [Description("Code Corporation")]
        Code_Corporation = 472, // Code Corporation
        
        [Description("Savant Systems LLC")]
        Savant_Systems_LLC = 473, // Savant Systems LLC
        
        [Description("Logitech International SA")]
        Logitech_International_SA = 474, // Logitech International SA
        
        [Description("Innblue Consulting")]
        Innblue_Consulting = 475, // Innblue Consulting
        
        [Description("iParking Ltd.")]
        iParking_Ltd = 476, // iParking Ltd.
        
        [Description("Koninklijke Philips Electronics N.V.")]
        Koninklijke_Philips_Electronics_N_V = 477, // Koninklijke Philips Electronics N.V.
        
        [Description("Minelab Electronics Pty Limited")]
        Minelab_Electronics_Pty_Limited = 478, // Minelab Electronics Pty Limited
        
        [Description("Bison Group Ltd.")]
        Bison_Group_Ltd = 479, // Bison Group Ltd.
        
        [Description("Widex A/S")]
        Widex_A_S = 480, // Widex A/S
        
        [Description("Jolla Ltd")]
        Jolla_Ltd = 481, // Jolla Ltd
        
        [Description("Lectronix, Inc.")]
        Lectronix_Inc = 482, // Lectronix, Inc.
        
        [Description("Caterpillar Inc")]
        Caterpillar_Inc = 483, // Caterpillar Inc
        
        [Description("Freedom Innovations")]
        Freedom_Innovations = 484, // Freedom Innovations
        
        [Description("Dynamic Devices Ltd")]
        Dynamic_Devices_Ltd = 485, // Dynamic Devices Ltd
        
        [Description("Technology Solutions (UK) Ltd")]
        Technology_Solutions_UK_Ltd = 486, // Technology Solutions (UK) Ltd
        
        [Description("IPS Group Inc.")]
        IPS_Group_Inc = 487, // IPS Group Inc.
        
        [Description("STIR")]
        STIR = 488, // STIR
        
        [Description("Sano, Inc")]
        Sano_Inc = 489, // Sano, Inc
        
        [Description("Advanced Application Design, Inc.")]
        Advanced_Application_Design_Inc = 490, // Advanced Application Design, Inc.
        
        [Description("AutoMap LLC")]
        AutoMap_LLC = 491, // AutoMap LLC
        
        [Description("Spreadtrum Communications Shanghai Ltd")]
        Spreadtrum_Communications_Shanghai_Ltd = 492, // Spreadtrum Communications Shanghai Ltd
        
        [Description("CuteCircuit LTD")]
        CuteCircuit_LTD = 493, // CuteCircuit LTD
        
        [Description("Valeo Service")]
        Valeo_Service = 494, // Valeo Service
        
        [Description("Fullpower Technologies, Inc.")]
        Fullpower_Technologies_Inc = 495, // Fullpower Technologies, Inc.
        
        [Description("KloudNation")]
        KloudNation = 496, // KloudNation
        
        [Description("Zebra Technologies Corporation")]
        Zebra_Technologies_Corporation = 497, // Zebra Technologies Corporation
        
        [Description("Itron, Inc.")]
        Itron_Inc = 498, // Itron, Inc.
        
        [Description("The University of Tokyo")]
        The_University_of_Tokyo = 499, // The University of Tokyo
        
        [Description("UTC Fire and Security")]
        UTC_Fire_and_Security = 500, // UTC Fire and Security
        
        [Description("Cool Webthings Limited")]
        Cool_Webthings_Limited = 501, // Cool Webthings Limited
        
        [Description("DJO Global")]
        DJO_Global = 502, // DJO Global
        
        [Description("Gelliner Limited")]
        Gelliner_Limited = 503, // Gelliner Limited
        
        [Description("Anyka (Guangzhou) Microelectronics Technology Co, LTD")]
        Anyka_Guangzhou_Microelectronics_Technology_Co_LTD = 504, // Anyka (Guangzhou) Microelectronics Technology Co, LTD
        
        [Description("Medtronic, Inc.")]
        Medtronic_Inc = 505, // Medtronic, Inc.
        
        [Description("Gozio, Inc.")]
        Gozio_Inc = 506, // Gozio, Inc.
        
        [Description("Form Lifting, LLC")]
        Form_Lifting_LLC = 507, // Form Lifting, LLC
        
        [Description("Wahoo Fitness, LLC")]
        Wahoo_Fitness_LLC = 508, // Wahoo Fitness, LLC
        
        [Description("Kontakt Micro-Location Sp. z o.o.")]
        Kontakt_Micro_Location_Sp_z_o_o = 509, // Kontakt Micro-Location Sp. z o.o.
        
        [Description("Radio System Corporation")]
        Radio_System_Corporation = 510, // Radio System Corporation
        
        [Description("Freescale Semiconductor, Inc.")]
        Freescale_Semiconductor_Inc = 511, // Freescale Semiconductor, Inc.
        
        [Description("Verifone Systems PTe Ltd. Taiwan Branch")]
        Verifone_Systems_PTe_Ltd_Taiwan_Branch = 512, // Verifone Systems PTe Ltd. Taiwan Branch
        
        [Description("AR Timing")]
        AR_Timing = 513, // AR Timing
        
        [Description("Rigado LLC")]
        Rigado_LLC = 514, // Rigado LLC
        
        [Description("Kemppi Oy")]
        Kemppi_Oy = 515, // Kemppi Oy
        
        [Description("Tapcentive Inc.")]
        Tapcentive_Inc = 516, // Tapcentive Inc.
        
        [Description("Smartbotics Inc.")]
        Smartbotics_Inc = 517, // Smartbotics Inc.
        
        [Description("Otter Products, LLC")]
        Otter_Products_LLC = 518, // Otter Products, LLC
        
        [Description("STEMP Inc.")]
        STEMP_Inc = 519, // STEMP Inc.
        
        [Description("LumiGeek LLC")]
        LumiGeek_LLC = 520, // LumiGeek LLC
        
        [Description("InvisionHeart Inc.")]
        InvisionHeart_Inc = 521, // InvisionHeart Inc.
        
        [Description("Macnica Inc. ")]
        Macnica_Inc = 522, // Macnica Inc. 
        
        [Description("Jaguar Land Rover Limited")]
        Jaguar_Land_Rover_Limited = 523, // Jaguar Land Rover Limited
        
        [Description("CoroWare Technologies, Inc")]
        CoroWare_Technologies_Inc = 524, // CoroWare Technologies, Inc
        
        [Description("Simplo Technology Co., LTD")]
        Simplo_Technology_Co_LTD = 525, // Simplo Technology Co., LTD
        
        [Description("Omron Healthcare Co., LTD")]
        Omron_Healthcare_Co_LTD = 526, // Omron Healthcare Co., LTD
        
        [Description("Comodule GMBH")]
        Comodule_GMBH = 527, // Comodule GMBH
        
        [Description("ikeGPS")]
        ikeGPS = 528, // ikeGPS
        
        [Description("Telink Semiconductor Co. Ltd")]
        Telink_Semiconductor_Co_Ltd = 529, // Telink Semiconductor Co. Ltd
        
        [Description("Interplan Co., Ltd")]
        Interplan_Co_Ltd = 530, // Interplan Co., Ltd
        
        [Description("Wyler AG")]
        Wyler_AG = 531, // Wyler AG
        
        [Description("IK Multimedia Production srl")]
        IK_Multimedia_Production_srl = 532, // IK Multimedia Production srl
        
        [Description("Lukoton Experience Oy")]
        Lukoton_Experience_Oy = 533, // Lukoton Experience Oy
        
        [Description("MTI Ltd")]
        MTI_Ltd = 534, // MTI Ltd
        
        [Description("Tech4home, Lda")]
        Tech4home_Lda = 535, // Tech4home, Lda
        
        [Description("Hiotech AB")]
        Hiotech_AB = 536, // Hiotech AB
        
        [Description("DOTT Limited")]
        DOTT_Limited = 537, // DOTT Limited
        
        [Description("Blue Speck Labs, LLC")]
        Blue_Speck_Labs_LLC = 538, // Blue Speck Labs, LLC
        
        [Description("Cisco Systems Inc")]
        Cisco_Systems_Inc = 539, // Cisco Systems Inc
        
        [Description("Mobicomm Inc")]
        Mobicomm_Inc = 540, // Mobicomm Inc
        
        [Description("Edamic")]
        Edamic = 541, // Edamic
        
        [Description("Goodnet Ltd")]
        Goodnet_Ltd = 542, // Goodnet Ltd
        
        [Description("Luster Leaf Products Inc")]
        Luster_Leaf_Products_Inc = 543, // Luster Leaf Products Inc
        
        [Description("Manus Machina BV")]
        Manus_Machina_BV = 544, // Manus Machina BV
        
        [Description("Mobiquity Networks Inc")]
        Mobiquity_Networks_Inc = 545, // Mobiquity Networks Inc
        
        [Description("Praxis Dynamics")]
        Praxis_Dynamics = 546, // Praxis Dynamics
        
        [Description("Philip Morris Products S.A.")]
        Philip_Morris_Products_S_A = 547, // Philip Morris Products S.A.
        
        [Description("Comarch SA")]
        Comarch_SA = 548, // Comarch SA
        
        [Description("Nestl&eacute; Nespresso S.A.")]
        NestlAndeacute_Nespresso_S_A = 549, // Nestl&eacute; Nespresso S.A.
        
        [Description("Merlinia A/S")]
        Merlinia_A_S = 550, // Merlinia A/S
        
        [Description("LifeBEAM Technologies")]
        LifeBEAM_Technologies = 551, // LifeBEAM Technologies
        
        [Description("Twocanoes Labs, LLC")]
        Twocanoes_Labs_LLC = 552, // Twocanoes Labs, LLC
        
        [Description("Muoverti Limited")]
        Muoverti_Limited = 553, // Muoverti Limited
        
        [Description("Stamer Musikanlagen GMBH")]
        Stamer_Musikanlagen_GMBH = 554, // Stamer Musikanlagen GMBH
        
        [Description("Tesla Motors")]
        Tesla_Motors = 555, // Tesla Motors
        
        [Description("Pharynks Corporation")]
        Pharynks_Corporation = 556, // Pharynks Corporation
        
        [Description("Lupine")]
        Lupine = 557, // Lupine
        
        [Description("Siemens AG")]
        Siemens_AG = 558, // Siemens AG
        
        [Description("Huami (Shanghai) Culture Communication CO., LTD")]
        Huami_Shanghai_Culture_Communication_CO_LTD = 559, // Huami (Shanghai) Culture Communication CO., LTD
        
        [Description("Foster Electric Company, Ltd")]
        Foster_Electric_Company_Ltd = 560, // Foster Electric Company, Ltd
        
        [Description("ETA SA")]
        ETA_SA = 561, // ETA SA
        
        [Description(" x-Senso Solutions Kft")]
        _x_Senso_Solutions_Kft = 562, //  x-Senso Solutions Kft
        
        [Description(" Shenzhen SuLong Communication Ltd")]
        _Shenzhen_SuLong_Communication_Ltd = 563, //  Shenzhen SuLong Communication Ltd
        
        [Description(" FengFan (BeiJing) Technology Co, Ltd")]
        _FengFan_BeiJing_Technology_Co_Ltd = 564, //  FengFan (BeiJing) Technology Co, Ltd
        
        [Description(" Qrio Inc")]
        _Qrio_Inc = 565, //  Qrio Inc
        
        [Description(" Pitpatpet Ltd")]
        _Pitpatpet_Ltd = 566, //  Pitpatpet Ltd
        
        [Description(" MSHeli s.r.l.")]
        _MSHeli_s_r_l = 567, //  MSHeli s.r.l.
        
        [Description("Trakm8 Ltd")]
        Trakm8_Ltd = 568, // Trakm8 Ltd
        
        [Description("JIN CO, Ltd")]
        JIN_CO_Ltd = 569, // JIN CO, Ltd
        
        [Description("Alatech Technology")]
        Alatech_Technology = 570, // Alatech Technology
        
        [Description("Beijing CarePulse Electronic Technology Co, Ltd")]
        Beijing_CarePulse_Electronic_Technology_Co_Ltd = 571, // Beijing CarePulse Electronic Technology Co, Ltd
        
        [Description("Awarepoint")]
        Awarepoint = 572, // Awarepoint
        
        [Description("ViCentra B.V.")]
        ViCentra_B_V = 573, // ViCentra B.V.
        
        [Description("Raven Industries")]
        Raven_Industries = 574, // Raven Industries
        
        [Description("WaveWare Technologies")]
        WaveWare_Technologies = 575, // WaveWare Technologies
        
        [Description("Argenox Technologies")]
        Argenox_Technologies = 576, // Argenox Technologies
        
        [Description("Bragi GmbH")]
        Bragi_GmbH = 577, // Bragi GmbH
        
        [Description("16Lab Inc")]
        SixteenLab_Inc = 578, // 16Lab Inc
        
        [Description("Masimo Corp")]
        Masimo_Corp = 579, // Masimo Corp
        
        [Description("Iotera Inc.")]
        Iotera_Inc = 580, // Iotera Inc.
        
        [Description("Endress+Hauser")]
        Endress_Hauser = 581, // Endress+Hauser
        
        [Description("ACKme Networks, Inc.")]
        ACKme_Networks_Inc = 582, // ACKme Networks, Inc.
        
        [Description("FiftyThree Inc.")]
        FiftyThree_Inc = 583, // FiftyThree Inc.
        
        [Description("Parker Hannifin Corp")]
        Parker_Hannifin_Corp = 584, // Parker Hannifin Corp
        
        [Description("Transcranial Ltd")]
        Transcranial_Ltd = 585, // Transcranial Ltd
        
        [Description("Uwatec AG")]
        Uwatec_AG = 586, // Uwatec AG
        
        [Description("Orlan LLC")]
        Orlan_LLC = 587, // Orlan LLC
        
        [Description("Blue Clover Devices")]
        Blue_Clover_Devices = 588, // Blue Clover Devices
        
        [Description("M-Way Solutions GmbH")]
        M_Way_Solutions_GmbH = 589, // M-Way Solutions GmbH
        
        [Description("Microtronics Engineering GmbH")]
        Microtronics_Engineering_GmbH = 590, // Microtronics Engineering GmbH
        
        [Description("Schneider Schreibger&auml;te GmbH")]
        Schneider_SchreibgerAndauml_te_GmbH = 591, // Schneider Schreibger&auml;te GmbH
        
        [Description("Sapphire Circuits LLC")]
        Sapphire_Circuits_LLC = 592, // Sapphire Circuits LLC
        
        [Description("Lumo Bodytech Inc.")]
        Lumo_Bodytech_Inc = 593, // Lumo Bodytech Inc.
        
        [Description("UKC Technosolution")]
        UKC_Technosolution = 594, // UKC Technosolution
        
        [Description("Xicato Inc.")]
        Xicato_Inc = 595, // Xicato Inc.
        
        [Description("Playbrush")]
        Playbrush = 596, // Playbrush
        
        [Description("Dai Nippon Printing Co., Ltd.")]
        Dai_Nippon_Printing_Co_Ltd = 597, // Dai Nippon Printing Co., Ltd.
        
        [Description("G24 Power Limited")]
        G24_Power_Limited = 598, // G24 Power Limited
        
        [Description("AdBabble Local Commerce Inc.")]
        AdBabble_Local_Commerce_Inc = 599, // AdBabble Local Commerce Inc.
        
        [Description("Devialet SA")]
        Devialet_SA = 600, // Devialet SA
        
        [Description("ALTYOR")]
        ALTYOR = 601, // ALTYOR
        
        [Description("University of Applied Sciences Valais/Haute Ecole Valaisanne")]
        University_of_Applied_Sciences_Valais_Haute_Ecole_Valaisanne = 602, // University of Applied Sciences Valais/Haute Ecole Valaisanne
        
        [Description("Five Interactive, LLC dba Zendo")]
        Five_Interactive_LLC_dba_Zendo = 603, // Five Interactive, LLC dba Zendo
        
        [Description("NetEase (Hangzhou) Network co.Ltd.")]
        NetEase_Hangzhou_Network_co_Ltd = 604, // NetEase (Hangzhou) Network co.Ltd.
        
        [Description("Lexmark International Inc.")]
        Lexmark_International_Inc = 605, // Lexmark International Inc.
        
        [Description("Fluke Corporation")]
        Fluke_Corporation = 606, // Fluke Corporation
        
        [Description("Yardarm Technologies")]
        Yardarm_Technologies = 607, // Yardarm Technologies
        
        [Description("SensaRx")]
        SensaRx = 608, // SensaRx
        
        [Description("SECVRE GmbH")]
        SECVRE_GmbH = 609, // SECVRE GmbH
        
        [Description("Glacial Ridge Technologies")]
        Glacial_Ridge_Technologies = 610, // Glacial Ridge Technologies
        
        [Description("Identiv, Inc.")]
        Identiv_Inc = 611, // Identiv, Inc.
        
        [Description("DDS, Inc.")]
        DDS_Inc = 612, // DDS, Inc.
        
        [Description("SMK Corporation")]
        SMK_Corporation = 613, // SMK Corporation
        
        [Description("Schawbel Technologies LLC")]
        Schawbel_Technologies_LLC = 614, // Schawbel Technologies LLC
        
        [Description("XMI Systems SA")]
        XMI_Systems_SA = 615, // XMI Systems SA
        
        [Description("Cerevo")]
        Cerevo = 616, // Cerevo
        
        [Description("Torrox GmbH & Co KG")]
        Torrox_GmbH_And_Co_KG = 617, // Torrox GmbH & Co KG
        
        [Description("Gemalto")]
        Gemalto = 618, // Gemalto
        
        [Description("DEKA Research & Development Corp.")]
        DEKA_Research_And_Development_Corp = 619, // DEKA Research & Development Corp.
        
        [Description("Domster Tadeusz Szydlowski")]
        Domster_Tadeusz_Szydlowski = 620, // Domster Tadeusz Szydlowski
        
        [Description("Technogym SPA")]
        Technogym_SPA = 621, // Technogym SPA
        
        [Description("FLEURBAEY BVBA")]
        FLEURBAEY_BVBA = 622, // FLEURBAEY BVBA
        
        [Description("Aptcode Solutions")]
        Aptcode_Solutions = 623, // Aptcode Solutions
        
        [Description("LSI ADL Technology")]
        LSI_ADL_Technology = 624, // LSI ADL Technology
        
        [Description("Animas Corp")]
        Animas_Corp = 625, // Animas Corp
        
        [Description("Alps Electric Co., Ltd.")]
        Alps_Electric_Co_Ltd = 626, // Alps Electric Co., Ltd.
        
        [Description("OCEASOFT")]
        OCEASOFT = 627, // OCEASOFT
        
        [Description("Motsai Research")]
        Motsai_Research = 628, // Motsai Research
        
        [Description("Geotab")]
        Geotab = 629, // Geotab
        
        [Description("E.G.O. Elektro-Ger&auml;tebau GmbH")]
        E_G_O_Elektro_GerAndauml_tebau_GmbH = 630, // E.G.O. Elektro-Ger&auml;tebau GmbH
        
        [Description("bewhere inc")]
        bewhere_inc = 631, // bewhere inc
        
        [Description("Johnson Outdoors Inc")]
        Johnson_Outdoors_Inc = 632, // Johnson Outdoors Inc
        
        [Description("steute Schaltgerate GmbH & Co. KG")]
        steute_Schaltgerate_GmbH_And_Co_KG = 633, // steute Schaltgerate GmbH & Co. KG
        
        [Description("Ekomini inc.")]
        Ekomini_inc = 634, // Ekomini inc.
        
        [Description("DEFA AS")]
        DEFA_AS = 635, // DEFA AS
        
        [Description("Aseptika Ltd")]
        Aseptika_Ltd = 636, // Aseptika Ltd
        
        [Description("HUAWEI Technologies Co., Ltd. ( 华为技术有限公司 )")]
        HUAWEI_Technologies_Co_Ltd = 637, // HUAWEI Technologies Co., Ltd. ( 华为技术有限公司 )
        
        [Description("HabitAware, LLC")]
        HabitAware_LLC = 638, // HabitAware, LLC
        
        [Description("ruwido austria gmbh")]
        ruwido_austria_gmbh = 639, // ruwido austria gmbh
        
        [Description("ITEC corporation")]
        ITEC_corporation = 640, // ITEC corporation
        
        [Description("StoneL")]
        StoneL = 641, // StoneL
        
        [Description("Sonova AG")]
        Sonova_AG = 642, // Sonova AG
        
        [Description("Maven Machines, Inc.")]
        Maven_Machines_Inc = 643, // Maven Machines, Inc.
        
        [Description("Synapse Electronics")]
        Synapse_Electronics = 644, // Synapse Electronics
        
        [Description("Standard Innovation Inc.")]
        Standard_Innovation_Inc = 645, // Standard Innovation Inc.
        
        [Description("RF Code, Inc.")]
        RF_Code_Inc = 646, // RF Code, Inc.
        
        [Description("Wally Ventures S.L.")]
        Wally_Ventures_S_L = 647, // Wally Ventures S.L.
        
        [Description("Willowbank Electronics Ltd")]
        Willowbank_Electronics_Ltd = 648, // Willowbank Electronics Ltd
        
        [Description("SK Telecom")]
        SK_Telecom = 649, // SK Telecom
        
        [Description("Jetro AS")]
        Jetro_AS = 650, // Jetro AS
        
        [Description("Code Gears LTD")]
        Code_Gears_LTD = 651, // Code Gears LTD
        
        [Description("NANOLINK APS")]
        NANOLINK_APS = 652, // NANOLINK APS
        
        [Description("IF, LLC")]
        IF_LLC = 653, // IF, LLC
        
        [Description("RF Digital Corp")]
        RF_Digital_Corp = 654, // RF Digital Corp
        
        [Description("Church & Dwight Co., Inc")]
        Church_And_Dwight_Co_Inc = 655, // Church & Dwight Co., Inc
        
        [Description("Multibit Oy")]
        Multibit_Oy = 656, // Multibit Oy
        
        [Description("CliniCloud Inc")]
        CliniCloud_Inc = 657, // CliniCloud Inc
        
        [Description("SwiftSensors")]
        SwiftSensors = 658, // SwiftSensors
        
        [Description("Blue Bite")]
        Blue_Bite = 659, // Blue Bite
        
        [Description("ELIAS GmbH")]
        ELIAS_GmbH = 660, // ELIAS GmbH
        
        [Description("Sivantos GmbH")]
        Sivantos_GmbH = 661, // Sivantos GmbH
        
        [Description("Petzl")]
        Petzl = 662, // Petzl
        
        [Description("storm power ltd")]
        storm_power_ltd = 663, // storm power ltd
        
        [Description("EISST Ltd")]
        EISST_Ltd = 664, // EISST Ltd
        
        [Description("Inexess Technology Simma KG")]
        Inexess_Technology_Simma_KG = 665, // Inexess Technology Simma KG
        
        [Description("Currant, Inc.")]
        Currant_Inc = 666, // Currant, Inc.
        
        [Description("C2 Development, Inc.")]
        C2_Development_Inc = 667, // C2 Development, Inc.
        
        [Description("Blue Sky Scientific, LLC")]
        Blue_Sky_Scientific_LLC = 668, // Blue Sky Scientific, LLC
        
        [Description("ALOTTAZS LABS, LLC")]
        ALOTTAZS_LABS_LLC = 669, // ALOTTAZS LABS, LLC
        
        [Description("Kupson spol. s r.o.")]
        Kupson_spol_s_r_o = 670, // Kupson spol. s r.o.
        
        [Description("Areus Engineering GmbH")]
        Areus_Engineering_GmbH = 671, // Areus Engineering GmbH
        
        [Description("Impossible Camera GmbH")]
        Impossible_Camera_GmbH = 672, // Impossible Camera GmbH
        
        [Description("InventureTrack Systems")]
        InventureTrack_Systems = 673, // InventureTrack Systems
        
        [Description("LockedUp")]
        LockedUp = 674, // LockedUp
        
        [Description("Itude")]
        Itude = 675, // Itude
        
        [Description("Pacific Lock Company")]
        Pacific_Lock_Company = 676, // Pacific Lock Company
        
        [Description("Tendyron Corporation ( 天地融科技股份有限公司 )")]
        Tendyron_Corporation = 677, // Tendyron Corporation ( 天地融科技股份有限公司 )
        
        [Description("Robert Bosch GmbH")]
        Robert_Bosch_GmbH = 678, // Robert Bosch GmbH
        
        [Description("Illuxtron international B.V.")]
        Illuxtron_international_B_V = 679, // Illuxtron international B.V.
        
        [Description("miSport Ltd.")]
        miSport_Ltd = 680, // miSport Ltd.
        
        [Description("Chargelib")]
        Chargelib = 681, // Chargelib
        
        [Description("Doppler Lab")]
        Doppler_Lab = 682, // Doppler Lab
        
        [Description("BBPOS Limited")]
        BBPOS_Limited = 683, // BBPOS Limited
        
        [Description("RTB Elektronik GmbH & Co. KG")]
        RTB_Elektronik_GmbH_And_Co_KG = 684, // RTB Elektronik GmbH & Co. KG
        
        [Description("Rx Networks, Inc.")]
        Rx_Networks_Inc = 685, // Rx Networks, Inc.
        
        [Description("WeatherFlow, Inc.")]
        WeatherFlow_Inc = 686, // WeatherFlow, Inc.
        
        [Description("Technicolor USA Inc.")]
        Technicolor_USA_Inc = 687, // Technicolor USA Inc.
        
        [Description("Bestechnic(Shanghai),Ltd")]
        Bestechnic_Shanghai_Ltd = 688, // Bestechnic(Shanghai),Ltd
        
        [Description("Raden Inc")]
        Raden_Inc = 689, // Raden Inc
        
        [Description("JouZen Oy")]
        JouZen_Oy = 690, // JouZen Oy
        
        [Description("CLABER S.P.A.")]
        CLABER_S_P_A = 691, // CLABER S.P.A.
        
        [Description("Hyginex, Inc.")]
        Hyginex_Inc = 692, // Hyginex, Inc.
        
        [Description("HANSHIN ELECTRIC RAILWAY CO.,LTD.")]
        HANSHIN_ELECTRIC_RAILWAY_CO_LTD = 693, // HANSHIN ELECTRIC RAILWAY CO.,LTD.
        
        [Description("Schneider Electric")]
        Schneider_Electric = 694, // Schneider Electric
        
        [Description("Oort Technologies LLC")]
        Oort_Technologies_LLC = 695, // Oort Technologies LLC
        
        [Description("Chrono Therapeutics")]
        Chrono_Therapeutics = 696, // Chrono Therapeutics
        
        [Description("Rinnai Corporation")]
        Rinnai_Corporation = 697, // Rinnai Corporation
        
        [Description("Swissprime Technologies AG")]
        Swissprime_Technologies_AG = 698, // Swissprime Technologies AG
        
        [Description("Koha.,Co.Ltd")]
        Koha_Co_Ltd = 699, // Koha.,Co.Ltd
        
        [Description("Genevac Ltd")]
        Genevac_Ltd = 700, // Genevac Ltd
        
        [Description("Chemtronics")]
        Chemtronics = 701, // Chemtronics
        
        [Description("Seguro Technology Sp. z o.o.")]
        Seguro_Technology_Sp_z_o_o = 702, // Seguro Technology Sp. z o.o.
        
        [Description("Redbird Flight Simulations")]
        Redbird_Flight_Simulations = 703, // Redbird Flight Simulations
        
        [Description("Dash Robotics")]
        Dash_Robotics = 704, // Dash Robotics
        
        [Description("LINE Corporation")]
        LINE_Corporation = 705, // LINE Corporation
        
        [Description("Guillemot Corporation")]
        Guillemot_Corporation = 706, // Guillemot Corporation
        
        [Description("Techtronic Power Tools Technology Limited")]
        Techtronic_Power_Tools_Technology_Limited = 707, // Techtronic Power Tools Technology Limited
        
        [Description("Wilson Sporting Goods")]
        Wilson_Sporting_Goods = 708, // Wilson Sporting Goods
        
        [Description("Lenovo (Singapore) Pte Ltd. ( 联想（新加坡） )")]
        Lenovo_Singapore_Pte_Ltd = 709, // Lenovo (Singapore) Pte Ltd. ( 联想（新加坡） )
        
        [Description("Ayatan Sensors")]
        Ayatan_Sensors = 710, // Ayatan Sensors
        
        [Description("Electronics Tomorrow Limited")]
        Electronics_Tomorrow_Limited = 711, // Electronics Tomorrow Limited
        
        [Description("VASCO Data Security International, Inc.")]
        VASCO_Data_Security_International_Inc = 712, // VASCO Data Security International, Inc.
        
        [Description("PayRange Inc.")]
        PayRange_Inc = 713, // PayRange Inc.
        
        [Description("ABOV Semiconductor")]
        ABOV_Semiconductor = 714, // ABOV Semiconductor
        
        [Description("AINA-Wireless Inc.")]
        AINA_Wireless_Inc = 715, // AINA-Wireless Inc.
        
        [Description("Eijkelkamp Soil & Water")]
        Eijkelkamp_Soil_And_Water = 716, // Eijkelkamp Soil & Water
        
        [Description("BMA ergonomics b.v.")]
        BMA_ergonomics_b_v = 717, // BMA ergonomics b.v.
        
        [Description("Teva Branded Pharmaceutical Products R&D, Inc.")]
        Teva_Branded_Pharmaceutical_Products_RAndD_Inc = 718, // Teva Branded Pharmaceutical Products R&D, Inc.
        
        [Description("Anima")]
        Anima = 719, // Anima
        
        [Description("3M")]
        ThreeM = 720, // 3M
        
        [Description("Empatica Srl")]
        Empatica_Srl = 721, // Empatica Srl
        
        [Description("Afero, Inc.")]
        Afero_Inc = 722, // Afero, Inc.
        
        [Description("Powercast Corporation")]
        Powercast_Corporation = 723, // Powercast Corporation
        
        [Description("Secuyou ApS")]
        Secuyou_ApS = 724, // Secuyou ApS
        
        [Description("OMRON Corporation")]
        OMRON_Corporation = 725, // OMRON Corporation
        
        [Description("Send Solutions")]
        Send_Solutions = 726, // Send Solutions
        
        [Description("NIPPON SYSTEMWARE CO.,LTD.")]
        NIPPON_SYSTEMWARE_CO_LTD = 727, // NIPPON SYSTEMWARE CO.,LTD.
        
        [Description("Neosfar")]
        Neosfar = 728, // Neosfar
        
        [Description("Fliegl Agrartechnik GmbH")]
        Fliegl_Agrartechnik_GmbH = 729, // Fliegl Agrartechnik GmbH
        
        [Description("Gilvader")]
        Gilvader = 730, // Gilvader
        
        [Description("Digi International Inc (R)")]
        Digi_International_Inc_R = 731, // Digi International Inc (R)
        
        [Description("DeWalch Technologies, Inc.")]
        DeWalch_Technologies_Inc = 732, // DeWalch Technologies, Inc.
        
        [Description("Flint Rehabilitation Devices, LLC")]
        Flint_Rehabilitation_Devices_LLC = 733, // Flint Rehabilitation Devices, LLC
        
        [Description("Samsung SDS Co., Ltd.")]
        Samsung_SDS_Co_Ltd = 734, // Samsung SDS Co., Ltd.
        
        [Description("Blur Product Development")]
        Blur_Product_Development = 735, // Blur Product Development
        
        [Description("University of Michigan")]
        University_of_Michigan = 736, // University of Michigan
        
        [Description("Victron Energy BV")]
        Victron_Energy_BV = 737, // Victron Energy BV
        
        [Description("NTT docomo")]
        NTT_docomo = 738, // NTT docomo
        
        [Description("Carmanah Technologies Corp.")]
        Carmanah_Technologies_Corp = 739, // Carmanah Technologies Corp.
        
        [Description("Bytestorm Ltd.")]
        Bytestorm_Ltd = 740, // Bytestorm Ltd.
        
        [Description("Espressif Incorporated ( 乐鑫信息科技(上海)有限公司 )")]
        Espressif_Incorporated_ = 741, // Espressif Incorporated ( 乐鑫信息科技(上海)有限公司 )
        
        [Description("Unwire")]
        Unwire = 742, // Unwire
        
        [Description("Connected Yard, Inc.")]
        Connected_Yard_Inc = 743, // Connected Yard, Inc.
        
        [Description("American Music Environments")]
        American_Music_Environments = 744, // American Music Environments
        
        [Description("Sensogram Technologies, Inc.")]
        Sensogram_Technologies_Inc = 745, // Sensogram Technologies, Inc.
        
        [Description("Fujitsu Limited")]
        Fujitsu_Limited = 746, // Fujitsu Limited
        
        [Description("Ardic Technology")]
        Ardic_Technology = 747, // Ardic Technology
        
        [Description("Delta Systems, Inc")]
        Delta_Systems_Inc = 748, // Delta Systems, Inc
        
        [Description("HTC Corporation")]
        HTC_Corporation = 749, // HTC Corporation
        
        [Description("Citizen Holdings Co., Ltd.")]
        Citizen_Holdings_Co_Ltd = 750, // Citizen Holdings Co., Ltd.
        
        [Description("SMART-INNOVATION.inc")]
        SMART_INNOVATION_inc = 751, // SMART-INNOVATION.inc
        
        [Description("Blackrat Software")]
        Blackrat_Software = 752, // Blackrat Software
        
        [Description("The Idea Cave, LLC")]
        The_Idea_Cave_LLC = 753, // The Idea Cave, LLC
        
        [Description("GoPro, Inc.")]
        GoPro_Inc = 754, // GoPro, Inc.
        
        [Description("AuthAir, Inc")]
        AuthAir_Inc = 755, // AuthAir, Inc
        
        [Description("Vensi, Inc.")]
        Vensi_Inc = 756, // Vensi, Inc.
        
        [Description("Indagem Tech LLC")]
        Indagem_Tech_LLC = 757, // Indagem Tech LLC
        
        [Description("Intemo Technologies")]
        Intemo_Technologies = 758, // Intemo Technologies
        
        [Description("DreamVisions co., Ltd.")]
        DreamVisions_co_Ltd = 759, // DreamVisions co., Ltd.
        
        [Description("Runteq Oy Ltd")]
        Runteq_Oy_Ltd = 760, // Runteq Oy Ltd
        
        [Description("IMAGINATION TECHNOLOGIES LTD")]
        IMAGINATION_TECHNOLOGIES_LTD = 761, // IMAGINATION TECHNOLOGIES LTD
        
        [Description("CoSTAR Technologies")]
        CoSTAR_Technologies = 762, // CoSTAR Technologies
        
        [Description("Clarius Mobile Health Corp.")]
        Clarius_Mobile_Health_Corp = 763, // Clarius Mobile Health Corp.
        
        [Description("Shanghai Frequen Microelectronics Co., Ltd.")]
        Shanghai_Frequen_Microelectronics_Co_Ltd = 764, // Shanghai Frequen Microelectronics Co., Ltd.
        
        [Description("Uwanna, Inc.")]
        Uwanna_Inc = 765, // Uwanna, Inc.
        
        [Description("Lierda Science & Technology Group Co., Ltd.")]
        Lierda_Science_And_Technology_Group_Co_Ltd = 766, // Lierda Science & Technology Group Co., Ltd.
        
        [Description("Silicon Laboratories")]
        Silicon_Laboratories = 767, // Silicon Laboratories
        
        [Description("World Moto Inc.")]
        World_Moto_Inc = 768, // World Moto Inc.
        
        [Description("Giatec Scientific Inc.")]
        Giatec_Scientific_Inc = 769, // Giatec Scientific Inc.
        
        [Description("Loop Devices, Inc")]
        Loop_Devices_Inc = 770, // Loop Devices, Inc
        
        [Description("IACA electronique")]
        IACA_electronique = 771, // IACA electronique
        
        [Description("Proxy Technologies, Inc")]
        Proxy_Technologies_Inc = 772, // Proxy Technologies, Inc
        
        [Description("Swipp ApS")]
        Swipp_ApS = 773, // Swipp ApS
        
        [Description("Life Laboratory Inc.")]
        Life_Laboratory_Inc = 774, // Life Laboratory Inc.
        
        [Description("FUJI INDUSTRIAL CO.,LTD.")]
        FUJI_INDUSTRIAL_CO_LTD = 775, // FUJI INDUSTRIAL CO.,LTD.
        
        [Description("Surefire, LLC")]
        Surefire_LLC = 776, // Surefire, LLC
        
        [Description("Dolby Labs")]
        Dolby_Labs = 777, // Dolby Labs
        
        [Description("Ellisys")]
        Ellisys = 778, // Ellisys
        
        [Description("Magnitude Lighting Converters")]
        Magnitude_Lighting_Converters = 779, // Magnitude Lighting Converters
        
        [Description("Hilti AG")]
        Hilti_AG = 780, // Hilti AG
        
        [Description("Devdata S.r.l.")]
        Devdata_S_r_l = 781, // Devdata S.r.l.
        
        [Description("Deviceworx")]
        Deviceworx = 782, // Deviceworx
        
        [Description("Shortcut Labs")]
        Shortcut_Labs = 783, // Shortcut Labs
        
        [Description("SGL Italia S.r.l.")]
        SGL_Italia_S_r_l = 784, // SGL Italia S.r.l.
        
        [Description("PEEQ DATA")]
        PEEQ_DATA = 785, // PEEQ DATA
        
        [Description("Ducere Technologies Pvt Ltd")]
        Ducere_Technologies_Pvt_Ltd = 786, // Ducere Technologies Pvt Ltd
        
        [Description("DiveNav, Inc.")]
        DiveNav_Inc = 787, // DiveNav, Inc.
        
        [Description("RIIG AI Sp. z o.o.")]
        RIIG_AI_Sp_z_o_o = 788, // RIIG AI Sp. z o.o.
        
        [Description("Thermo Fisher Scientific")]
        Thermo_Fisher_Scientific = 789, // Thermo Fisher Scientific
        
        [Description("AG Measurematics Pvt. Ltd.")]
        AG_Measurematics_Pvt_Ltd = 790, // AG Measurematics Pvt. Ltd.
        
        [Description("CHUO Electronics CO., LTD.")]
        CHUO_Electronics_CO_LTD = 791, // CHUO Electronics CO., LTD.
        
        [Description("Aspenta International")]
        Aspenta_International = 792, // Aspenta International
        
        [Description("Eugster Frismag AG")]
        Eugster_Frismag_AG = 793, // Eugster Frismag AG
        
        [Description("Amber wireless GmbH")]
        Amber_wireless_GmbH = 794, // Amber wireless GmbH
        
        [Description("HQ Inc")]
        HQ_Inc = 795, // HQ Inc
        
        [Description("Lab Sensor Solutions")]
        Lab_Sensor_Solutions = 796, // Lab Sensor Solutions
        
        [Description("Enterlab ApS")]
        Enterlab_ApS = 797, // Enterlab ApS
        
        [Description("Eyefi, Inc.")]
        Eyefi_Inc = 798, // Eyefi, Inc.
        
        [Description("MetaSystem S.p.A")]
        MetaSystem_S_p_A = 799, // MetaSystem S.p.A
        
        [Description("SONO ELECTRONICS. CO., LTD")]
        SONO_ELECTRONICS_CO_LTD = 800, // SONO ELECTRONICS. CO., LTD
        
        [Description("Jewelbots")]
        Jewelbots = 801, // Jewelbots
        
        [Description("Compumedics Limited")]
        Compumedics_Limited = 802, // Compumedics Limited
        
        [Description("Rotor Bike Components")]
        Rotor_Bike_Components = 803, // Rotor Bike Components
        
        [Description("Astro, Inc.")]
        Astro_Inc = 804, // Astro, Inc.
        
        [Description("Amotus Solutions")]
        Amotus_Solutions = 805, // Amotus Solutions
        
        [Description("Healthwear Technologies (Changzhou)Ltd")]
        Healthwear_Technologies_Changzhou_Ltd = 806, // Healthwear Technologies (Changzhou)Ltd
        
        [Description("Essex Electronics")]
        Essex_Electronics = 807, // Essex Electronics
        
        [Description("Grundfos A/S")]
        Grundfos_A_S = 808, // Grundfos A/S
        
        [Description("Eargo, Inc.")]
        Eargo_Inc = 809, // Eargo, Inc.
        
        [Description("Electronic Design Lab")]
        Electronic_Design_Lab = 810, // Electronic Design Lab
        
        [Description("ESYLUX")]
        ESYLUX = 811, // ESYLUX
        
        [Description("NIPPON SMT.CO.,Ltd")]
        NIPPON_SMT_CO_Ltd = 812, // NIPPON SMT.CO.,Ltd
        
        [Description("BM innovations GmbH")]
        BM_innovations_GmbH = 813, // BM innovations GmbH
        
        [Description("indoormap")]
        indoormap = 814, // indoormap
        
        [Description("OttoQ Inc")]
        OttoQ_Inc = 815, // OttoQ Inc
        
        [Description("North Pole Engineering")]
        North_Pole_Engineering = 816, // North Pole Engineering
        
        [Description("3flares Technologies Inc.")]
        ThreeFlares_Technologies_Inc = 817, // 3flares Technologies Inc.
        
        [Description("Electrocompaniet A.S.")]
        Electrocompaniet_A_S = 818, // Electrocompaniet A.S.
        
        [Description("Mul-T-Lock")]
        Mul_T_Lock = 819, // Mul-T-Lock
        
        [Description("Corentium AS")]
        Corentium_AS = 820, // Corentium AS
        
        [Description("Enlighted Inc")]
        Enlighted_Inc = 821, // Enlighted Inc
        
        [Description("GISTIC")]
        GISTIC = 822, // GISTIC
        
        [Description("AJP2 Holdings, LLC")]
        AJP2_Holdings_LLC = 823, // AJP2 Holdings, LLC
        
        [Description("COBI GmbH")]
        COBI_GmbH = 824, // COBI GmbH
        
        [Description("Blue Sky Scientific, LLC")]
        Blue_Sky_Scientific_LLC_2 = 825, // Blue Sky Scientific, LLC
        
        [Description("Appception, Inc.")]
        Appception_Inc = 826, // Appception, Inc.
        
        [Description("Courtney Thorne Limited")]
        Courtney_Thorne_Limited = 827, // Courtney Thorne Limited
        
        [Description("Virtuosys")]
        Virtuosys = 828, // Virtuosys
        
        [Description("TPV Technology Limited")]
        TPV_Technology_Limited = 829, // TPV Technology Limited
        
        [Description("Monitra SA")]
        Monitra_SA = 830, // Monitra SA
        
        [Description("Automation Components, Inc.")]
        Automation_Components_Inc = 831, // Automation Components, Inc.
        
        [Description("Letsense s.r.l.")]
        Letsense_s_r_l = 832, // Letsense s.r.l.
        
        [Description("Etesian Technologies LLC")]
        Etesian_Technologies_LLC = 833, // Etesian Technologies LLC
        
        [Description("GERTEC BRASIL LTDA.")]
        GERTEC_BRASIL_LTDA = 834, // GERTEC BRASIL LTDA.
        
        [Description("Drekker Development Pty. Ltd.")]
        Drekker_Development_Pty_Ltd = 835, // Drekker Development Pty. Ltd.
        
        [Description("Whirl Inc")]
        Whirl_Inc = 836, // Whirl Inc
        
        [Description("Locus Positioning")]
        Locus_Positioning = 837, // Locus Positioning
        
        [Description("Acuity Brands Lighting, Inc")]
        Acuity_Brands_Lighting_Inc = 838, // Acuity Brands Lighting, Inc
        
        [Description("Prevent Biometrics")]
        Prevent_Biometrics = 839, // Prevent Biometrics
        
        [Description("Arioneo")]
        Arioneo = 840, // Arioneo
        
        [Description("VersaMe")]
        VersaMe = 841, // VersaMe
        
        [Description("Vaddio")]
        Vaddio = 842, // Vaddio
        
        [Description("Libratone A/S")]
        Libratone_A_S = 843, // Libratone A/S
        
        [Description("HM Electronics, Inc.")]
        HM_Electronics_Inc = 844, // HM Electronics, Inc.
        
        [Description("TASER International, Inc.")]
        TASER_International_Inc = 845, // TASER International, Inc.
        
        [Description("Safe Trust Inc.")]
        Safe_Trust_Inc = 846, // Safe Trust Inc.
        
        [Description("Heartland Payment Systems")]
        Heartland_Payment_Systems = 847, // Heartland Payment Systems
        
        [Description("Bitstrata Systems Inc.")]
        Bitstrata_Systems_Inc = 848, // Bitstrata Systems Inc.
        
        [Description("Pieps GmbH")]
        Pieps_GmbH = 849, // Pieps GmbH
        
        [Description("iRiding(Xiamen)Technology Co.,Ltd.")]
        iRiding_Xiamen_Technology_Co_Ltd = 850, // iRiding(Xiamen)Technology Co.,Ltd.
        
        [Description("Alpha Audiotronics, Inc.")]
        Alpha_Audiotronics_Inc = 851, // Alpha Audiotronics, Inc.
        
        [Description("TOPPAN FORMS CO.,LTD.")]
        TOPPAN_FORMS_CO_LTD = 852, // TOPPAN FORMS CO.,LTD.
        
        [Description("Sigma Designs, Inc.")]
        Sigma_Designs_Inc = 853, // Sigma Designs, Inc.
        
        [Description("Spectrum Brands, Inc.")]
        Spectrum_Brands_Inc = 854, // Spectrum Brands, Inc.
        
        [Description("Polymap Wireless")]
        Polymap_Wireless = 855, // Polymap Wireless
        
        [Description("MagniWare Ltd.")]
        MagniWare_Ltd = 856, // MagniWare Ltd.
        
        [Description("Novotec Medical GmbH")]
        Novotec_Medical_GmbH = 857, // Novotec Medical GmbH
        
        [Description("Medicom Innovation Partner a/s")]
        Medicom_Innovation_Partner_a_s = 858, // Medicom Innovation Partner a/s
        
        [Description("Matrix Inc.")]
        Matrix_Inc = 859, // Matrix Inc.
        
        [Description("Eaton Corporation")]
        Eaton_Corporation = 860, // Eaton Corporation
        
        [Description("KYS")]
        KYS = 861, // KYS
        
        [Description("Naya Health, Inc.")]
        Naya_Health_Inc = 862, // Naya Health, Inc.
        
        [Description("Acromag")]
        Acromag = 863, // Acromag
        
        [Description("Insulet Corporation")]
        Insulet_Corporation = 864, // Insulet Corporation
        
        [Description("Wellinks Inc.")]
        Wellinks_Inc = 865, // Wellinks Inc.
        
        [Description("ON Semiconductor")]
        ON_Semiconductor = 866, // ON Semiconductor
        
        [Description("FREELAP SA")]
        FREELAP_SA = 867, // FREELAP SA
        
        [Description("Favero Electronics Srl")]
        Favero_Electronics_Srl = 868, // Favero Electronics Srl
        
        [Description("BioMech Sensor LLC")]
        BioMech_Sensor_LLC = 869, // BioMech Sensor LLC
        
        [Description("BOLTT Sports technologies Private limited")]
        BOLTT_Sports_technologies_Private_limited = 870, // BOLTT Sports technologies Private limited
        
        [Description("Saphe International")]
        Saphe_International = 871, // Saphe International
        
        [Description("Metormote AB")]
        Metormote_AB = 872, // Metormote AB
        
        [Description("littleBits")]
        littleBits = 873, // littleBits
        
        [Description("SetPoint Medical")]
        SetPoint_Medical = 874, // SetPoint Medical
        
        [Description("BRControls Products BV")]
        BRControls_Products_BV = 875, // BRControls Products BV
        
        [Description("Zipcar")]
        Zipcar = 876, // Zipcar
        
        [Description("AirBolt Pty Ltd")]
        AirBolt_Pty_Ltd = 877, // AirBolt Pty Ltd
        
        [Description("KeepTruckin Inc")]
        KeepTruckin_Inc = 878, // KeepTruckin Inc
        
        [Description("Motiv, Inc.")]
        Motiv_Inc = 879, // Motiv, Inc.
        
        [Description("Wazombi Labs O&Uuml;")]
        Wazombi_Labs_OAndUuml = 880, // Wazombi Labs O&Uuml;
        
        [Description("ORBCOMM")]
        ORBCOMM = 881, // ORBCOMM
        
        [Description("Nixie Labs, Inc.")]
        Nixie_Labs_Inc = 882, // Nixie Labs, Inc.
        
        [Description("AppNearMe Ltd")]
        AppNearMe_Ltd = 883, // AppNearMe Ltd
        
        [Description("Holman Industries")]
        Holman_Industries = 884, // Holman Industries
        
        [Description("Expain AS")]
        Expain_AS = 885, // Expain AS
        
        [Description("Electronic Temperature Instruments Ltd")]
        Electronic_Temperature_Instruments_Ltd = 886, // Electronic Temperature Instruments Ltd
        
        [Description("Plejd AB")]
        Plejd_AB = 887, // Plejd AB
        
        [Description("Propeller Health")]
        Propeller_Health = 888, // Propeller Health
        
        [Description("Shenzhen iMCO Electronic Technology Co.,Ltd")]
        Shenzhen_iMCO_Electronic_Technology_Co_Ltd = 889, // Shenzhen iMCO Electronic Technology Co.,Ltd
        
        [Description("Algoria")]
        Algoria = 890, // Algoria
        
        [Description("Apption Labs Inc.")]
        Apption_Labs_Inc = 891, // Apption Labs Inc.
        
        [Description("Cronologics Corporation")]
        Cronologics_Corporation = 892, // Cronologics Corporation
        
        [Description("MICRODIA Ltd.")]
        MICRODIA_Ltd = 893, // MICRODIA Ltd.
        
        [Description("lulabytes S.L.")]
        lulabytes_S_L = 894, // lulabytes S.L.
        
        [Description("Nestec S.A.")]
        Nestec_S_A = 895, // Nestec S.A.
        
        [Description("LLC \"MEGA-F service\"")]
        LLC_MEGA_F_service = 896, // LLC \"MEGA-F service\"
        
        [Description("Sharp Corporation")]
        Sharp_Corporation = 897, // Sharp Corporation
        
        [Description("Precision Outcomes Ltd")]
        Precision_Outcomes_Ltd = 898, // Precision Outcomes Ltd
        
        [Description("Kronos Incorporated")]
        Kronos_Incorporated = 899, // Kronos Incorporated
        
        [Description("OCOSMOSCo., Ltd.")]
        OCOSMOSCo_Ltd = 900, // OCOSMOSCo., Ltd.
        
        [Description("Embedded Electronic Solutions Ltd. dba e2Solutions")]
        Embedded_Electronic_Solutions_Ltd_dba_e2Solutions = 901, // Embedded Electronic Solutions Ltd. dba e2Solutions
        
        [Description("Aterica Inc.")]
        Aterica_Inc = 902, // Aterica Inc.
        
        [Description("BluStor PMC, Inc.")]
        BluStor_PMC_Inc = 903, // BluStor PMC, Inc.
        
        [Description("Kapsch TrafficCom AB")]
        Kapsch_TrafficCom_AB = 904, // Kapsch TrafficCom AB
        
        [Description("ActiveBlu Corporation")]
        ActiveBlu_Corporation = 905, // ActiveBlu Corporation
        
        [Description("Kohler Mira Limited")]
        Kohler_Mira_Limited = 906, // Kohler Mira Limited
        
        [Description("Noke")]
        Noke = 907, // Noke
        
        [Description("Appion Inc.")]
        Appion_Inc = 908, // Appion Inc.
        
        [Description("Resmed Ltd")]
        Resmed_Ltd = 909, // Resmed Ltd
        
        [Description("Crownstone B.V.")]
        Crownstone_B_V = 910, // Crownstone B.V.
        
        [Description("Xiaomi Inc.")]
        Xiaomi_Inc = 911, // Xiaomi Inc.
        
        [Description("INFOTECH s.r.o.")]
        INFOTECH_s_r_o = 912, // INFOTECH s.r.o.
        
        [Description("Thingsquare AB")]
        Thingsquare_AB = 913, // Thingsquare AB
        
        [Description("T&D")]
        TAndD = 914, // T&D
        
        [Description("LAVAZZA S.p.A.")]
        LAVAZZA_S_p_A = 915, // LAVAZZA S.p.A.
        
        [Description("Netclearance Systems, Inc.")]
        Netclearance_Systems_Inc = 916, // Netclearance Systems, Inc.
        
        [Description("SDATAWAY")]
        SDATAWAY = 917, // SDATAWAY
        
        [Description("BLOKS GmbH")]
        BLOKS_GmbH = 918, // BLOKS GmbH
        
        [Description("LEGO System A/S")]
        LEGO_System_A_S = 919, // LEGO System A/S
        
        [Description("Thetatronics Ltd")]
        Thetatronics_Ltd = 920, // Thetatronics Ltd
        
        [Description("Nikon Corporation")]
        Nikon_Corporation = 921, // Nikon Corporation
        
        [Description("NeST")]
        NeST = 922, // NeST
        
        [Description("South Silicon Valley Microelectronics")]
        South_Silicon_Valley_Microelectronics = 923, // South Silicon Valley Microelectronics
        
        [Description("ALE International")]
        ALE_International = 924, // ALE International
        
        [Description("CareView Communications, Inc.")]
        CareView_Communications_Inc = 925, // CareView Communications, Inc.
        
        [Description("SchoolBoard Limited")]
        SchoolBoard_Limited = 926, // SchoolBoard Limited
        
        [Description("Molex Corporation")]
        Molex_Corporation = 927, // Molex Corporation
        
        [Description("IVT Wireless Limited")]
        IVT_Wireless_Limited = 928, // IVT Wireless Limited
        
        [Description("Alpine Labs LLC")]
        Alpine_Labs_LLC = 929, // Alpine Labs LLC
        
        [Description("Candura Instruments")]
        Candura_Instruments = 930, // Candura Instruments
        
        [Description("SmartMovt Technology Co., Ltd")]
        SmartMovt_Technology_Co_Ltd = 931, // SmartMovt Technology Co., Ltd
        
        [Description("Token Zero Ltd")]
        Token_Zero_Ltd = 932, // Token Zero Ltd
        
        [Description("ACE CAD Enterprise Co., Ltd. (ACECAD)")]
        ACE_CAD_Enterprise_Co_Ltd_ACECAD = 933, // ACE CAD Enterprise Co., Ltd. (ACECAD)
        
        [Description("Medela, Inc")]
        Medela_Inc = 934, // Medela, Inc
        
        [Description("AeroScout")]
        AeroScout = 935, // AeroScout
        
        [Description("Esrille Inc.")]
        Esrille_Inc = 936, // Esrille Inc.
        
        [Description("THINKERLY SRL")]
        THINKERLY_SRL = 937, // THINKERLY SRL
        
        [Description("Exon Sp. z o.o.")]
        Exon_Sp_z_o_o = 938, // Exon Sp. z o.o.
        
        [Description("Meizu Technology Co., Ltd.")]
        Meizu_Technology_Co_Ltd = 939, // Meizu Technology Co., Ltd.
        
        [Description("Smablo LTD")]
        Smablo_LTD = 940, // Smablo LTD
        
        [Description("XiQ")]
        XiQ = 941, // XiQ
        
        [Description("Allswell Inc.")]
        Allswell_Inc = 942, // Allswell Inc.
        
        [Description("Comm-N-Sense Corp DBA Verigo")]
        Comm_N_Sense_Corp_DBA_Verigo = 943, // Comm-N-Sense Corp DBA Verigo
        
        [Description("VIBRADORM GmbH")]
        VIBRADORM_GmbH = 944, // VIBRADORM GmbH
        
        [Description("Otodata Wireless Network Inc.")]
        Otodata_Wireless_Network_Inc = 945, // Otodata Wireless Network Inc.
        
        [Description("Propagation Systems Limited")]
        Propagation_Systems_Limited = 946, // Propagation Systems Limited
        
        [Description("Midwest Instruments & Controls")]
        Midwest_Instruments_And_Controls = 947, // Midwest Instruments & Controls
        
        [Description("Alpha Nodus, inc.")]
        Alpha_Nodus_inc = 948, // Alpha Nodus, inc.
        
        [Description("petPOMM, Inc")]
        petPOMM_Inc = 949, // petPOMM, Inc
        
        [Description("Mattel")]
        Mattel = 950, // Mattel
        
        [Description("Airbly Inc.")]
        Airbly_Inc = 951, // Airbly Inc.
        
        [Description("A-Safe Limited")]
        A_Safe_Limited = 952, // A-Safe Limited
        
        [Description("FREDERIQUE CONSTANT SA")]
        FREDERIQUE_CONSTANT_SA = 953, // FREDERIQUE CONSTANT SA
        
        [Description("Maxscend Microelectronics Company Limited")]
        Maxscend_Microelectronics_Company_Limited = 954, // Maxscend Microelectronics Company Limited
        
        [Description("Abbott Diabetes Care")]
        Abbott_Diabetes_Care = 955, // Abbott Diabetes Care
        
        [Description("ASB Bank Ltd")]
        ASB_Bank_Ltd = 956, // ASB Bank Ltd
        
        [Description("amadas")]
        amadas = 957, // amadas
        
        [Description("Applied Science, Inc.")]
        Applied_Science_Inc = 958, // Applied Science, Inc.
        
        [Description("iLumi Solutions Inc.")]
        iLumi_Solutions_Inc = 959, // iLumi Solutions Inc.
        
        [Description("Arch Systems Inc.")]
        Arch_Systems_Inc = 960, // Arch Systems Inc.
        
        [Description("Ember Technologies, Inc.")]
        Ember_Technologies_Inc = 961, // Ember Technologies, Inc.
        
        [Description("Snapchat Inc")]
        Snapchat_Inc = 962, // Snapchat Inc
        
        [Description("Casambi Technologies Oy")]
        Casambi_Technologies_Oy = 963, // Casambi Technologies Oy
        
        [Description("Pico Technology Inc.")]
        Pico_Technology_Inc = 964, // Pico Technology Inc.
        
        [Description("St. Jude Medical, Inc.")]
        St_Jude_Medical_Inc = 965, // St. Jude Medical, Inc.
        
        [Description("Intricon")]
        Intricon = 966, // Intricon
        
        [Description("Structural Health Systems, Inc.")]
        Structural_Health_Systems_Inc = 967, // Structural Health Systems, Inc.
        
        [Description("Avvel International")]
        Avvel_International = 968, // Avvel International
        
        [Description("Gallagher Group")]
        Gallagher_Group = 969, // Gallagher Group
        
        [Description("In2things Automation Pvt. Ltd.")]
        In2things_Automation_Pvt_Ltd = 970, // In2things Automation Pvt. Ltd.
        
        [Description("SYSDEV Srl")]
        SYSDEV_Srl = 971, // SYSDEV Srl
        
        [Description("Vonkil Technologies Ltd")]
        Vonkil_Technologies_Ltd = 972, // Vonkil Technologies Ltd
        
        [Description("Wynd Technologies, Inc.")]
        Wynd_Technologies_Inc = 973, // Wynd Technologies, Inc.
        
        [Description("CONTRINEX S.A.")]
        CONTRINEX_S_A = 974, // CONTRINEX S.A.
        
        [Description("MIRA, Inc.")]
        MIRA_Inc = 975, // MIRA, Inc.
        
        [Description("Watteam Ltd")]
        Watteam_Ltd = 976, // Watteam Ltd
        
        [Description("Density Inc.")]
        Density_Inc = 977, // Density Inc.
        
        [Description("IOT Pot India Private Limited")]
        IOT_Pot_India_Private_Limited = 978, // IOT Pot India Private Limited
        
        [Description("Sigma Connectivity AB")]
        Sigma_Connectivity_AB = 979, // Sigma Connectivity AB
        
        [Description("PEG PEREGO SPA")]
        PEG_PEREGO_SPA = 980, // PEG PEREGO SPA
        
        [Description("Wyzelink Systems Inc.")]
        Wyzelink_Systems_Inc = 981, // Wyzelink Systems Inc.
        
        [Description("Yota Devices LTD")]
        Yota_Devices_LTD = 982, // Yota Devices LTD
        
        [Description("FINSECUR")]
        FINSECUR = 983, // FINSECUR
        
        [Description("Zen-Me Labs Ltd")]
        Zen_Me_Labs_Ltd = 984, // Zen-Me Labs Ltd
        
        [Description("3IWare Co., Ltd.")]
        ThreeIWare_Co_Ltd = 985, // 3IWare Co., Ltd.
        
        [Description("EnOcean GmbH")]
        EnOcean_GmbH = 986, // EnOcean GmbH
        
        [Description("Instabeat, Inc")]
        Instabeat_Inc = 987, // Instabeat, Inc
        
        [Description("Nima Labs")]
        Nima_Labs = 988, // Nima Labs
        
        [Description("Andreas Stihl AG & Co. KG")]
        Andreas_Stihl_AG_And_Co_KG = 989, // Andreas Stihl AG & Co. KG
        
        [Description("Nathan Rhoades LLC")]
        Nathan_Rhoades_LLC = 990, // Nathan Rhoades LLC
        
        [Description("Grob Technologies, LLC")]
        Grob_Technologies_LLC = 991, // Grob Technologies, LLC
        
        [Description("Actions (Zhuhai) Technology Co., Limited")]
        Actions_Zhuhai_Technology_Co_Limited = 992, // Actions (Zhuhai) Technology Co., Limited
        
        [Description("SPD Development Company Ltd")]
        SPD_Development_Company_Ltd = 993, // SPD Development Company Ltd
        
        [Description("Sensoan Oy")]
        Sensoan_Oy = 994, // Sensoan Oy
        
        [Description("Qualcomm Life Inc")]
        Qualcomm_Life_Inc = 995, // Qualcomm Life Inc
        
        [Description("Chip-ing AG")]
        Chip_ing_AG = 996, // Chip-ing AG
        
        [Description("ffly4u")]
        ffly4u = 997, // ffly4u
        
        [Description("IoT Instruments Oy")]
        IoT_Instruments_Oy = 998, // IoT Instruments Oy
        
        [Description("TRUE Fitness Technology")]
        TRUE_Fitness_Technology = 999, // TRUE Fitness Technology
        
        [Description("Reiner Kartengeraete GmbH & Co. KG.")]
        Reiner_Kartengeraete_GmbH_And_Co_KG = 1000, // Reiner Kartengeraete GmbH & Co. KG.
        
        [Description("SHENZHEN LEMONJOY TECHNOLOGY CO., LTD.")]
        SHENZHEN_LEMONJOY_TECHNOLOGY_CO_LTD = 1001, // SHENZHEN LEMONJOY TECHNOLOGY CO., LTD.
        
        [Description("Hello Inc.")]
        Hello_Inc = 1002, // Hello Inc.
        
        [Description("Evollve Inc.")]
        Evollve_Inc = 1003, // Evollve Inc.
        
        [Description("Jigowatts Inc.")]
        Jigowatts_Inc = 1004, // Jigowatts Inc.
        
        [Description("BASIC MICRO.COM,INC.")]
        BASIC_MICRO_COM_INC = 1005, // BASIC MICRO.COM,INC.
        
        [Description("CUBE TECHNOLOGIES")]
        CUBE_TECHNOLOGIES = 1006, // CUBE TECHNOLOGIES
        
        [Description("foolography GmbH")]
        foolography_GmbH = 1007, // foolography GmbH
        
        [Description("CLINK")]
        CLINK = 1008, // CLINK
        
        [Description("Hestan Smart Cooking Inc.")]
        Hestan_Smart_Cooking_Inc = 1009, // Hestan Smart Cooking Inc.
        
        [Description("WindowMaster A/S")]
        WindowMaster_A_S = 1010, // WindowMaster A/S
        
        [Description("Flowscape AB")]
        Flowscape_AB = 1011, // Flowscape AB
        
        [Description("PAL Technologies Ltd")]
        PAL_Technologies_Ltd = 1012, // PAL Technologies Ltd
        
        [Description("WHERE, Inc.")]
        WHERE_Inc = 1013, // WHERE, Inc.
        
        [Description("Iton Technology Corp.")]
        Iton_Technology_Corp = 1014, // Iton Technology Corp.
        
        [Description("Owl Labs Inc.")]
        Owl_Labs_Inc = 1015, // Owl Labs Inc.
        
        [Description("Rockford Corp.")]
        Rockford_Corp = 1016, // Rockford Corp.
        
        [Description("Becon Technologies Co.,Ltd.")]
        Becon_Technologies_Co_Ltd = 1017, // Becon Technologies Co.,Ltd.
        
        [Description("Vyassoft Technologies Inc")]
        Vyassoft_Technologies_Inc = 1018, // Vyassoft Technologies Inc
        
        [Description("Nox Medical")]
        Nox_Medical = 1019, // Nox Medical
        
        [Description("Kimberly-Clark")]
        Kimberly_Clark = 1020, // Kimberly-Clark
        
        [Description("Trimble Navigation Ltd.")]
        Trimble_Navigation_Ltd = 1021, // Trimble Navigation Ltd.
        
        [Description("Littelfuse")]
        Littelfuse = 1022, // Littelfuse
        
        [Description("Withings")]
        Withings = 1023, // Withings
        
        [Description("i-developer IT Beratung UG")]
        i_developer_IT_Beratung_UG = 1024, // i-developer IT Beratung UG
        
        [Description("No name")]
        No_name = 1025, // No name
        
        [Description("Sears Holdings Corporation")]
        Sears_Holdings_Corporation = 1026, // Sears Holdings Corporation
        
        [Description("Gantner Electronic GmbH")]
        Gantner_Electronic_GmbH = 1027, // Gantner Electronic GmbH
        
        [Description("Authomate Inc")]
        Authomate_Inc = 1028, // Authomate Inc
        
        [Description("Vertex International, Inc.")]
        Vertex_International_Inc = 1029, // Vertex International, Inc.
        
        [Description("Airtago")]
        Airtago = 1030, // Airtago
        
        [Description("Swiss Audio SA")]
        Swiss_Audio_SA = 1031, // Swiss Audio SA
        
        [Description("ToGetHome Inc.")]
        ToGetHome_Inc = 1032, // ToGetHome Inc.
        
        [Description("AXIS")]
        AXIS = 1033, // AXIS
        
        [Description("Openmatics")]
        Openmatics = 1034, // Openmatics
        
        [Description("Jana Care Inc.")]
        Jana_Care_Inc = 1035, // Jana Care Inc.
        
        [Description("Senix Corporation")]
        Senix_Corporation = 1036, // Senix Corporation
        
        [Description("NorthStar Battery Company, LLC")]
        NorthStar_Battery_Company_LLC = 1037, // NorthStar Battery Company, LLC
        
        [Description("SKF (U.K.) Limited")]
        SKF_U_K_Limited = 1038, // SKF (U.K.) Limited
        
        [Description("CO-AX Technology, Inc.")]
        CO_AX_Technology_Inc = 1039, // CO-AX Technology, Inc.
        
        [Description("Fender Musical Instruments")]
        Fender_Musical_Instruments = 1040, // Fender Musical Instruments
        
        [Description("Luidia Inc")]
        Luidia_Inc = 1041, // Luidia Inc
        
        [Description("SEFAM")]
        SEFAM = 1042, // SEFAM
        
        [Description("Wireless Cables Inc")]
        Wireless_Cables_Inc = 1043, // Wireless Cables Inc
        
        [Description("Lightning Protection International Pty Ltd")]
        Lightning_Protection_International_Pty_Ltd = 1044, // Lightning Protection International Pty Ltd
        
        [Description("Uber Technologies Inc")]
        Uber_Technologies_Inc = 1045, // Uber Technologies Inc
        
        [Description("SODA GmbH")]
        SODA_GmbH = 1046, // SODA GmbH
        
        [Description("Fatigue Science")]
        Fatigue_Science = 1047, // Fatigue Science
        
        [Description("Alpine Electronics Inc.")]
        Alpine_Electronics_Inc = 1048, // Alpine Electronics Inc.
        
        [Description("Novalogy LTD")]
        Novalogy_LTD = 1049, // Novalogy LTD
        
        [Description("Friday Labs Limited")]
        Friday_Labs_Limited = 1050, // Friday Labs Limited
        
        [Description("OrthoAccel Technologies")]
        OrthoAccel_Technologies = 1051, // OrthoAccel Technologies
        
        [Description("WaterGuru, Inc.")]
        WaterGuru_Inc = 1052, // WaterGuru, Inc.
        
        [Description("Benning Elektrotechnik und Elektronik GmbH & Co. KG")]
        Benning_Elektrotechnik_und_Elektronik_GmbH_And_Co_KG = 1053, // Benning Elektrotechnik und Elektronik GmbH & Co. KG
        
        [Description("Dell Computer Corporation")]
        Dell_Computer_Corporation = 1054, // Dell Computer Corporation
        
        [Description("Kopin Corporation")]
        Kopin_Corporation = 1055, // Kopin Corporation
        
        [Description("TecBakery GmbH")]
        TecBakery_GmbH = 1056, // TecBakery GmbH
        
        [Description("Backbone Labs, Inc.")]
        Backbone_Labs_Inc = 1057, // Backbone Labs, Inc.
        
        [Description("DELSEY SA")]
        DELSEY_SA = 1058, // DELSEY SA
        
        [Description("Chargifi Limited")]
        Chargifi_Limited = 1059, // Chargifi Limited
        
        [Description("Trainesense Ltd.")]
        Trainesense_Ltd = 1060, // Trainesense Ltd.
        
        [Description("Unify Software and Solutions GmbH & Co. KG")]
        Unify_Software_and_Solutions_GmbH_And_Co_KG = 1061, // Unify Software and Solutions GmbH & Co. KG
        
        [Description("Husqvarna AB")]
        Husqvarna_AB = 1062, // Husqvarna AB
        
        [Description("Focus fleet and fuel management inc")]
        Focus_fleet_and_fuel_management_inc = 1063, // Focus fleet and fuel management inc
        
        [Description("SmallLoop, LLC")]
        SmallLoop_LLC = 1064, // SmallLoop, LLC
        
        [Description("Prolon Inc.")]
        Prolon_Inc = 1065, // Prolon Inc.
        
        [Description("BD Medical")]
        BD_Medical = 1066, // BD Medical
        
        [Description("iMicroMed Incorporated")]
        iMicroMed_Incorporated = 1067, // iMicroMed Incorporated
        
        [Description("Ticto N.V.")]
        Ticto_N_V = 1068, // Ticto N.V.
        
        [Description("Meshtech AS")]
        Meshtech_AS = 1069, // Meshtech AS
        
        [Description("MemCachier Inc.")]
        MemCachier_Inc = 1070, // MemCachier Inc.
        
        [Description("Danfoss A/S")]
        Danfoss_A_S = 1071, // Danfoss A/S
        
        [Description("SnapStyk Inc.")]
        SnapStyk_Inc = 1072, // SnapStyk Inc.
        
        [Description("Amyway Corporation")]
        Amyway_Corporation = 1073, // Amyway Corporation
        
        [Description("Silk Labs, Inc.")]
        Silk_Labs_Inc = 1074, // Silk Labs, Inc.
        
        [Description("Pillsy Inc.")]
        Pillsy_Inc = 1075, // Pillsy Inc.
        
        [Description("Hatch Baby, Inc.")]
        Hatch_Baby_Inc = 1076, // Hatch Baby, Inc.
        
        [Description("Drayson Technologies (Europe) Limited")]
        Drayson_Technologies_Europe_Limited = 1078, // Drayson Technologies (Europe) Limited
        
        [Description("eBest IOT Inc.")]
        eBest_IOT_Inc = 1079, // eBest IOT Inc.
        
        [Description("Helvar Ltd")]
        Helvar_Ltd = 1080, // Helvar Ltd
        
        [Description("Radiance Technologies")]
        Radiance_Technologies = 1081, // Radiance Technologies
        
        [Description("Nuheara Limited")]
        Nuheara_Limited = 1082, // Nuheara Limited
        
        [Description("Appside co., ltd.")]
        Appside_co_ltd = 1083, // Appside co., ltd.
        
        [Description("DeLaval")]
        DeLaval = 1084, // DeLaval
        
        [Description("Coiler Corporation")]
        Coiler_Corporation = 1085, // Coiler Corporation
        
        [Description("Thermomedics, Inc.")]
        Thermomedics_Inc = 1086, // Thermomedics, Inc.
        
        [Description("Tentacle Sync GmbH")]
        Tentacle_Sync_GmbH = 1087, // Tentacle Sync GmbH
        
        [Description("Valencell, Inc.")]
        Valencell_Inc = 1088, // Valencell, Inc.
        
        [Description("iProtoXi Oy")]
        iProtoXi_Oy = 1089, // iProtoXi Oy
        
        [Description("SECOM CO., LTD.")]
        SECOM_CO_LTD = 1090, // SECOM CO., LTD.
        
        [Description("Tucker International LLC")]
        Tucker_International_LLC = 1091, // Tucker International LLC
        
        [Description("Metanate Limited")]
        Metanate_Limited = 1092, // Metanate Limited
        
        [Description("Kobian Canada Inc.")]
        Kobian_Canada_Inc = 1093, // Kobian Canada Inc.
        
        [Description("NETGEAR, Inc.")]
        NETGEAR_Inc = 1094, // NETGEAR, Inc.
        
        [Description("Fabtronics Australia Pty Ltd")]
        Fabtronics_Australia_Pty_Ltd = 1095, // Fabtronics Australia Pty Ltd
        
        [Description("Grand Centrix GmbH")]
        Grand_Centrix_GmbH = 1096, // Grand Centrix GmbH
        
        [Description("1UP USA.com llc")]
        OneUP_USA_com_llc = 1097, // 1UP USA.com llc
        
        [Description("SHIMANO INC.")]
        SHIMANO_INC = 1098, // SHIMANO INC.
        
        [Description("Nain Inc.")]
        Nain_Inc = 1099, // Nain Inc.
        
        [Description("LifeStyle Lock, LLC")]
        LifeStyle_Lock_LLC = 1100, // LifeStyle Lock, LLC
        
        [Description("VEGA Grieshaber KG")]
        VEGA_Grieshaber_KG = 1101, // VEGA Grieshaber KG
        
        [Description("Xtrava Inc.")]
        Xtrava_Inc = 1102, // Xtrava Inc.
        
        [Description("TTS Tooltechnic Systems AG & Co. KG")]
        TTS_Tooltechnic_Systems_AG_And_Co_KG = 1103, // TTS Tooltechnic Systems AG & Co. KG
        
        [Description("Teenage Engineering AB")]
        Teenage_Engineering_AB = 1104, // Teenage Engineering AB
        
        [Description("Tunstall Nordic AB")]
        Tunstall_Nordic_AB = 1105, // Tunstall Nordic AB
        
        [Description("Svep Design Center AB")]
        Svep_Design_Center_AB = 1106, // Svep Design Center AB
        
        [Description("GreenPeak Technologies BV")]
        GreenPeak_Technologies_BV = 1107, // GreenPeak Technologies BV
        
        [Description("Sphinx Electronics GmbH & Co KG")]
        Sphinx_Electronics_GmbH_And_Co_KG = 1108, // Sphinx Electronics GmbH & Co KG
        
        [Description("Atomation")]
        Atomation = 1109, // Atomation
        
        [Description("Nemik Consulting Inc")]
        Nemik_Consulting_Inc = 1110, // Nemik Consulting Inc
        
        [Description("RF INNOVATION")]
        RF_INNOVATION = 1111, // RF INNOVATION
        
        [Description("Mini Solution Co., Ltd.")]
        Mini_Solution_Co_Ltd = 1112, // Mini Solution Co., Ltd.
        
        [Description("Lumenetix, Inc")]
        Lumenetix_Inc = 1113, // Lumenetix, Inc
        
        [Description("2048450 Ontario Inc")]
        Ontario_Inc = 1114, // 2048450 Ontario Inc
        
        [Description("SPACEEK LTD")]
        SPACEEK_LTD = 1115, // SPACEEK LTD
        
        [Description("Delta T Corporation")]
        Delta_T_Corporation = 1116, // Delta T Corporation
        
        [Description("Boston Scientific Corporation")]
        Boston_Scientific_Corporation = 1117, // Boston Scientific Corporation
        
        [Description("Nuviz, Inc.")]
        Nuviz_Inc = 1118, // Nuviz, Inc.
        
        [Description("Real Time Automation, Inc.")]
        Real_Time_Automation_Inc = 1119, // Real Time Automation, Inc.
        
        [Description("Kolibree")]
        Kolibree = 1120, // Kolibree
        
        [Description("vhf elektronik GmbH")]
        vhf_elektronik_GmbH = 1121, // vhf elektronik GmbH
        
        [Description("Bonsai Systems GmbH")]
        Bonsai_Systems_GmbH = 1122, // Bonsai Systems GmbH
        
        [Description("Fathom Systems Inc.")]
        Fathom_Systems_Inc = 1123, // Fathom Systems Inc.
        
        [Description("Bellman & Symfon")]
        Bellman_And_Symfon = 1124, // Bellman & Symfon
        
        [Description("International Forte Group LLC")]
        International_Forte_Group_LLC = 1125, // International Forte Group LLC
        
        [Description("CycleLabs Solutions inc.")]
        CycleLabs_Solutions_inc = 1126, // CycleLabs Solutions inc.
        
        [Description("Codenex Oy")]
        Codenex_Oy = 1127, // Codenex Oy
        
        [Description("Kynesim Ltd")]
        Kynesim_Ltd = 1128, // Kynesim Ltd
        
        [Description("Palago AB")]
        Palago_AB = 1129, // Palago AB
        
        [Description("INSIGMA INC.")]
        INSIGMA_INC = 1130, // INSIGMA INC.
        
        [Description("PMD Solutions")]
        PMD_Solutions = 1131, // PMD Solutions
        
        [Description("Qingdao Realtime Technology Co., Ltd.")]
        Qingdao_Realtime_Technology_Co_Ltd = 1132, // Qingdao Realtime Technology Co., Ltd.
        
        [Description("BEGA Gantenbrink-Leuchten KG")]
        BEGA_Gantenbrink_Leuchten_KG = 1133, // BEGA Gantenbrink-Leuchten KG
        
        [Description("Pambor Ltd.")]
        Pambor_Ltd = 1134, // Pambor Ltd.
        
        [Description("Develco Products A/S")]
        Develco_Products_A_S = 1135, // Develco Products A/S
        
        [Description("iDesign s.r.l.")]
        iDesign_s_r_l = 1136, // iDesign s.r.l.
        
        [Description("TiVo Corp")]
        TiVo_Corp = 1137, // TiVo Corp
        
        [Description("Control-J Pty Ltd")]
        Control_J_Pty_Ltd = 1138, // Control-J Pty Ltd
        
        [Description("Steelcase, Inc.")]
        Steelcase_Inc = 1139, // Steelcase, Inc.
        
        [Description("iApartment co., ltd.")]
        iApartment_co_ltd = 1140, // iApartment co., ltd.
        
        [Description("Icom inc.")]
        Icom_inc = 1141, // Icom inc.
        
        [Description("Oxstren Wearable Technologies Private Limited")]
        Oxstren_Wearable_Technologies_Private_Limited = 1142, // Oxstren Wearable Technologies Private Limited
        
        [Description("Blue Spark Technologies")]
        Blue_Spark_Technologies = 1143, // Blue Spark Technologies
        
        [Description("FarSite Communications Limited")]
        FarSite_Communications_Limited = 1144, // FarSite Communications Limited
        
        [Description("mywerk system GmbH")]
        mywerk_system_GmbH = 1145, // mywerk system GmbH
        
        [Description("Sinosun Technology Co., Ltd.")]
        Sinosun_Technology_Co_Ltd = 1146, // Sinosun Technology Co., Ltd.
        
        [Description("MIYOSHI ELECTRONICS CORPORATION")]
        MIYOSHI_ELECTRONICS_CORPORATION = 1147, // MIYOSHI ELECTRONICS CORPORATION
        
        [Description("POWERMAT LTD")]
        POWERMAT_LTD = 1148, // POWERMAT LTD
        
        [Description("Occly LLC")]
        Occly_LLC = 1149, // Occly LLC
        
        [Description("OurHub Dev IvS")]
        OurHub_Dev_IvS = 1150, // OurHub Dev IvS
        
        [Description("Pro-Mark, Inc.")]
        Pro_Mark_Inc = 1151, // Pro-Mark, Inc.
        
        [Description("Dynometrics Inc.")]
        Dynometrics_Inc = 1152, // Dynometrics Inc.
        
        [Description("Quintrax Limited")]
        Quintrax_Limited = 1153, // Quintrax Limited
        
        [Description("POS Tuning Udo Vosshenrich GmbH & Co. KG")]
        POS_Tuning_Udo_Vosshenrich_GmbH_And_Co_KG = 1154, // POS Tuning Udo Vosshenrich GmbH & Co. KG
        
        [Description("Multi Care Systems B.V.")]
        Multi_Care_Systems_B_V = 1155, // Multi Care Systems B.V.
        
        [Description("Revol Technologies Inc")]
        Revol_Technologies_Inc = 1156, // Revol Technologies Inc
        
        [Description("SKIDATA AG")]
        SKIDATA_AG = 1157, // SKIDATA AG
        
        [Description("DEV TECNOLOGIA INDUSTRIA, COMERCIO E MANUTENCAO DE EQUIPAMENTOS LTDA. - ME")]
        DEV_TECNOLOGIA_INDUSTRIA_COMERCIO_E_MANUTENCAO_DE_EQUIPAMENTOS_LTDA_ME = 1158, // DEV TECNOLOGIA INDUSTRIA, COMERCIO E MANUTENCAO DE EQUIPAMENTOS LTDA. - ME
        
        [Description("Centrica Connected Home")]
        Centrica_Connected_Home = 1159, // Centrica Connected Home
        
        [Description("Automotive Data Solutions Inc")]
        Automotive_Data_Solutions_Inc = 1160, // Automotive Data Solutions Inc
        
        [Description("Igarashi Engineering")]
        Igarashi_Engineering = 1161, // Igarashi Engineering
        
        [Description("Taelek Oy")]
        Taelek_Oy = 1162, // Taelek Oy
        
        [Description("CP Electronics Limited")]
        CP_Electronics_Limited = 1163, // CP Electronics Limited
        
        [Description("Vectronix AG")]
        Vectronix_AG = 1164, // Vectronix AG
        
        [Description("S-Labs Sp. z o.o.")]
        S_Labs_Sp_z_o_o = 1165, // S-Labs Sp. z o.o.
        
        [Description("Companion Medical, Inc.")]
        Companion_Medical_Inc = 1166, // Companion Medical, Inc.
        
        [Description("BlueKitchen GmbH")]
        BlueKitchen_GmbH = 1167, // BlueKitchen GmbH
        
        [Description("Matting AB")]
        Matting_AB = 1168, // Matting AB
        
        [Description("SOREX - Wireless Solutions GmbH")]
        SOREX_Wireless_Solutions_GmbH = 1169, // SOREX - Wireless Solutions GmbH
        
        [Description("ADC Technology, Inc.")]
        ADC_Technology_Inc = 1170, // ADC Technology, Inc.
        
        [Description("Lynxemi Pte Ltd")]
        Lynxemi_Pte_Ltd = 1171, // Lynxemi Pte Ltd
        
        [Description("SENNHEISER electronic GmbH & Co. KG")]
        SENNHEISER_electronic_GmbH_And_Co_KG = 1172, // SENNHEISER electronic GmbH & Co. KG
        
        [Description("LMT Mercer Group, Inc")]
        LMT_Mercer_Group_Inc = 1173, // LMT Mercer Group, Inc
        
        [Description("Polymorphic Labs LLC")]
        Polymorphic_Labs_LLC = 1174, // Polymorphic Labs LLC
        
        [Description("Cochlear Limited")]
        Cochlear_Limited = 1175, // Cochlear Limited
        
        [Description("METER Group, Inc. USA")]
        METER_Group_Inc_USA = 1176, // METER Group, Inc. USA
        
        [Description("Ruuvi Innovations Ltd.")]
        Ruuvi_Innovations_Ltd = 1177, // Ruuvi Innovations Ltd.
        
        [Description("Situne AS")]
        Situne_AS = 1178, // Situne AS
        
        [Description("nVisti, LLC")]
        nVisti_LLC = 1179, // nVisti, LLC
        
        [Description("DyOcean")]
        DyOcean = 1180, // DyOcean
        
        [Description("Uhlmann & Zacher GmbH")]
        Uhlmann_And_Zacher_GmbH = 1181, // Uhlmann & Zacher GmbH
        
        [Description("AND!XOR LLC")]
        AND_XOR_LLC = 1182, // AND!XOR LLC
        
        [Description("tictote AB")]
        tictote_AB = 1183, // tictote AB
        
        [Description("Vypin, LLC")]
        Vypin_LLC = 1184, // Vypin, LLC
        
        [Description("PNI Sensor Corporation")]
        PNI_Sensor_Corporation = 1185, // PNI Sensor Corporation
        
        [Description("ovrEngineered, LLC")]
        ovrEngineered_LLC = 1186, // ovrEngineered, LLC
        
        [Description("GTronix")]
        GTronix = 1187, // GTronix
        
        [Description("Herbert Waldmann GmbH & Co. KG")]
        Herbert_Waldmann_GmbH_And_Co_KG = 1188, // Herbert Waldmann GmbH & Co. KG
        
        [Description("Guangzhou FiiO Electronics Technology Co.,Ltd")]
        Guangzhou_FiiO_Electronics_Technology_Co_Ltd = 1189, // Guangzhou FiiO Electronics Technology Co.,Ltd
        
        [Description("Vinetech Co., Ltd")]
        Vinetech_Co_Ltd = 1190, // Vinetech Co., Ltd
        
        [Description("Dallas Logic Corporation")]
        Dallas_Logic_Corporation = 1191, // Dallas Logic Corporation
        
        [Description("BioTex, Inc.")]
        BioTex_Inc = 1192, // BioTex, Inc.
        
        [Description("DISCOVERY SOUND TECHNOLOGY, LLC")]
        DISCOVERY_SOUND_TECHNOLOGY_LLC = 1193, // DISCOVERY SOUND TECHNOLOGY, LLC
        
        [Description("LINKIO SAS")]
        LINKIO_SAS = 1194, // LINKIO SAS
        
        [Description("Harbortronics, Inc.")]
        Harbortronics_Inc = 1195, // Harbortronics, Inc.
        
        [Description("Undagrid B.V.")]
        Undagrid_B_V = 1196, // Undagrid B.V.
        
        [Description("Shure Inc")]
        Shure_Inc = 1197, // Shure Inc
        
        [Description("ERM Electronic Systems LTD")]
        ERM_Electronic_Systems_LTD = 1198, // ERM Electronic Systems LTD
        
        [Description("BIOROWER Handelsagentur GmbH")]
        BIOROWER_Handelsagentur_GmbH = 1199, // BIOROWER Handelsagentur GmbH
        
        [Description("Weba Sport und Med. Artikel GmbH")]
        Weba_Sport_und_Med_Artikel_GmbH = 1200, // Weba Sport und Med. Artikel GmbH
        
        [Description("Kartographers Technologies Pvt. Ltd.")]
        Kartographers_Technologies_Pvt_Ltd = 1201, // Kartographers Technologies Pvt. Ltd.
        
        [Description("The Shadow on the Moon")]
        The_Shadow_on_the_Moon = 1202, // The Shadow on the Moon
        
        [Description("mobike (Hong Kong) Limited")]
        mobike_Hong_Kong_Limited = 1203, // mobike (Hong Kong) Limited
        
        [Description("Inuheat Group AB")]
        Inuheat_Group_AB = 1204, // Inuheat Group AB
        
        [Description("Swiftronix AB")]
        Swiftronix_AB = 1205, // Swiftronix AB
        
        [Description("Diagnoptics Technologies")]
        Diagnoptics_Technologies = 1206, // Diagnoptics Technologies
        
        [Description("Analog Devices, Inc.")]
        Analog_Devices_Inc = 1207, // Analog Devices, Inc.
        
        [Description("Soraa Inc.")]
        Soraa_Inc = 1208, // Soraa Inc.
        
        [Description("CSR Building Products Limited")]
        CSR_Building_Products_Limited = 1209, // CSR Building Products Limited
        
        [Description("Crestron Electronics, Inc.")]
        Crestron_Electronics_Inc = 1210, // Crestron Electronics, Inc.
        
        [Description("Neatebox Ltd")]
        Neatebox_Ltd = 1211, // Neatebox Ltd
        
        [Description("Draegerwerk AG & Co. KGaA")]
        Draegerwerk_AG_And_Co_KGaA = 1212, // Draegerwerk AG & Co. KGaA
        
        [Description("AlbynMedical")]
        AlbynMedical = 1213, // AlbynMedical
        
        [Description("Averos FZCO")]
        Averos_FZCO = 1214, // Averos FZCO
        
        [Description("VIT Initiative, LLC")]
        VIT_Initiative_LLC = 1215, // VIT Initiative, LLC
        
        [Description("Statsports International")]
        Statsports_International = 1216, // Statsports International
        
        [Description("Sospitas, s.r.o.")]
        Sospitas_s_r_o = 1217, // Sospitas, s.r.o.
        
        [Description("Dmet Products Corp.")]
        Dmet_Products_Corp = 1218, // Dmet Products Corp.
        
        [Description("Mantracourt Electronics Limited")]
        Mantracourt_Electronics_Limited = 1219, // Mantracourt Electronics Limited
        
        [Description("TeAM Hutchins AB")]
        TeAM_Hutchins_AB = 1220, // TeAM Hutchins AB
        
        [Description("Seibert Williams Glass, LLC")]
        Seibert_Williams_Glass_LLC = 1221, // Seibert Williams Glass, LLC
        
        [Description("Insta GmbH")]
        Insta_GmbH = 1222, // Insta GmbH
        
        [Description("Svantek Sp. z o.o.")]
        Svantek_Sp_z_o_o = 1223, // Svantek Sp. z o.o.
        
        [Description("Shanghai Flyco Electrical Appliance Co., Ltd.")]
        Shanghai_Flyco_Electrical_Appliance_Co_Ltd = 1224, // Shanghai Flyco Electrical Appliance Co., Ltd.
        
        [Description("Thornwave Labs Inc")]
        Thornwave_Labs_Inc = 1225, // Thornwave Labs Inc
        
        [Description("Steiner-Optik GmbH")]
        Steiner_Optik_GmbH = 1226, // Steiner-Optik GmbH
        
        [Description("Novo Nordisk A/S")]
        Novo_Nordisk_A_S = 1227, // Novo Nordisk A/S
        
        [Description("Enflux Inc.")]
        Enflux_Inc = 1228, // Enflux Inc.
        
        [Description("Safetech Products LLC")]
        Safetech_Products_LLC = 1229, // Safetech Products LLC
        
        [Description("GOOOLED S.R.L.")]
        GOOOLED_S_R_L = 1230, // GOOOLED S.R.L.
        
        [Description("DOM Sicherheitstechnik GmbH & Co. KG")]
        DOM_Sicherheitstechnik_GmbH_And_Co_KG = 1231, // DOM Sicherheitstechnik GmbH & Co. KG
        
        [Description("Olympus Corporation")]
        Olympus_Corporation = 1232, // Olympus Corporation
        
        [Description("KTS GmbH")]
        KTS_GmbH = 1233, // KTS GmbH
        
        [Description("Anloq Technologies Inc.")]
        Anloq_Technologies_Inc = 1234, // Anloq Technologies Inc.
        
        [Description("Queercon, Inc")]
        Queercon_Inc = 1235, // Queercon, Inc
        
        [Description("5th Element Ltd")]
        Fifth_Element_Ltd = 1236, // 5th Element Ltd
        
        [Description("Gooee Limited")]
        Gooee_Limited = 1237, // Gooee Limited
        
        [Description("LUGLOC LLC")]
        LUGLOC_LLC = 1238, // LUGLOC LLC
        
        [Description("Blincam, Inc.")]
        Blincam_Inc = 1239, // Blincam, Inc.
        
        [Description("FUJIFILM Corporation")]
        FUJIFILM_Corporation = 1240, // FUJIFILM Corporation
        
        [Description("RandMcNally")]
        RandMcNally = 1241, // RandMcNally
        
        [Description("Franceschi Marina snc")]
        Franceschi_Marina_snc = 1242, // Franceschi Marina snc
        
        [Description("Engineered Audio, LLC.")]
        Engineered_Audio_LLC = 1243, // Engineered Audio, LLC.
        
        [Description("IOTTIVE (OPC) PRIVATE LIMITED")]
        IOTTIVE_OPC_PRIVATE_LIMITED = 1244, // IOTTIVE (OPC) PRIVATE LIMITED
        
        [Description("4MOD Technology")]
        FourMOD_Technology = 1245, // 4MOD Technology
        
        [Description("Lutron Electronics Co., Inc.")]
        Lutron_Electronics_Co_Inc = 1246, // Lutron Electronics Co., Inc.
        
        [Description("Emerson")]
        Emerson = 1247, // Emerson
        
        [Description("Guardtec, Inc.")]
        Guardtec_Inc = 1248, // Guardtec, Inc.
        
        [Description("REACTEC LIMITED")]
        REACTEC_LIMITED = 1249, // REACTEC LIMITED
        
        [Description("EllieGrid")]
        EllieGrid = 1250, // EllieGrid
        
        [Description("Under Armour")]
        Under_Armour = 1251, // Under Armour
        
        [Description("Woodenshark")]
        Woodenshark = 1252, // Woodenshark
        
        [Description("Avack Oy")]
        Avack_Oy = 1253, // Avack Oy
        
        [Description("Smart Solution Technology, Inc.")]
        Smart_Solution_Technology_Inc = 1254, // Smart Solution Technology, Inc.
        
        [Description("REHABTRONICS INC.")]
        REHABTRONICS_INC = 1255, // REHABTRONICS INC.
        
        [Description("STABILO International")]
        STABILO_International = 1256, // STABILO International
        
        [Description("Busch Jaeger Elektro GmbH")]
        Busch_Jaeger_Elektro_GmbH = 1257, // Busch Jaeger Elektro GmbH
        
        [Description("Pacific Bioscience Laboratories, Inc")]
        Pacific_Bioscience_Laboratories_Inc = 1258, // Pacific Bioscience Laboratories, Inc
        
        [Description("Bird Home Automation GmbH")]
        Bird_Home_Automation_GmbH = 1259, // Bird Home Automation GmbH
        
        [Description("Motorola Solutions")]
        Motorola_Solutions = 1260, // Motorola Solutions
        
        [Description("R9 Technology, Inc.")]
        R9_Technology_Inc = 1261, // R9 Technology, Inc.
        
        [Description("Auxivia")]
        Auxivia = 1262, // Auxivia
        
        [Description("DaisyWorks, Inc")]
        DaisyWorks_Inc = 1263, // DaisyWorks, Inc
        
        [Description("Kosi Limited")]
        Kosi_Limited = 1264, // Kosi Limited
        
        [Description("Theben AG")]
        Theben_AG = 1265, // Theben AG
        
        [Description("InDreamer Techsol Private Limited")]
        InDreamer_Techsol_Private_Limited = 1266, // InDreamer Techsol Private Limited
        
        [Description("Cerevast Medical")]
        Cerevast_Medical = 1267, // Cerevast Medical
        
        [Description("ZanCompute Inc.")]
        ZanCompute_Inc = 1268, // ZanCompute Inc.
        
        [Description("Pirelli Tyre S.P.A.")]
        Pirelli_Tyre_S_P_A = 1269, // Pirelli Tyre S.P.A.
        
        [Description("McLear Limited")]
        McLear_Limited = 1270, // McLear Limited
        
        [Description("Shenzhen Huiding Technology Co.,Ltd.")]
        Shenzhen_Huiding_Technology_Co_Ltd = 1271, // Shenzhen Huiding Technology Co.,Ltd.
        
        [Description("Convergence Systems Limited")]
        Convergence_Systems_Limited = 1272, // Convergence Systems Limited
        
        [Description("Interactio")]
        Interactio = 1273, // Interactio
        
        [Description("Androtec GmbH")]
        Androtec_GmbH = 1274, // Androtec GmbH
        
        [Description("Benchmark Drives GmbH & Co. KG")]
        Benchmark_Drives_GmbH_And_Co_KG = 1275, // Benchmark Drives GmbH & Co. KG
        
        [Description("SwingLync L. L. C.")]
        SwingLync_L_L_C = 1276, // SwingLync L. L. C.
        
        [Description("Tapkey GmbH")]
        Tapkey_GmbH = 1277, // Tapkey GmbH
        
        [Description("Woosim Systems Inc.")]
        Woosim_Systems_Inc = 1278, // Woosim Systems Inc.
        
        [Description("Microsemi Corporation")]
        Microsemi_Corporation = 1279, // Microsemi Corporation
        
        [Description("Wiliot LTD.")]
        Wiliot_LTD = 1280, // Wiliot LTD.
        
        [Description("Polaris IND")]
        Polaris_IND = 1281, // Polaris IND
        
        [Description("Specifi-Kali LLC")]
        Specifi_Kali_LLC = 1282, // Specifi-Kali LLC
        
        [Description("Locoroll, Inc")]
        Locoroll_Inc = 1283, // Locoroll, Inc
        
        [Description("PHYPLUS Inc")]
        PHYPLUS_Inc = 1284, // PHYPLUS Inc
        
        [Description("Inplay Technologies LLC")]
        Inplay_Technologies_LLC = 1285, // Inplay Technologies LLC
        
        [Description("Hager")]
        Hager = 1286, // Hager
        
        [Description("Yellowcog")]
        Yellowcog = 1287, // Yellowcog
        
        [Description("Axes System sp. z o. o.")]
        Axes_System_sp_z_o_o = 1288, // Axes System sp. z o. o.
        
        [Description("myLIFTER Inc.")]
        myLIFTER_Inc = 1289, // myLIFTER Inc.
        
        [Description("Shake-on B.V.")]
        Shake_on_B_V = 1290, // Shake-on B.V.
        
        [Description("Vibrissa Inc.")]
        Vibrissa_Inc = 1291, // Vibrissa Inc.
        
        [Description("OSRAM GmbH")]
        OSRAM_GmbH = 1292, // OSRAM GmbH
        
        [Description("TRSystems GmbH")]
        TRSystems_GmbH = 1293, // TRSystems GmbH
        
        [Description("Yichip Microelectronics (Hangzhou) Co.,Ltd.")]
        Yichip_Microelectronics_Hangzhou_Co_Ltd = 1294, // Yichip Microelectronics (Hangzhou) Co.,Ltd.
        
        [Description("Foundation Engineering LLC")]
        Foundation_Engineering_LLC = 1295, // Foundation Engineering LLC
        
        [Description("UNI-ELECTRONICS, INC.")]
        UNI_ELECTRONICS_INC = 1296, // UNI-ELECTRONICS, INC.
        
        [Description("Brookfield Equinox LLC")]
        Brookfield_Equinox_LLC = 1297, // Brookfield Equinox LLC
        
        [Description("Soprod SA")]
        Soprod_SA = 1298, // Soprod SA
        
        [Description("9974091 Canada Inc.")]
        Canada_Inc = 1299, // 9974091 Canada Inc.
        
        [Description("FIBRO GmbH")]
        FIBRO_GmbH = 1300, // FIBRO GmbH
        
        [Description("RB Controls Co., Ltd.")]
        RB_Controls_Co_Ltd = 1301, // RB Controls Co., Ltd.
        
        [Description("Footmarks")]
        Footmarks = 1302, // Footmarks
        
        [Description("Amcore AB")]
        Amcore_AB = 1303, // Amcore AB
        
        [Description("MAMORIO.inc")]
        MAMORIO_inc = 1304, // MAMORIO.inc
        
        [Description("Tyto Life LLC")]
        Tyto_Life_LLC = 1305, // Tyto Life LLC
        
        [Description("Leica Camera AG")]
        Leica_Camera_AG = 1306, // Leica Camera AG
        
        [Description("Angee Technologies Ltd.")]
        Angee_Technologies_Ltd = 1307, // Angee Technologies Ltd.
        
        [Description("EDPS")]
        EDPS = 1308, // EDPS
        
        [Description("OFF Line Co., Ltd.")]
        OFF_Line_Co_Ltd = 1309, // OFF Line Co., Ltd.
        
        [Description("Detect Blue Limited")]
        Detect_Blue_Limited = 1310, // Detect Blue Limited
        
        [Description("Setec Pty Ltd")]
        Setec_Pty_Ltd = 1311, // Setec Pty Ltd
        
        [Description("Target Corporation")]
        Target_Corporation = 1312, // Target Corporation
        
        [Description("IAI Corporation")]
        IAI_Corporation = 1313, // IAI Corporation
        
        [Description("NS Tech, Inc.")]
        NS_Tech_Inc = 1314, // NS Tech, Inc.
        
        [Description("MTG Co., Ltd.")]
        MTG_Co_Ltd = 1315, // MTG Co., Ltd.
        
        [Description("Hangzhou iMagic Technology Co., Ltd")]
        Hangzhou_iMagic_Technology_Co_Ltd = 1316, // Hangzhou iMagic Technology Co., Ltd
        
        [Description("HONGKONG NANO IC TECHNOLOGIES CO., LIMITED")]
        HONGKONG_NANO_IC_TECHNOLOGIES_CO_LIMITED = 1317, // HONGKONG NANO IC TECHNOLOGIES CO., LIMITED
        
        [Description("Honeywell International Inc.")]
        Honeywell_International_Inc = 1318, // Honeywell International Inc.
        
        [Description("Albrecht JUNG")]
        Albrecht_JUNG = 1319, // Albrecht JUNG
        
        [Description("Lunera Lighting Inc.")]
        Lunera_Lighting_Inc = 1320, // Lunera Lighting Inc.
        
        [Description("Lumen UAB")]
        Lumen_UAB = 1321, // Lumen UAB
        
        [Description("Keynes Controls Ltd")]
        Keynes_Controls_Ltd = 1322, // Keynes Controls Ltd
        
        [Description("Novartis AG")]
        Novartis_AG = 1323, // Novartis AG
        
        [Description("Geosatis SA")]
        Geosatis_SA = 1324, // Geosatis SA
        
        [Description("EXFO, Inc.")]
        EXFO_Inc = 1325, // EXFO, Inc.
        
        [Description("LEDVANCE GmbH")]
        LEDVANCE_GmbH = 1326, // LEDVANCE GmbH
        
        [Description("Center ID Corp.")]
        Center_ID_Corp = 1327, // Center ID Corp.
        
        [Description("Adolene, Inc.")]
        Adolene_Inc = 1328, // Adolene, Inc.
        
        [Description("D&M Holdings Inc.")]
        DAndM_Holdings_Inc = 1329, // D&M Holdings Inc.
        
        [Description("CRESCO Wireless, Inc.")]
        CRESCO_Wireless_Inc = 1330, // CRESCO Wireless, Inc.
        
        [Description("Nura Operations Pty Ltd")]
        Nura_Operations_Pty_Ltd = 1331, // Nura Operations Pty Ltd
        
        [Description("Frontiergadget, Inc.")]
        Frontiergadget_Inc = 1332, // Frontiergadget, Inc.
        
        [Description("Smart Component Technologies Limited")]
        Smart_Component_Technologies_Limited = 1333, // Smart Component Technologies Limited
        
        [Description("ZTR Control Systems LLC")]
        ZTR_Control_Systems_LLC = 1334, // ZTR Control Systems LLC
        
        [Description("MetaLogics Corporation")]
        MetaLogics_Corporation = 1335, // MetaLogics Corporation
        
        [Description("Medela AG")]
        Medela_AG = 1336, // Medela AG
        
        [Description("OPPLE Lighting Co., Ltd")]
        OPPLE_Lighting_Co_Ltd = 1337, // OPPLE Lighting Co., Ltd
        
        [Description("Savitech Corp.,")]
        Savitech_Corp = 1338, // Savitech Corp.,
        
        [Description("prodigy")]
        prodigy = 1339, // prodigy
        
        [Description("Screenovate Technologies Ltd")]
        Screenovate_Technologies_Ltd = 1340, // Screenovate Technologies Ltd
        
        [Description("TESA SA")]
        TESA_SA = 1341, // TESA SA
        
        [Description("CLIM8 LIMITED")]
        CLIM8_LIMITED = 1342, // CLIM8 LIMITED
        
        [Description("Silergy Corp")]
        Silergy_Corp = 1343, // Silergy Corp
        
        [Description("SilverPlus, Inc")]
        SilverPlus_Inc = 1344, // SilverPlus, Inc
        
        [Description("Sharknet srl")]
        Sharknet_srl = 1345, // Sharknet srl
        
        [Description("Mist Systems, Inc.")]
        Mist_Systems_Inc = 1346, // Mist Systems, Inc.
        
        [Description("MIWA LOCK CO.,Ltd")]
        MIWA_LOCK_CO_Ltd = 1347, // MIWA LOCK CO.,Ltd
        
        [Description("OrthoSensor, Inc.")]
        OrthoSensor_Inc = 1348, // OrthoSensor, Inc.
        
        [Description("Candy Hoover Group s.r.l")]
        Candy_Hoover_Group_s_r_l = 1349, // Candy Hoover Group s.r.l
        
        [Description("Apexar Technologies S.A.")]
        Apexar_Technologies_S_A = 1350, // Apexar Technologies S.A.
        
        [Description("LOGICDATA d.o.o.")]
        LOGICDATA_d_o_o = 1351, // LOGICDATA d.o.o.
        
        [Description("Knick Elektronische Messgeraete GmbH & Co. KG")]
        Knick_Elektronische_Messgeraete_GmbH_And_Co_KG = 1352, // Knick Elektronische Messgeraete GmbH & Co. KG
        
        [Description("Smart Technologies and Investment Limited")]
        Smart_Technologies_and_Investment_Limited = 1353, // Smart Technologies and Investment Limited
        
        [Description("Linough Inc.")]
        Linough_Inc = 1354, // Linough Inc.
        
        [Description("Advanced Electronic Designs, Inc.")]
        Advanced_Electronic_Designs_Inc = 1355, // Advanced Electronic Designs, Inc.
        
        [Description("Carefree Scott Fetzer Co Inc")]
        Carefree_Scott_Fetzer_Co_Inc = 1356, // Carefree Scott Fetzer Co Inc
        
        [Description("Sensome")]
        Sensome = 1357, // Sensome
        
        [Description("FORTRONIK storitve d.o.o.")]
        FORTRONIK_storitve_d_o_o = 1358, // FORTRONIK storitve d.o.o.
        
        [Description("Sinnoz")]
        Sinnoz = 1359, // Sinnoz
        
        [Description("Versa Networks, Inc.")]
        Versa_Networks_Inc = 1360, // Versa Networks, Inc.
        
        [Description("Sylero")]
        Sylero = 1361, // Sylero
        
        [Description("Avempace SARL")]
        Avempace_SARL = 1362, // Avempace SARL
        
        [Description("Nintendo Co., Ltd.")]
        Nintendo_Co_Ltd = 1363, // Nintendo Co., Ltd.
        
        [Description("National Instruments")]
        National_Instruments = 1364, // National Instruments
        
        [Description("KROHNE Messtechnik GmbH")]
        KROHNE_Messtechnik_GmbH = 1365, // KROHNE Messtechnik GmbH
        
        [Description("Otodynamics Ltd")]
        Otodynamics_Ltd = 1366, // Otodynamics Ltd
        
        [Description("Arwin Technology Limited")]
        Arwin_Technology_Limited = 1367, // Arwin Technology Limited
        
        [Description("benegear, inc.")]
        benegear_inc = 1368, // benegear, inc.
        
        [Description("Newcon Optik")]
        Newcon_Optik = 1369, // Newcon Optik
        
        [Description("CANDY HOUSE, Inc.")]
        CANDY_HOUSE_Inc = 1370, // CANDY HOUSE, Inc.
        
        [Description("FRANKLIN TECHNOLOGY INC")]
        FRANKLIN_TECHNOLOGY_INC = 1371, // FRANKLIN TECHNOLOGY INC
        
        [Description("Lely")]
        Lely = 1372, // Lely
        
        [Description("Valve Corporation")]
        Valve_Corporation = 1373, // Valve Corporation
        
        [Description("Hekatron Vertriebs GmbH")]
        Hekatron_Vertriebs_GmbH = 1374, // Hekatron Vertriebs GmbH
        
        [Description("PROTECH S.A.S. DI GIRARDI ANDREA & C.")]
        PROTECH_S_A_S_DI_GIRARDI_ANDREA_And_C = 1375, // PROTECH S.A.S. DI GIRARDI ANDREA & C.
        
        [Description("Sarita CareTech IVS")]
        Sarita_CareTech_IVS = 1376, // Sarita CareTech IVS
        
        [Description("Finder S.p.A.")]
        Finder_S_p_A = 1377, // Finder S.p.A.
        
        [Description("Thalmic Labs Inc.")]
        Thalmic_Labs_Inc = 1378, // Thalmic Labs Inc.
        
        [Description("Steinel Vertrieb GmbH")]
        Steinel_Vertrieb_GmbH = 1379, // Steinel Vertrieb GmbH
        
        [Description("Beghelli Spa")]
        Beghelli_Spa = 1380, // Beghelli Spa
        
        [Description("Beijing Smartspace Technologies Inc.")]
        Beijing_Smartspace_Technologies_Inc = 1381, // Beijing Smartspace Technologies Inc.
        
        [Description("CORE TRANSPORT TECHNOLOGIES NZ LIMITED")]
        CORE_TRANSPORT_TECHNOLOGIES_NZ_LIMITED = 1382, // CORE TRANSPORT TECHNOLOGIES NZ LIMITED
        
        [Description("Xiamen Everesports Goods Co., Ltd")]
        Xiamen_Everesports_Goods_Co_Ltd = 1383, // Xiamen Everesports Goods Co., Ltd
        
        [Description("Bodyport Inc.")]
        Bodyport_Inc = 1384, // Bodyport Inc.
        
        [Description("Audionics System, INC.")]
        Audionics_System_INC = 1385, // Audionics System, INC.
        
        [Description("Flipnavi Co.,Ltd.")]
        Flipnavi_Co_Ltd = 1386, // Flipnavi Co.,Ltd.
        
        [Description("Rion Co., Ltd.")]
        Rion_Co_Ltd = 1387, // Rion Co., Ltd.
        
        [Description("Long Range Systems, LLC")]
        Long_Range_Systems_LLC = 1388, // Long Range Systems, LLC
        
        [Description("Redmond Industrial Group LLC")]
        Redmond_Industrial_Group_LLC = 1389, // Redmond Industrial Group LLC
        
        [Description("VIZPIN INC.")]
        VIZPIN_INC = 1390, // VIZPIN INC.
        
        [Description("BikeFinder AS")]
        BikeFinder_AS = 1391, // BikeFinder AS
        
        [Description("Consumer Sleep Solutions LLC")]
        Consumer_Sleep_Solutions_LLC = 1392, // Consumer Sleep Solutions LLC
        
        [Description("PSIKICK, INC.")]
        PSIKICK_INC = 1393, // PSIKICK, INC.
        
        [Description("AntTail.com")]
        AntTail_com = 1394, // AntTail.com
        
        [Description("Lighting Science Group Corp.")]
        Lighting_Science_Group_Corp = 1395, // Lighting Science Group Corp.
        
        [Description("AFFORDABLE ELECTRONICS INC")]
        AFFORDABLE_ELECTRONICS_INC = 1396, // AFFORDABLE ELECTRONICS INC
        
        [Description("Integral Memroy Plc")]
        Integral_Memroy_Plc = 1397, // Integral Memroy Plc
        
        [Description("Globalstar, Inc.")]
        Globalstar_Inc = 1398, // Globalstar, Inc.
        
        [Description("True Wearables, Inc.")]
        True_Wearables_Inc = 1399, // True Wearables, Inc.
        
        [Description("Wellington Drive Technologies Ltd")]
        Wellington_Drive_Technologies_Ltd = 1400, // Wellington Drive Technologies Ltd
        
        [Description("Ensemble Tech Private Limited")]
        Ensemble_Tech_Private_Limited = 1401, // Ensemble Tech Private Limited
        
        [Description("OMNI Remotes")]
        OMNI_Remotes = 1402, // OMNI Remotes
        
        [Description("Duracell U.S. Operations Inc.")]
        Duracell_U_S_Operations_Inc = 1403, // Duracell U.S. Operations Inc.
        
        [Description("Toor Technologies LLC")]
        Toor_Technologies_LLC = 1404, // Toor Technologies LLC
        
        [Description("Instinct Performance")]
        Instinct_Performance = 1405, // Instinct Performance
        
        [Description("Beco, Inc")]
        Beco_Inc = 1406, // Beco, Inc
        
        [Description("Scuf Gaming International, LLC")]
        Scuf_Gaming_International_LLC = 1407, // Scuf Gaming International, LLC
        
        [Description("ARANZ Medical Limited")]
        ARANZ_Medical_Limited = 1408, // ARANZ Medical Limited
        
        [Description("LYS TECHNOLOGIES LTD")]
        LYS_TECHNOLOGIES_LTD = 1409, // LYS TECHNOLOGIES LTD
        
        [Description("Breakwall Analytics, LLC")]
        Breakwall_Analytics_LLC = 1410, // Breakwall Analytics, LLC
        
        [Description("Code Blue Communications")]
        Code_Blue_Communications = 1411, // Code Blue Communications
        
        [Description("Gira Giersiepen GmbH & Co. KG")]
        Gira_Giersiepen_GmbH_And_Co_KG = 1412, // Gira Giersiepen GmbH & Co. KG
        
        [Description("Hearing Lab Technology")]
        Hearing_Lab_Technology = 1413, // Hearing Lab Technology
        
        [Description("LEGRAND")]
        LEGRAND = 1414, // LEGRAND
        
        [Description("Derichs GmbH")]
        Derichs_GmbH = 1415, // Derichs GmbH
        
        [Description("ALT-TEKNIK LLC")]
        ALT_TEKNIK_LLC = 1416, // ALT-TEKNIK LLC
        
        [Description("Star Technologies")]
        Star_Technologies = 1417, // Star Technologies
        
        [Description("START TODAY CO.,LTD.")]
        START_TODAY_CO_LTD = 1418, // START TODAY CO.,LTD.
        
        [Description("Maxim Integrated Products")]
        Maxim_Integrated_Products = 1419, // Maxim Integrated Products
        
        [Description("MERCK Kommanditgesellschaft auf Aktien")]
        MERCK_Kommanditgesellschaft_auf_Aktien = 1420, // MERCK Kommanditgesellschaft auf Aktien
        
        [Description("Jungheinrich Aktiengesellschaft")]
        Jungheinrich_Aktiengesellschaft = 1421, // Jungheinrich Aktiengesellschaft
        
        [Description("Oculus VR, LLC")]
        Oculus_VR_LLC = 1422, // Oculus VR, LLC
        
        [Description("HENDON SEMICONDUCTORS PTY LTD")]
        HENDON_SEMICONDUCTORS_PTY_LTD = 1423, // HENDON SEMICONDUCTORS PTY LTD
        
        [Description("Pur3 Ltd")]
        Pur3_Ltd = 1424, // Pur3 Ltd
        
        [Description("Viasat Group S.p.A.")]
        Viasat_Group_S_p_A = 1425, // Viasat Group S.p.A.
        
        [Description("IZITHERM")]
        IZITHERM = 1426, // IZITHERM
        
        [Description("Spaulding Clinical Research")]
        Spaulding_Clinical_Research = 1427, // Spaulding Clinical Research
        
        [Description("Kohler Company")]
        Kohler_Company = 1428, // Kohler Company
        
        [Description("Inor Process AB")]
        Inor_Process_AB = 1429, // Inor Process AB
        
        [Description("My Smart Blinds")]
        My_Smart_Blinds = 1430, // My Smart Blinds
        
        [Description("RadioPulse Inc")]
        RadioPulse_Inc = 1431, // RadioPulse Inc
        
        [Description("rapitag GmbH")]
        rapitag_GmbH = 1432, // rapitag GmbH
        
        [Description("Lazlo326, LLC.")]
        Lazlo326_LLC = 1433, // Lazlo326, LLC.
        
        [Description("Teledyne Lecroy, Inc.")]
        Teledyne_Lecroy_Inc = 1434, // Teledyne Lecroy, Inc.
        
        [Description("Dataflow Systems Limited")]
        Dataflow_Systems_Limited = 1435, // Dataflow Systems Limited
        
        [Description("Macrogiga Electronics")]
        Macrogiga_Electronics = 1436, // Macrogiga Electronics
        
        [Description("Tandem Diabetes Care")]
        Tandem_Diabetes_Care = 1437, // Tandem Diabetes Care
        
        [Description("Polycom, Inc.")]
        Polycom_Inc = 1438, // Polycom, Inc.
        
        [Description("Fisher & Paykel Healthcare")]
        Fisher_And_Paykel_Healthcare = 1439, // Fisher & Paykel Healthcare
        
        [Description("RCP Software Oy")]
        RCP_Software_Oy = 1440, // RCP Software Oy
        
        [Description("Shanghai Xiaoyi Technology Co.,Ltd.")]
        Shanghai_Xiaoyi_Technology_Co_Ltd = 1441, // Shanghai Xiaoyi Technology Co.,Ltd.
        
        [Description("ADHERIUM(NZ) LIMITED")]
        ADHERIUM_NZ_LIMITED = 1442, // ADHERIUM(NZ) LIMITED
        
        [Description("Axiomware Systems Incorporated")]
        Axiomware_Systems_Incorporated = 1443, // Axiomware Systems Incorporated
        
        [Description("O. E. M. Controls, Inc.")]
        O_E_M_Controls_Inc = 1444, // O. E. M. Controls, Inc.
        
        [Description("Kiiroo BV")]
        Kiiroo_BV = 1445, // Kiiroo BV
        
        [Description("Telecon Mobile Limited")]
        Telecon_Mobile_Limited = 1446, // Telecon Mobile Limited
        
        [Description("Sonos Inc")]
        Sonos_Inc = 1447, // Sonos Inc
        
        [Description("Tom Allebrandi Consulting")]
        Tom_Allebrandi_Consulting = 1448, // Tom Allebrandi Consulting
        
        [Description("Monidor")]
        Monidor = 1449, // Monidor
        
        [Description("Tramex Limited")]
        Tramex_Limited = 1450, // Tramex Limited
        
        [Description("Nofence AS")]
        Nofence_AS = 1451, // Nofence AS
        
        [Description("GoerTek Dynaudio Co., Ltd.")]
        GoerTek_Dynaudio_Co_Ltd = 1452, // GoerTek Dynaudio Co., Ltd.
        
        [Description("INIA")]
        INIA = 1453, // INIA
        
        [Description("CARMATE MFG.CO.,LTD")]
        CARMATE_MFG_CO_LTD = 1454, // CARMATE MFG.CO.,LTD
        
        [Description("ONvocal")]
        ONvocal = 1455, // ONvocal
        
        [Description("NewTec GmbH")]
        NewTec_GmbH = 1456, // NewTec GmbH
        
        [Description("Medallion Instrumentation Systems")]
        Medallion_Instrumentation_Systems = 1457, // Medallion Instrumentation Systems
        
        [Description("CAREL INDUSTRIES S.P.A.")]
        CAREL_INDUSTRIES_S_P_A = 1458, // CAREL INDUSTRIES S.P.A.
        
        [Description("Parabit Systems, Inc.")]
        Parabit_Systems_Inc = 1459, // Parabit Systems, Inc.
        
        [Description("White Horse Scientific ltd")]
        White_Horse_Scientific_ltd = 1460, // White Horse Scientific ltd
        
        [Description("verisilicon")]
        verisilicon = 1461, // verisilicon
        
        [Description("Elecs Industry Co.,Ltd.")]
        Elecs_Industry_Co_Ltd = 1462, // Elecs Industry Co.,Ltd.
        
        [Description("Beijing Pinecone Electronics Co.,Ltd.")]
        Beijing_Pinecone_Electronics_Co_Ltd = 1463, // Beijing Pinecone Electronics Co.,Ltd.
        
        [Description("Ambystoma Labs Inc.")]
        Ambystoma_Labs_Inc = 1464, // Ambystoma Labs Inc.
        
        [Description("Suzhou Pairlink Network Technology")]
        Suzhou_Pairlink_Network_Technology = 1465, // Suzhou Pairlink Network Technology
        
        [Description("igloohome")]
        igloohome = 1466, // igloohome
        
        [Description("Oxford Metrics plc")]
        Oxford_Metrics_plc = 1467, // Oxford Metrics plc
        
        [Description("Leviton Mfg. Co., Inc.")]
        Leviton_Mfg_Co_Inc = 1468, // Leviton Mfg. Co., Inc.
        
        [Description("ULC Robotics Inc.")]
        ULC_Robotics_Inc = 1469, // ULC Robotics Inc.
        
        [Description("RFID Global by Softwork SrL")]
        RFID_Global_by_Softwork_SrL = 1470, // RFID Global by Softwork SrL
        
        [Description("Real-World-Systems Corporation")]
        Real_World_Systems_Corporation = 1471, // Real-World-Systems Corporation
        
        [Description("Nalu Medical, Inc.")]
        Nalu_Medical_Inc = 1472, // Nalu Medical, Inc.
        
        [Description("P.I.Engineering")]
        P_I_Engineering = 1473, // P.I.Engineering
        
        [Description("Grote Industries")]
        Grote_Industries = 1474, // Grote Industries
        
        [Description("Runtime, Inc.")]
        Runtime_Inc = 1475, // Runtime, Inc.
        
        [Description("Codecoup sp. z o.o. sp. k.")]
        Codecoup_sp_z_o_o_sp_k = 1476, // Codecoup sp. z o.o. sp. k.
        
        [Description("SELVE GmbH & Co. KG")]
        SELVE_GmbH_And_Co_KG = 1477, // SELVE GmbH & Co. KG
        
        [Description("Smart Animal Training Systems, LLC")]
        Smart_Animal_Training_Systems_LLC = 1478, // Smart Animal Training Systems, LLC
        
        [Description("Lippert Components, INC")]
        Lippert_Components_INC = 1479, // Lippert Components, INC
        
        [Description("SOMFY SAS")]
        SOMFY_SAS = 1480, // SOMFY SAS
        
        [Description("TBS Electronics B.V.")]
        TBS_Electronics_B_V = 1481, // TBS Electronics B.V.
        
        [Description("MHL Custom Inc")]
        MHL_Custom_Inc = 1482, // MHL Custom Inc
        
        [Description("LucentWear LLC")]
        LucentWear_LLC = 1483, // LucentWear LLC
        
        [Description("WATTS ELECTRONICS")]
        WATTS_ELECTRONICS = 1484, // WATTS ELECTRONICS
        
        [Description("RJ Brands LLC")]
        RJ_Brands_LLC = 1485, // RJ Brands LLC
        
        [Description("V-ZUG Ltd")]
        V_ZUG_Ltd = 1486, // V-ZUG Ltd
        
        [Description("Biowatch SA")]
        Biowatch_SA = 1487, // Biowatch SA
        
        [Description("Anova Applied Electronics")]
        Anova_Applied_Electronics = 1488, // Anova Applied Electronics
        
        [Description("Lindab AB")]
        Lindab_AB = 1489, // Lindab AB
        
        [Description("frogblue TECHNOLOGY GmbH")]
        frogblue_TECHNOLOGY_GmbH = 1490, // frogblue TECHNOLOGY GmbH
        
        [Description("Acurable Limited")]
        Acurable_Limited = 1491, // Acurable Limited
        
        [Description("LAMPLIGHT Co., Ltd.")]
        LAMPLIGHT_Co_Ltd = 1492, // LAMPLIGHT Co., Ltd.
        
        [Description("TEGAM, Inc.")]
        TEGAM_Inc = 1493, // TEGAM, Inc.
        
        [Description("Zhuhai Jieli technology Co.,Ltd")]
        Zhuhai_Jieli_technology_Co_Ltd = 1494, // Zhuhai Jieli technology Co.,Ltd
        
        [Description("modum.io AG")]
        modum_io_AG = 1495, // modum.io AG
        
        [Description("Farm Jenny LLC")]
        Farm_Jenny_LLC = 1496, // Farm Jenny LLC
        
        [Description("Toyo Electronics Corporation")]
        Toyo_Electronics_Corporation = 1497, // Toyo Electronics Corporation
        
        [Description("Applied Neural Research Corp")]
        Applied_Neural_Research_Corp = 1498, // Applied Neural Research Corp
        
        [Description("Avid Identification Systems, Inc.")]
        Avid_Identification_Systems_Inc = 1499, // Avid Identification Systems, Inc.
        
        [Description("Petronics Inc.")]
        Petronics_Inc = 1500, // Petronics Inc.
        
        [Description("essentim GmbH")]
        essentim_GmbH = 1501, // essentim GmbH
        
        [Description("QT Medical INC.")]
        QT_Medical_INC = 1502, // QT Medical INC.
        
        [Description("VIRTUALCLINIC.DIRECT LIMITED")]
        VIRTUALCLINIC_DIRECT_LIMITED = 1503, // VIRTUALCLINIC.DIRECT LIMITED
        
        [Description("Viper Design LLC")]
        Viper_Design_LLC = 1504, // Viper Design LLC
        
        [Description("Human, Incorporated")]
        Human_Incorporated = 1505, // Human, Incorporated
        
        [Description("stAPPtronics GmbH")]
        stAPPtronics_GmbH = 1506, // stAPPtronics GmbH
        
        [Description("Elemental Machines, Inc.")]
        Elemental_Machines_Inc = 1507, // Elemental Machines, Inc.
        
        [Description("Taiyo Yuden Co., Ltd")]
        Taiyo_Yuden_Co_Ltd = 1508, // Taiyo Yuden Co., Ltd
        
        [Description("INEO ENERGY& SYSTEMS")]
        INEO_ENERGYAnd_SYSTEMS = 1509, // INEO ENERGY& SYSTEMS
        
        [Description("Motion Instruments Inc.")]
        Motion_Instruments_Inc = 1510, // Motion Instruments Inc.
        
        [Description("PressurePro")]
        PressurePro = 1511, // PressurePro
        
        [Description("COWBOY")]
        COWBOY = 1512, // COWBOY
        
        [Description("iconmobile GmbH")]
        iconmobile_GmbH = 1513, // iconmobile GmbH
        
        [Description("ACS-Control-System GmbH")]
        ACS_Control_System_GmbH = 1514, // ACS-Control-System GmbH
        
        [Description("Bayerische Motoren Werke AG")]
        Bayerische_Motoren_Werke_AG = 1515, // Bayerische Motoren Werke AG
        
        [Description("Gycom Svenska AB")]
        Gycom_Svenska_AB = 1516, // Gycom Svenska AB
        
        [Description("Fuji Xerox Co., Ltd")]
        Fuji_Xerox_Co_Ltd = 1517, // Fuji Xerox Co., Ltd
        
        [Description("Glide Inc.")]
        Glide_Inc = 1518, // Glide Inc.
        
        [Description("SIKOM AS")]
        SIKOM_AS = 1519, // SIKOM AS
        
        [Description("beken")]
        beken = 1520, // beken
        
        [Description("The Linux Foundation")]
        The_Linux_Foundation = 1521, // The Linux Foundation
        
        [Description("Try and E CO.,LTD.")]
        Try_and_E_CO_LTD = 1522, // Try and E CO.,LTD.
        
        [Description("SeeScan")]
        SeeScan = 1523, // SeeScan
        
        [Description("Clearity, LLC")]
        Clearity_LLC = 1524, // Clearity, LLC
        
        [Description("GS TAG")]
        GS_TAG = 1525, // GS TAG
        
        [Description("DPTechnics")]
        DPTechnics = 1526, // DPTechnics
        
        [Description("TRACMO, INC.")]
        TRACMO_INC = 1527, // TRACMO, INC.
        
        [Description("Anki Inc.")]
        Anki_Inc = 1528, // Anki Inc.
        
        [Description("Hagleitner Hygiene International GmbH")]
        Hagleitner_Hygiene_International_GmbH = 1529, // Hagleitner Hygiene International GmbH
        
        [Description("Konami Sports Life Co., Ltd.")]
        Konami_Sports_Life_Co_Ltd = 1530, // Konami Sports Life Co., Ltd.
        
        [Description("Arblet Inc.")]
        Arblet_Inc = 1531, // Arblet Inc.
        
        [Description("Masbando GmbH")]
        Masbando_GmbH = 1532, // Masbando GmbH
        
        [Description("Innoseis")]
        Innoseis = 1533, // Innoseis
        
        [Description("Niko")]
        Niko = 1534, // Niko
        
        [Description("Wellnomics Ltd")]
        Wellnomics_Ltd = 1535, // Wellnomics Ltd
        
        [Description("iRobot Corporation")]
        iRobot_Corporation = 1536, // iRobot Corporation
        
        [Description("Schrader Electronics")]
        Schrader_Electronics = 1537, // Schrader Electronics
        
        [Description("Geberit International AG")]
        Geberit_International_AG = 1538, // Geberit International AG
        
        [Description("Fourth Evolution Inc")]
        Fourth_Evolution_Inc = 1539, // Fourth Evolution Inc
        
        [Description("Cell2Jack LLC")]
        Cell2Jack_LLC = 1540, // Cell2Jack LLC
        
        [Description("FMW electronic Futterer u. Maier-Wolf OHG")]
        FMW_electronic_Futterer_u_Maier_Wolf_OHG = 1541, // FMW electronic Futterer u. Maier-Wolf OHG
        
        [Description("John Deere")]
        John_Deere = 1542, // John Deere
        
        [Description("Rookery Technology Ltd")]
        Rookery_Technology_Ltd = 1543, // Rookery Technology Ltd
        
        [Description("KeySafe-Cloud")]
        KeySafe_Cloud = 1544, // KeySafe-Cloud
        
        [Description("BUCHI Labortechnik AG")]
        BUCHI_Labortechnik_AG = 1545, // BUCHI Labortechnik AG
        
        [Description("IQAir AG")]
        IQAir_AG = 1546, // IQAir AG
        
        [Description("Triax Technologies Inc")]
        Triax_Technologies_Inc = 1547, // Triax Technologies Inc
        
        [Description("Vuzix Corporation")]
        Vuzix_Corporation = 1548, // Vuzix Corporation
        
        [Description("TDK Corporation")]
        TDK_Corporation = 1549, // TDK Corporation
        
        [Description("Blueair AB")]
        Blueair_AB = 1550, // Blueair AB
        
        [Description("Signify Netherlands")]
        Signify_Netherlands = 1551, // Signify Netherlands
        
        [Description("ADH GUARDIAN USA LLC")]
        ADH_GUARDIAN_USA_LLC = 1552, // ADH GUARDIAN USA LLC
        
        [Description("Beurer GmbH")]
        Beurer_GmbH = 1553, // Beurer GmbH
        
        [Description("Playfinity AS")]
        Playfinity_AS = 1554, // Playfinity AS
        
        [Description("Hans Dinslage GmbH")]
        Hans_Dinslage_GmbH = 1555, // Hans Dinslage GmbH
        
        [Description("OnAsset Intelligence, Inc.")]
        OnAsset_Intelligence_Inc = 1556, // OnAsset Intelligence, Inc.
        
        [Description("INTER ACTION Corporation")]
        INTER_ACTION_Corporation = 1557, // INTER ACTION Corporation
        
        [Description("OS42 UG (haftungsbeschraenkt)")]
        OS42_UG_haftungsbeschraenkt = 1558, // OS42 UG (haftungsbeschraenkt)
        
        [Description("WIZCONNECTED COMPANY LIMITED")]
        WIZCONNECTED_COMPANY_LIMITED = 1559, // WIZCONNECTED COMPANY LIMITED
        
        [Description("Audio-Technica Corporation")]
        Audio_Technica_Corporation = 1560, // Audio-Technica Corporation
        
        [Description("Six Guys Labs, s.r.o.")]
        Six_Guys_Labs_s_r_o = 1561, // Six Guys Labs, s.r.o.
        
        [Description("R.W. Beckett Corporation")]
        R_W_Beckett_Corporation = 1562, // R.W. Beckett Corporation
        
        [Description("silex technology, inc.")]
        silex_technology_inc = 1563, // silex technology, inc.
        
        [Description("Univations Limited")]
        Univations_Limited = 1564, // Univations Limited
        
        [Description("SENS Innovation ApS")]
        SENS_Innovation_ApS = 1565, // SENS Innovation ApS
        
        [Description("Diamond Kinetics, Inc.")]
        Diamond_Kinetics_Inc = 1566, // Diamond Kinetics, Inc.
        
        [Description("Phrame Inc.")]
        Phrame_Inc = 1567, // Phrame Inc.
        
        [Description("Forciot Oy")]
        Forciot_Oy = 1568, // Forciot Oy
        
        [Description("Noordung d.o.o.")]
        Noordung_d_o_o = 1569, // Noordung d.o.o.
        
        [Description("Beam Labs, LLC")]
        Beam_Labs_LLC = 1570, // Beam Labs, LLC
        
        [Description("Philadelphia Scientific (U.K.) Limited")]
        Philadelphia_Scientific_U_K_Limited = 1571, // Philadelphia Scientific (U.K.) Limited
        
        [Description("Biovotion AG")]
        Biovotion_AG = 1572, // Biovotion AG
        
        [Description("Square Panda, Inc.")]
        Square_Panda_Inc = 1573, // Square Panda, Inc.
        
        [Description("Amplifico")]
        Amplifico = 1574, // Amplifico
        
        [Description("WEG S.A.")]
        WEG_S_A = 1575, // WEG S.A.
        
        [Description("Ensto Oy")]
        Ensto_Oy = 1576, // Ensto Oy
        
        [Description("PHONEPE PVT LTD")]
        PHONEPE_PVT_LTD = 1577, // PHONEPE PVT LTD
        
        [Description("Lunatico Astronomia SL")]
        Lunatico_Astronomia_SL = 1578, // Lunatico Astronomia SL
        
        [Description("MinebeaMitsumi Inc.")]
        MinebeaMitsumi_Inc = 1579, // MinebeaMitsumi Inc.
        
        [Description("ASPion GmbH")]
        ASPion_GmbH = 1580, // ASPion GmbH
        
        [Description("Vossloh-Schwabe Deutschland GmbH")]
        Vossloh_Schwabe_Deutschland_GmbH = 1581, // Vossloh-Schwabe Deutschland GmbH
        
        [Description("Procept")]
        Procept = 1582, // Procept
        
        [Description("ONKYO Corporation")]
        ONKYO_Corporation = 1583, // ONKYO Corporation
        
        [Description("Asthrea D.O.O.")]
        Asthrea_D_O_O = 1584, // Asthrea D.O.O.
        
        [Description("Fortiori Design LLC")]
        Fortiori_Design_LLC = 1585, // Fortiori Design LLC
        
        [Description("Hugo Muller GmbH & Co KG")]
        Hugo_Muller_GmbH_And_Co_KG = 1586, // Hugo Muller GmbH & Co KG
        
        [Description("Wangi Lai PLT")]
        Wangi_Lai_PLT = 1587, // Wangi Lai PLT
        
        [Description("Fanstel Corp")]
        Fanstel_Corp = 1588, // Fanstel Corp
        
        [Description("Crookwood")]
        Crookwood = 1589, // Crookwood
        
        [Description("ELECTRONICA INTEGRAL DE SONIDO S.A.")]
        ELECTRONICA_INTEGRAL_DE_SONIDO_S_A = 1590, // ELECTRONICA INTEGRAL DE SONIDO S.A.
        
        [Description("GiP Innovation Tools GmbH")]
        GiP_Innovation_Tools_GmbH = 1591, // GiP Innovation Tools GmbH
        
        [Description("LX SOLUTIONS PTY LIMITED")]
        LX_SOLUTIONS_PTY_LIMITED = 1592, // LX SOLUTIONS PTY LIMITED
        
        [Description("Shenzhen Minew Technologies Co., Ltd.")]
        Shenzhen_Minew_Technologies_Co_Ltd = 1593, // Shenzhen Minew Technologies Co., Ltd.
        
        [Description("Prolojik Limited")]
        Prolojik_Limited = 1594, // Prolojik Limited
        
        [Description("Kromek Group Plc")]
        Kromek_Group_Plc = 1595, // Kromek Group Plc
        
        [Description("Contec Medical Systems Co., Ltd.")]
        Contec_Medical_Systems_Co_Ltd = 1596, // Contec Medical Systems Co., Ltd.
        
        [Description("Xradio Technology Co.,Ltd.")]
        Xradio_Technology_Co_Ltd = 1597, // Xradio Technology Co.,Ltd.
        
        [Description("The Indoor Lab, LLC")]
        The_Indoor_Lab_LLC = 1598, // The Indoor Lab, LLC
        
        [Description("LDL TECHNOLOGY")]
        LDL_TECHNOLOGY = 1599, // LDL TECHNOLOGY
        
        [Description("Parkifi")]
        Parkifi = 1600, // Parkifi
        
        [Description("Revenue Collection Systems FRANCE SAS")]
        Revenue_Collection_Systems_FRANCE_SAS = 1601, // Revenue Collection Systems FRANCE SAS
        
        [Description("Bluetrum Technology Co.,Ltd")]
        Bluetrum_Technology_Co_Ltd = 1602, // Bluetrum Technology Co.,Ltd
        
        [Description("makita corporation")]
        makita_corporation = 1603, // makita corporation
        
        [Description("Apogee Instruments")]
        Apogee_Instruments = 1604, // Apogee Instruments
        
        [Description("BM3")]
        BM3 = 1605, // BM3
        
        [Description("SGV Group Holding GmbH & Co. KG")]
        SGV_Group_Holding_GmbH_And_Co_KG = 1606, // SGV Group Holding GmbH & Co. KG
        
        [Description("MED-EL")]
        MED_EL = 1607, // MED-EL
        
        [Description("Ultune Technologies")]
        Ultune_Technologies = 1608, // Ultune Technologies
        
        [Description("Ryeex Technology Co.,Ltd.")]
        Ryeex_Technology_Co_Ltd = 1609, // Ryeex Technology Co.,Ltd.
        
        [Description("Open Research Institute, Inc.")]
        Open_Research_Institute_Inc = 1610, // Open Research Institute, Inc.
        
        [Description("Scale-Tec, Ltd")]
        Scale_Tec_Ltd = 1611, // Scale-Tec, Ltd
        
        [Description("Zumtobel Group AG")]
        Zumtobel_Group_AG = 1612, // Zumtobel Group AG
        
        [Description("iLOQ Oy")]
        iLOQ_Oy = 1613, // iLOQ Oy
        
        [Description("KRUXWorks Technologies Private Limited")]
        KRUXWorks_Technologies_Private_Limited = 1614, // KRUXWorks Technologies Private Limited
        
        [Description("Digital Matter Pty Ltd")]
        Digital_Matter_Pty_Ltd = 1615, // Digital Matter Pty Ltd
        
        [Description("Coravin, Inc.")]
        Coravin_Inc = 1616, // Coravin, Inc.
        
        [Description("Stasis Labs, Inc.")]
        Stasis_Labs_Inc = 1617, // Stasis Labs, Inc.
        
        [Description("ITZ Innovations- und Technologiezentrum GmbH")]
        ITZ_Innovations_und_Technologiezentrum_GmbH = 1618, // ITZ Innovations- und Technologiezentrum GmbH
        
        [Description("Meggitt SA")]
        Meggitt_SA = 1619, // Meggitt SA
        
        [Description("Ledlenser GmbH & Co. KG")]
        Ledlenser_GmbH_And_Co_KG = 1620, // Ledlenser GmbH & Co. KG
        
        [Description("Renishaw PLC")]
        Renishaw_PLC = 1621, // Renishaw PLC
        
        [Description("ZhuHai AdvanPro Technology Company Limited")]
        ZhuHai_AdvanPro_Technology_Company_Limited = 1622, // ZhuHai AdvanPro Technology Company Limited
        
        [Description("Meshtronix Limited")]
        Meshtronix_Limited = 1623, // Meshtronix Limited
        
        [Description("Payex Norge AS")]
        Payex_Norge_AS = 1624, // Payex Norge AS
        
        [Description("UnSeen Technologies Oy")]
        UnSeen_Technologies_Oy = 1625, // UnSeen Technologies Oy
        
        [Description("Zound Industries International AB")]
        Zound_Industries_International_AB = 1626, // Zound Industries International AB
        
        [Description("Sesam Solutions BV")]
        Sesam_Solutions_BV = 1627, // Sesam Solutions BV
        
        [Description("PixArt Imaging Inc.")]
        PixArt_Imaging_Inc = 1628, // PixArt Imaging Inc.
        
        [Description("Panduit Corp.")]
        Panduit_Corp = 1629, // Panduit Corp.
        
        [Description("Alo AB")]
        Alo_AB = 1630, // Alo AB
        
        [Description("Ricoh Company Ltd")]
        Ricoh_Company_Ltd = 1631, // Ricoh Company Ltd
        
        [Description("RTC Industries, Inc.")]
        RTC_Industries_Inc = 1632, // RTC Industries, Inc.
        
        [Description("Mode Lighting Limited")]
        Mode_Lighting_Limited = 1633, // Mode Lighting Limited
        
        [Description("Particle Industries, Inc.")]
        Particle_Industries_Inc = 1634, // Particle Industries, Inc.
        
        [Description("Advanced Telemetry Systems, Inc.")]
        Advanced_Telemetry_Systems_Inc = 1635, // Advanced Telemetry Systems, Inc.
        
        [Description("RHA TECHNOLOGIES LTD")]
        RHA_TECHNOLOGIES_LTD = 1636, // RHA TECHNOLOGIES LTD
        
        [Description("Pure International Limited")]
        Pure_International_Limited = 1637, // Pure International Limited
        
        [Description("WTO Werkzeug-Einrichtungen GmbH")]
        WTO_Werkzeug_Einrichtungen_GmbH = 1638, // WTO Werkzeug-Einrichtungen GmbH
        
        [Description("Spark Technology Labs Inc.")]
        Spark_Technology_Labs_Inc = 1639, // Spark Technology Labs Inc.
        
        [Description("Bleb Technology srl")]
        Bleb_Technology_srl = 1640, // Bleb Technology srl
        
        [Description("Livanova USA, Inc.")]
        Livanova_USA_Inc = 1641, // Livanova USA, Inc.
        
        [Description("Brady Worldwide Inc.")]
        Brady_Worldwide_Inc = 1642, // Brady Worldwide Inc.
        
        [Description("DewertOkin GmbH")]
        DewertOkin_GmbH = 1643, // DewertOkin GmbH
        
        [Description("Ztove ApS")]
        Ztove_ApS = 1644, // Ztove ApS
        
        [Description("Venso EcoSolutions AB")]
        Venso_EcoSolutions_AB = 1645, // Venso EcoSolutions AB
        
        [Description("Eurotronik Kranj d.o.o.")]
        Eurotronik_Kranj_d_o_o = 1646, // Eurotronik Kranj d.o.o.
        
        [Description("Hug Technology Ltd")]
        Hug_Technology_Ltd = 1647, // Hug Technology Ltd
        
        [Description("Gema Switzerland GmbH")]
        Gema_Switzerland_GmbH = 1648, // Gema Switzerland GmbH
        
        [Description("Buzz Products Ltd.")]
        Buzz_Products_Ltd = 1649, // Buzz Products Ltd.
        
        [Description("Kopi")]
        Kopi = 1650, // Kopi
        
        [Description("Innova Ideas Limited")]
        Innova_Ideas_Limited = 1651, // Innova Ideas Limited
        
        [Description("BeSpoon")]
        BeSpoon = 1652, // BeSpoon
        
        [Description("Deco Enterprises, Inc.")]
        Deco_Enterprises_Inc = 1653, // Deco Enterprises, Inc.
        
        [Description("Expai Solutions Private Limited")]
        Expai_Solutions_Private_Limited = 1654, // Expai Solutions Private Limited
        
        [Description("Innovation First, Inc.")]
        Innovation_First_Inc = 1655, // Innovation First, Inc.
        
        [Description("SABIK Offshore GmbH")]
        SABIK_Offshore_GmbH = 1656, // SABIK Offshore GmbH
        
        [Description("4iiii Innovations Inc.")]
        Four_iiii_Innovations_Inc = 1657, // 4iiii Innovations Inc.
        
        [Description("The Energy Conservatory, Inc.")]
        The_Energy_Conservatory_Inc = 1658, // The Energy Conservatory, Inc.
        
        [Description("I.FARM, INC.")]
        I_FARM_INC = 1659, // I.FARM, INC.
        
        [Description("Tile, Inc.")]
        Tile_Inc = 1660, // Tile, Inc.
        
        [Description("Form Athletica Inc.")]
        Form_Athletica_Inc = 1661, // Form Athletica Inc.
        
        [Description("MbientLab Inc")]
        MbientLab_Inc = 1662, // MbientLab Inc
        
        [Description("NETGRID S.N.C. DI BISSOLI MATTEO, CAMPOREALE SIMONE, TOGNETTI FEDERICO")]
        NETGRID_S_N_C_DI_BISSOLI_MATTEO_CAMPOREALE_SIMONE_TOGNETTI_FEDERICO = 1663, // NETGRID S.N.C. DI BISSOLI MATTEO, CAMPOREALE SIMONE, TOGNETTI FEDERICO
        
        [Description("Mannkind Corporation")]
        Mannkind_Corporation = 1664, // Mannkind Corporation
        
        [Description("Trade FIDES a.s.")]
        Trade_FIDES_a_s = 1665, // Trade FIDES a.s.
        
        [Description("Photron Limited")]
        Photron_Limited = 1666, // Photron Limited
        
        [Description("Eltako GmbH")]
        Eltako_GmbH = 1667, // Eltako GmbH
        
        [Description("Dermalapps, LLC")]
        Dermalapps_LLC = 1668, // Dermalapps, LLC
        
        [Description("Greenwald Industries")]
        Greenwald_Industries = 1669, // Greenwald Industries
        
        [Description("inQs Co., Ltd.")]
        inQs_Co_Ltd = 1670, // inQs Co., Ltd.
        
        [Description("Cherry GmbH")]
        Cherry_GmbH = 1671, // Cherry GmbH
        
        [Description("Amsted Digital Solutions Inc.")]
        Amsted_Digital_Solutions_Inc = 1672, // Amsted Digital Solutions Inc.
        
        [Description("Tacx b.v.")]
        Tacx_b_v = 1673, // Tacx b.v.
        
        [Description("Raytac Corporation")]
        Raytac_Corporation = 1674, // Raytac Corporation
        
        [Description("Jiangsu Teranovo Tech Co., Ltd.")]
        Jiangsu_Teranovo_Tech_Co_Ltd = 1675, // Jiangsu Teranovo Tech Co., Ltd.
        
        [Description("Changzhou Sound Dragon Electronics and Acoustics Co., Ltd")]
        Changzhou_Sound_Dragon_Electronics_and_Acoustics_Co_Ltd = 1676, // Changzhou Sound Dragon Electronics and Acoustics Co., Ltd
        
        [Description("JetBeep Inc.")]
        JetBeep_Inc = 1677, // JetBeep Inc.
        
        [Description("Razer Inc.")]
        Razer_Inc = 1678, // Razer Inc.
        
        [Description("JRM Group Limited")]
        JRM_Group_Limited = 1679, // JRM Group Limited
        
        [Description("Eccrine Systems, Inc.")]
        Eccrine_Systems_Inc = 1680, // Eccrine Systems, Inc.
        
        [Description("Curie Point AB")]
        Curie_Point_AB = 1681, // Curie Point AB
        
        [Description("Georg Fischer AG")]
        Georg_Fischer_AG = 1682, // Georg Fischer AG
        
        [Description("Hach - Danaher")]
        Hach_Danaher = 1683, // Hach - Danaher
        
        [Description("T&A Laboratories LLC")]
        TAndA_Laboratories_LLC = 1684, // T&A Laboratories LLC
        
        [Description("Koki Holdings Co., Ltd.")]
        Koki_Holdings_Co_Ltd = 1685, // Koki Holdings Co., Ltd.
        
        [Description("Gunakar Private Limited")]
        Gunakar_Private_Limited = 1686, // Gunakar Private Limited
        
        [Description("Stemco Products Inc")]
        Stemco_Products_Inc = 1687, // Stemco Products Inc
        
        [Description("Wood IT Security, LLC")]
        Wood_IT_Security_LLC = 1688, // Wood IT Security, LLC
        
        [Description("RandomLab SAS")]
        RandomLab_SAS = 1689, // RandomLab SAS
        
        [Description("TrackR, Inc.")]
        TrackR_Inc = 1690, // TrackR, Inc.
        
        [Description("Dragonchip Limited")]
        Dragonchip_Limited = 1691, // Dragonchip Limited
        
        [Description("Noomi AB")]
        Noomi_AB = 1692, // Noomi AB
        
        [Description("Vakaros LLC")]
        Vakaros_LLC = 1693, // Vakaros LLC
        
        [Description("Delta Electronics, Inc.")]
        Delta_Electronics_Inc = 1694, // Delta Electronics, Inc.
        
        [Description("FlowMotion Technologies AS")]
        FlowMotion_Technologies_AS = 1695, // FlowMotion Technologies AS
        
        [Description("OBIQ Location Technology Inc.")]
        OBIQ_Location_Technology_Inc = 1696, // OBIQ Location Technology Inc.
        
        [Description("Cardo Systems, Ltd")]
        Cardo_Systems_Ltd = 1697, // Cardo Systems, Ltd
        
        [Description("Globalworx GmbH")]
        Globalworx_GmbH = 1698, // Globalworx GmbH
        
        [Description("Nymbus, LLC")]
        Nymbus_LLC = 1699, // Nymbus, LLC
        
        [Description("Sanyo Techno Solutions Tottori Co., Ltd.")]
        Sanyo_Techno_Solutions_Tottori_Co_Ltd = 1700, // Sanyo Techno Solutions Tottori Co., Ltd.
        
        [Description("TEKZITEL PTY LTD")]
        TEKZITEL_PTY_LTD = 1701, // TEKZITEL PTY LTD
        
        [Description("Roambee Corporation")]
        Roambee_Corporation = 1702, // Roambee Corporation
        
        [Description("Chipsea Technologies (ShenZhen) Corp.")]
        Chipsea_Technologies_ShenZhen_Corp = 1703, // Chipsea Technologies (ShenZhen) Corp.
        
        [Description("GD Midea Air-Conditioning Equipment Co., Ltd.")]
        GD_Midea_Air_Conditioning_Equipment_Co_Ltd = 1704, // GD Midea Air-Conditioning Equipment Co., Ltd.
        
        [Description("Soundmax Electronics Limited")]
        Soundmax_Electronics_Limited = 1705, // Soundmax Electronics Limited
        
        [Description("Produal Oy")]
        Produal_Oy = 1706, // Produal Oy
        
        [Description("HMS Industrial Networks AB")]
        HMS_Industrial_Networks_AB = 1707, // HMS Industrial Networks AB
        
        [Description("Ingchips Technology Co., Ltd.")]
        Ingchips_Technology_Co_Ltd = 1708, // Ingchips Technology Co., Ltd.
        
        [Description("InnovaSea Systems Inc.")]
        InnovaSea_Systems_Inc = 1709, // InnovaSea Systems Inc.
        
        [Description("SenseQ Inc.")]
        SenseQ_Inc = 1710, // SenseQ Inc.
        
        [Description("Shoof Technologies")]
        Shoof_Technologies = 1711, // Shoof Technologies
        
        [Description("BRK Brands, Inc.")]
        BRK_Brands_Inc = 1712, // BRK Brands, Inc.
        
        [Description("SimpliSafe, Inc.")]
        SimpliSafe_Inc = 1713, // SimpliSafe, Inc.
        
        [Description("Tussock Innovation 2013 Limited")]
        Tussock_Innovation_2013_Limited = 1714, // Tussock Innovation 2013 Limited
        
        [Description("The Hablab ApS")]
        The_Hablab_ApS = 1715, // The Hablab ApS
        
        [Description("Sencilion Oy")]
        Sencilion_Oy = 1716, // Sencilion Oy
        
        [Description("Wabilogic Ltd.")]
        Wabilogic_Ltd = 1717, // Wabilogic Ltd.
        
        [Description("Sociometric Solutions, Inc.")]
        Sociometric_Solutions_Inc = 1718, // Sociometric Solutions, Inc.
        
        [Description("iCOGNIZE GmbH")]
        iCOGNIZE_GmbH = 1719, // iCOGNIZE GmbH
        
        [Description("ShadeCraft, Inc")]
        ShadeCraft_Inc = 1720, // ShadeCraft, Inc
        
        [Description("Beflex Inc.")]
        Beflex_Inc = 1721, // Beflex Inc.
        
        [Description("Beaconzone Ltd")]
        Beaconzone_Ltd = 1722, // Beaconzone Ltd
        
        [Description("Leaftronix Analogic Solutions Private Limited")]
        Leaftronix_Analogic_Solutions_Private_Limited = 1723, // Leaftronix Analogic Solutions Private Limited
        
        [Description("TWS Srl")]
        TWS_Srl = 1724, // TWS Srl
        
        [Description("ABB Oy")]
        ABB_Oy = 1725, // ABB Oy
        
        [Description("HitSeed Oy")]
        HitSeed_Oy = 1726, // HitSeed Oy
        
        [Description("Delcom Products Inc.")]
        Delcom_Products_Inc = 1727, // Delcom Products Inc.
        
        [Description("CAME S.p.A.")]
        CAME_S_p_A = 1728, // CAME S.p.A.
        
        [Description("Alarm.com Holdings, Inc")]
        Alarm_com_Holdings_Inc = 1729, // Alarm.com Holdings, Inc
        
        [Description("Measurlogic Inc.")]
        Measurlogic_Inc = 1730, // Measurlogic Inc.
        
        [Description("King I Electronics.Co.,Ltd")]
        King_I_Electronics_Co_Ltd = 1731, // King I Electronics.Co.,Ltd
        
        [Description("Dream Labs GmbH")]
        Dream_Labs_GmbH = 1732, // Dream Labs GmbH
        
        [Description("Urban Compass, Inc")]
        Urban_Compass_Inc = 1733, // Urban Compass, Inc
        
        [Description("Simm Tronic Limited")]
        Simm_Tronic_Limited = 1734, // Simm Tronic Limited
        
        [Description("Somatix Inc")]
        Somatix_Inc = 1735, // Somatix Inc
        
        [Description("Storz & Bickel GmbH & Co. KG")]
        Storz_And_Bickel_GmbH_And_Co_KG = 1736, // Storz & Bickel GmbH & Co. KG
        
        [Description("MYLAPS B.V.")]
        MYLAPS_B_V = 1737, // MYLAPS B.V.
        
        [Description("Shenzhen Zhongguang Infotech Technology Development Co., Ltd")]
        Shenzhen_Zhongguang_Infotech_Technology_Development_Co_Ltd = 1738, // Shenzhen Zhongguang Infotech Technology Development Co., Ltd
        
        [Description("Dyeware, LLC")]
        Dyeware_LLC = 1739, // Dyeware, LLC
        
        [Description("Dongguan SmartAction Technology Co.,Ltd.")]
        Dongguan_SmartAction_Technology_Co_Ltd = 1740, // Dongguan SmartAction Technology Co.,Ltd.
        
        [Description("DIG Corporation")]
        DIG_Corporation = 1741, // DIG Corporation
        
        [Description("FIOR & GENTZ")]
        FIOR_And_GENTZ = 1742, // FIOR & GENTZ
        
        [Description("Belparts N.V.")]
        Belparts_N_V = 1743, // Belparts N.V.
        
        [Description("Etekcity Corporation")]
        Etekcity_Corporation = 1744, // Etekcity Corporation
        
        [Description("Meyer Sound Laboratories, Incorporated")]
        Meyer_Sound_Laboratories_Incorporated = 1745, // Meyer Sound Laboratories, Incorporated
        
        [Description("CeoTronics AG")]
        CeoTronics_AG = 1746, // CeoTronics AG
        
        [Description("TriTeq Lock and Security, LLC")]
        TriTeq_Lock_and_Security_LLC = 1747, // TriTeq Lock and Security, LLC
        
        [Description("DYNAKODE TECHNOLOGY PRIVATE LIMITED")]
        DYNAKODE_TECHNOLOGY_PRIVATE_LIMITED = 1748, // DYNAKODE TECHNOLOGY PRIVATE LIMITED
        
        [Description("Sensirion AG")]
        Sensirion_AG = 1749, // Sensirion AG
        
        [Description("JCT Healthcare Pty Ltd")]
        JCT_Healthcare_Pty_Ltd = 1750, // JCT Healthcare Pty Ltd
        
        [Description("FUBA Automotive Electronics GmbH")]
        FUBA_Automotive_Electronics_GmbH = 1751, // FUBA Automotive Electronics GmbH
        
        [Description("AW Company")]
        AW_Company = 1752, // AW Company
        
        [Description("Shanghai Mountain View Silicon Co.,Ltd.")]
        Shanghai_Mountain_View_Silicon_Co_Ltd = 1753, // Shanghai Mountain View Silicon Co.,Ltd.
        
        [Description("Zliide Technologies ApS")]
        Zliide_Technologies_ApS = 1754, // Zliide Technologies ApS
        
        [Description("Automatic Labs, Inc.")]
        Automatic_Labs_Inc = 1755, // Automatic Labs, Inc.
        
        [Description("Industrial Network Controls, LLC")]
        Industrial_Network_Controls_LLC = 1756, // Industrial Network Controls, LLC
        
        [Description("Intellithings Ltd.")]
        Intellithings_Ltd = 1757, // Intellithings Ltd.
        
        [Description("Navcast, Inc.")]
        Navcast_Inc = 1758, // Navcast, Inc.
        
        [Description("Hubbell Lighting, Inc.")]
        Hubbell_Lighting_Inc = 1759, // Hubbell Lighting, Inc.
        
        [Description("Avaya")]
        Avaya = 1760, // Avaya
        
        [Description("Milestone AV Technologies LLC")]
        Milestone_AV_Technologies_LLC = 1761, // Milestone AV Technologies LLC
        
        [Description("Alango Technologies Ltd")]
        Alango_Technologies_Ltd = 1762, // Alango Technologies Ltd
        
        [Description("Spinlock Ltd")]
        Spinlock_Ltd = 1763, // Spinlock Ltd
        
        [Description("Aluna")]
        Aluna = 1764, // Aluna
        
        [Description("OPTEX CO.,LTD.")]
        OPTEX_CO_LTD = 1765, // OPTEX CO.,LTD.
        
        [Description("NIHON DENGYO KOUSAKU")]
        NIHON_DENGYO_KOUSAKU = 1766, // NIHON DENGYO KOUSAKU
        
        [Description("VELUX A/S")]
        VELUX_A_S = 1767, // VELUX A/S
        
        [Description("Almendo Technologies GmbH")]
        Almendo_Technologies_GmbH = 1768, // Almendo Technologies GmbH
        
        [Description("Zmartfun Electronics, Inc.")]
        Zmartfun_Electronics_Inc = 1769, // Zmartfun Electronics, Inc.
        
        [Description("SafeLine Sweden AB")]
        SafeLine_Sweden_AB = 1770, // SafeLine Sweden AB
        
        [Description("Houston Radar LLC")]
        Houston_Radar_LLC = 1771, // Houston Radar LLC
        
        [Description("Sigur")]
        Sigur = 1772, // Sigur
        
        [Description("J Neades Ltd")]
        J_Neades_Ltd = 1773, // J Neades Ltd
        
        [Description("Avantis Systems Limited")]
        Avantis_Systems_Limited = 1774, // Avantis Systems Limited
        
        [Description("ALCARE Co., Ltd.")]
        ALCARE_Co_Ltd = 1775, // ALCARE Co., Ltd.
        
        [Description("Chargy Technologies, SL")]
        Chargy_Technologies_SL = 1776, // Chargy Technologies, SL
        
        [Description("Shibutani Co., Ltd.")]
        Shibutani_Co_Ltd = 1777, // Shibutani Co., Ltd.
        
        [Description("Trapper Data AB")]
        Trapper_Data_AB = 1778, // Trapper Data AB
        
        [Description("Alfred International Inc.")]
        Alfred_International_Inc = 1779, // Alfred International Inc.
        
        [Description("Near Field Solutions Ltd")]
        Near_Field_Solutions_Ltd = 1780, // Near Field Solutions Ltd
        
        [Description("Vigil Technologies Inc.")]
        Vigil_Technologies_Inc = 1781, // Vigil Technologies Inc.
        
        [Description("Vitulo Plus BV")]
        Vitulo_Plus_BV = 1782, // Vitulo Plus BV
        
        [Description("WILKA Schliesstechnik GmbH")]
        WILKA_Schliesstechnik_GmbH = 1783, // WILKA Schliesstechnik GmbH
        
        [Description("BodyPlus Technology Co.,Ltd")]
        BodyPlus_Technology_Co_Ltd = 1784, // BodyPlus Technology Co.,Ltd
        
        [Description("happybrush GmbH")]
        happybrush_GmbH = 1785, // happybrush GmbH
        
        [Description("Enequi AB")]
        Enequi_AB = 1786, // Enequi AB
        
        [Description("Sartorius AG")]
        Sartorius_AG = 1787, // Sartorius AG
        
        [Description("Tom Communication Industrial Co.,Ltd.")]
        Tom_Communication_Industrial_Co_Ltd = 1788, // Tom Communication Industrial Co.,Ltd.
        
        [Description("ESS Embedded System Solutions Inc.")]
        ESS_Embedded_System_Solutions_Inc = 1789, // ESS Embedded System Solutions Inc.
        
        [Description("Mahr GmbH")]
        Mahr_GmbH = 1790, // Mahr GmbH
        
        [Description("Redpine Signals Inc")]
        Redpine_Signals_Inc = 1791, // Redpine Signals Inc
        
        [Description("TraqFreq LLC")]
        TraqFreq_LLC = 1792, // TraqFreq LLC
        
        [Description("PAFERS TECH")]
        PAFERS_TECH = 1793, // PAFERS TECH
        
        [Description("Akciju sabiedriba \"SAF TEHNIKA\"")]
        Akciju_sabiedriba_SAF_TEHNIKA = 1794, // Akciju sabiedriba \"SAF TEHNIKA\"
        
        [Description("Beijing Jingdong Century Trading Co., Ltd.")]
        Beijing_Jingdong_Century_Trading_Co_Ltd = 1795, // Beijing Jingdong Century Trading Co., Ltd.
        
        [Description("JBX Designs Inc.")]
        JBX_Designs_Inc = 1796, // JBX Designs Inc.
        
        [Description("AB Electrolux")]
        AB_Electrolux = 1797, // AB Electrolux
        
        [Description("Wernher von Braun Center for ASdvanced Research")]
        Wernher_von_Braun_Center_for_ASdvanced_Research = 1798, // Wernher von Braun Center for ASdvanced Research
        
        [Description("Essity Hygiene and Health Aktiebolag")]
        Essity_Hygiene_and_Health_Aktiebolag = 1799, // Essity Hygiene and Health Aktiebolag
        
        [Description("Be Interactive Co., Ltd")]
        Be_Interactive_Co_Ltd = 1800, // Be Interactive Co., Ltd
        
        [Description("Carewear Corp.")]
        Carewear_Corp = 1801, // Carewear Corp.
        
        [Description("Huf Hülsbeck & Fürst GmbH & Co. KG")]
        Huf_H_lsbeck_And_F_rst_GmbH_And_Co_KG = 1802, // Huf Hülsbeck & Fürst GmbH & Co. KG
        
        [Description("Element Products, Inc.")]
        Element_Products_Inc = 1803, // Element Products, Inc.
        
        [Description("Beijing Winner Microelectronics Co.,Ltd")]
        Beijing_Winner_Microelectronics_Co_Ltd = 1804, // Beijing Winner Microelectronics Co.,Ltd
        
        [Description("SmartSnugg Pty Ltd")]
        SmartSnugg_Pty_Ltd = 1805, // SmartSnugg Pty Ltd
        
        [Description("FiveCo Sarl")]
        FiveCo_Sarl = 1806, // FiveCo Sarl
        
        [Description("California Things Inc.")]
        California_Things_Inc = 1807, // California Things Inc.
        
        [Description("Audiodo AB")]
        Audiodo_AB = 1808, // Audiodo AB
        
        [Description("ABAX AS")]
        ABAX_AS = 1809, // ABAX AS
        
        [Description("Bull Group Company Limited")]
        Bull_Group_Company_Limited = 1810, // Bull Group Company Limited
        
        [Description("Respiri Limited")]
        Respiri_Limited = 1811, // Respiri Limited
        
        [Description("MindPeace Safety LLC")]
        MindPeace_Safety_LLC = 1812, // MindPeace Safety LLC
        
        [Description("Vgyan Solutions")]
        Vgyan_Solutions = 1813, // Vgyan Solutions
        
        [Description("Altonics")]
        Altonics = 1814, // Altonics
        
        [Description("iQsquare BV")]
        iQsquare_BV = 1815, // iQsquare BV
        
        [Description("IDIBAIX enginneering")]
        IDIBAIX_enginneering = 1816, // IDIBAIX enginneering
        
        [Description("ECSG")]
        ECSG = 1817, // ECSG
        
        [Description("REVSMART WEARABLE HK CO LTD")]
        REVSMART_WEARABLE_HK_CO_LTD = 1818, // REVSMART WEARABLE HK CO LTD
        
        [Description("Precor")]
        Precor = 1819, // Precor
        
        [Description("F5 Sports, Inc")]
        F5_Sports_Inc = 1820, // F5 Sports, Inc
        
        [Description("exoTIC Systems")]
        exoTIC_Systems = 1821, // exoTIC Systems
        
        [Description("DONGGUAN HELE ELECTRONICS CO., LTD")]
        DONGGUAN_HELE_ELECTRONICS_CO_LTD = 1822, // DONGGUAN HELE ELECTRONICS CO., LTD
        
        [Description("Dongguan Liesheng Electronic Co.Ltd")]
        Dongguan_Liesheng_Electronic_Co_Ltd = 1823, // Dongguan Liesheng Electronic Co.Ltd
        
        [Description("Oculeve, Inc.")]
        Oculeve_Inc = 1824, // Oculeve, Inc.
        
        [Description("Clover Network, Inc.")]
        Clover_Network_Inc = 1825, // Clover Network, Inc.
        
        [Description("Xiamen Eholder Electronics Co.Ltd")]
        Xiamen_Eholder_Electronics_Co_Ltd = 1826, // Xiamen Eholder Electronics Co.Ltd
        
        [Description("Ford Motor Company")]
        Ford_Motor_Company = 1827, // Ford Motor Company
        
        [Description("Guangzhou SuperSound Information Technology Co.,Ltd")]
        Guangzhou_SuperSound_Information_Technology_Co_Ltd = 1828, // Guangzhou SuperSound Information Technology Co.,Ltd
        
        [Description("Tedee Sp. z o.o.")]
        Tedee_Sp_z_o_o = 1829, // Tedee Sp. z o.o.
        
        [Description("PHC Corporation")]
        PHC_Corporation = 1830, // PHC Corporation
        
        [Description("STALKIT AS")]
        STALKIT_AS = 1831, // STALKIT AS
        
        [Description("Eli Lilly and Company")]
        Eli_Lilly_and_Company = 1832, // Eli Lilly and Company
        
        [Description("SwaraLink Technologies")]
        SwaraLink_Technologies = 1833, // SwaraLink Technologies
        
        [Description("JMR embedded systems GmbH")]
        JMR_embedded_systems_GmbH = 1834, // JMR embedded systems GmbH
        
        [Description("Bitkey Inc.")]
        Bitkey_Inc = 1835, // Bitkey Inc.
        
        [Description("GWA Hygiene GmbH")]
        GWA_Hygiene_GmbH = 1836, // GWA Hygiene GmbH
        
        [Description("Safera Oy")]
        Safera_Oy = 1837, // Safera Oy
        
        [Description("Open Platform Systems LLC")]
        Open_Platform_Systems_LLC = 1838, // Open Platform Systems LLC
        
        [Description("OnePlus Electronics (Shenzhen) Co., Ltd.")]
        OnePlus_Electronics_Shenzhen_Co_Ltd = 1839, // OnePlus Electronics (Shenzhen) Co., Ltd.
        
        [Description("Wildlife Acoustics, Inc.")]
        Wildlife_Acoustics_Inc = 1840, // Wildlife Acoustics, Inc.
        
        [Description("ABLIC Inc.")]
        ABLIC_Inc = 1841, // ABLIC Inc.
        
        [Description("Dairy Tech, Inc.")]
        Dairy_Tech_Inc = 1842, // Dairy Tech, Inc.
        
        [Description("Iguanavation, Inc.")]
        Iguanavation_Inc = 1843, // Iguanavation, Inc.
        
        [Description("DiUS Computing Pty Ltd")]
        DiUS_Computing_Pty_Ltd = 1844, // DiUS Computing Pty Ltd
        
        [Description("UpRight Technologies LTD")]
        UpRight_Technologies_LTD = 1845, // UpRight Technologies LTD
        
        [Description("FrancisFund, LLC")]
        FrancisFund_LLC = 1846, // FrancisFund, LLC
        
        [Description("LLC Navitek")]
        LLC_Navitek = 1847, // LLC Navitek
        
        [Description("Glass Security Pte Ltd")]
        Glass_Security_Pte_Ltd = 1848, // Glass Security Pte Ltd
        
        [Description("Jiangsu Qinheng Co., Ltd.")]
        Jiangsu_Qinheng_Co_Ltd = 1849, // Jiangsu Qinheng Co., Ltd.
        
        [Description("Chandler Systems Inc.")]
        Chandler_Systems_Inc = 1850, // Chandler Systems Inc.
        
        [Description("Fantini Cosmi s.p.a.")]
        Fantini_Cosmi_s_p_a = 1851, // Fantini Cosmi s.p.a.
        
        [Description("Acubit ApS")]
        Acubit_ApS = 1852, // Acubit ApS
        
        [Description("Beijing Hao Heng Tian Tech Co., Ltd.")]
        Beijing_Hao_Heng_Tian_Tech_Co_Ltd = 1853, // Beijing Hao Heng Tian Tech Co., Ltd.
        
        [Description("Bluepack S.R.L.")]
        Bluepack_S_R_L = 1854, // Bluepack S.R.L.
        
        [Description("Beijing Unisoc Technologies Co., Ltd.")]
        Beijing_Unisoc_Technologies_Co_Ltd = 1855, // Beijing Unisoc Technologies Co., Ltd.
        
        [Description("HITIQ LIMITED")]
        HITIQ_LIMITED = 1856, // HITIQ LIMITED
        
        [Description("MAC SRL")]
        MAC_SRL = 1857, // MAC SRL
        
        [Description("DML LLC")]
        DML_LLC = 1858, // DML LLC
        
        [Description("Sanofi")]
        Sanofi = 1859, // Sanofi
        
        [Description("SOCOMEC")]
        SOCOMEC = 1860, // SOCOMEC
        
        [Description("WIZNOVA, Inc.")]
        WIZNOVA_Inc = 1861, // WIZNOVA, Inc.
        
        [Description("Seitec Elektronik GmbH")]
        Seitec_Elektronik_GmbH = 1862, // Seitec Elektronik GmbH
        
        [Description("OR Technologies Pty Ltd")]
        OR_Technologies_Pty_Ltd = 1863, // OR Technologies Pty Ltd
        
        [Description("GuangZhou KuGou Computer Technology Co.Ltd")]
        GuangZhou_KuGou_Computer_Technology_Co_Ltd = 1864, // GuangZhou KuGou Computer Technology Co.Ltd
        
        [Description("DIAODIAO (Beijing) Technology Co., Ltd.")]
        DIAODIAO_Beijing_Technology_Co_Ltd = 1865, // DIAODIAO (Beijing) Technology Co., Ltd.
        
        [Description("Illusory Studios LLC")]
        Illusory_Studios_LLC = 1866, // Illusory Studios LLC
        
        [Description("Sarvavid Software Solutions LLP")]
        Sarvavid_Software_Solutions_LLP = 1867, // Sarvavid Software Solutions LLP
        
        [Description("iopool s.a.")]
        iopool_s_a = 1868, // iopool s.a.
        
        [Description("Amtech Systems, LLC")]
        Amtech_Systems_LLC = 1869, // Amtech Systems, LLC
        
        [Description("EAGLE DETECTION SA")]
        EAGLE_DETECTION_SA = 1870, // EAGLE DETECTION SA
        
        [Description("MEDIATECH S.R.L.")]
        MEDIATECH_S_R_L = 1871, // MEDIATECH S.R.L.
        
        [Description("Hamilton Professional Services of Canada Incorporated")]
        Hamilton_Professional_Services_of_Canada_Incorporated = 1872, // Hamilton Professional Services of Canada Incorporated
        
        [Description("Changsha JEMO IC Design Co.,Ltd")]
        Changsha_JEMO_IC_Design_Co_Ltd = 1873, // Changsha JEMO IC Design Co.,Ltd
        
        [Description("Elatec GmbH")]
        Elatec_GmbH = 1874, // Elatec GmbH
        
        [Description("JLG Industries, Inc.")]
        JLG_Industries_Inc = 1875, // JLG Industries, Inc.
        
        [Description("Michael Parkin")]
        Michael_Parkin = 1876, // Michael Parkin
        
        [Description("Brother Industries, Ltd")]
        Brother_Industries_Ltd = 1877, // Brother Industries, Ltd
        
        [Description("Lumens For Less, Inc")]
        Lumens_For_Less_Inc = 1878, // Lumens For Less, Inc
        
        [Description("ELA Innovation")]
        ELA_Innovation = 1879, // ELA Innovation
        
        [Description("umanSense AB")]
        umanSense_AB = 1880, // umanSense AB
        
        [Description("Shanghai InGeek Cyber Security Co., Ltd.")]
        Shanghai_InGeek_Cyber_Security_Co_Ltd = 1881, // Shanghai InGeek Cyber Security Co., Ltd.
        
        [Description("HARMAN CO.,LTD.")]
        HARMAN_CO_LTD = 1882, // HARMAN CO.,LTD.
        
        [Description("Smart Sensor Devices AB")]
        Smart_Sensor_Devices_AB = 1883, // Smart Sensor Devices AB
        
        [Description("Antitronics Inc.")]
        Antitronics_Inc = 1884, // Antitronics Inc.
        
        [Description("RHOMBUS SYSTEMS, INC.")]
        RHOMBUS_SYSTEMS_INC = 1885, // RHOMBUS SYSTEMS, INC.
        
        [Description("Katerra Inc.")]
        Katerra_Inc = 1886, // Katerra Inc.
        
        [Description("Remote Solution Co., LTD.")]
        Remote_Solution_Co_LTD = 1887, // Remote Solution Co., LTD.
        
        [Description("Vimar SpA")]
        Vimar_SpA = 1888, // Vimar SpA
        
        [Description("Mantis Tech LLC")]
        Mantis_Tech_LLC = 1889, // Mantis Tech LLC
        
        [Description("TerOpta Ltd")]
        TerOpta_Ltd = 1890, // TerOpta Ltd
        
        [Description("PIKOLIN S.L.")]
        PIKOLIN_S_L = 1891, // PIKOLIN S.L.
        
        [Description("WWZN Information Technology Company Limited")]
        WWZN_Information_Technology_Company_Limited = 1892, // WWZN Information Technology Company Limited
        
        [Description("Voxx International")]
        Voxx_International = 1893, // Voxx International
        
        [Description("ART AND PROGRAM, INC.")]
        ART_AND_PROGRAM_INC = 1894, // ART AND PROGRAM, INC.
        
        [Description("NITTO DENKO ASIA TECHNICAL CENTRE PTE. LTD.")]
        NITTO_DENKO_ASIA_TECHNICAL_CENTRE_PTE_LTD = 1895, // NITTO DENKO ASIA TECHNICAL CENTRE PTE. LTD.
        
        [Description("Peloton Interactive Inc.")]
        Peloton_Interactive_Inc = 1896, // Peloton Interactive Inc.
        
        [Description("Force Impact Technologies")]
        Force_Impact_Technologies = 1897, // Force Impact Technologies
        
        [Description("Dmac Mobile Developments, LLC")]
        Dmac_Mobile_Developments_LLC = 1898, // Dmac Mobile Developments, LLC
        
        [Description("Engineered Medical Technologies")]
        Engineered_Medical_Technologies = 1899, // Engineered Medical Technologies
        
        [Description("Noodle Technology, inc")]
        Noodle_Technology_inc = 1900, // Noodle Technology, inc
        
        [Description("Graesslin GmbH")]
        Graesslin_GmbH = 1901, // Graesslin GmbH
        
        [Description("WuQi technologies, Inc.")]
        WuQi_technologies_Inc = 1902, // WuQi technologies, Inc.
        
        [Description("Successful Endeavours Pty Ltd")]
        Successful_Endeavours_Pty_Ltd = 1903, // Successful Endeavours Pty Ltd
        
        [Description("InnoCon Medical ApS")]
        InnoCon_Medical_ApS = 1904, // InnoCon Medical ApS
        
        [Description("Corvex Connected Safety")]
        Corvex_Connected_Safety = 1905, // Corvex Connected Safety
        
        [Description("Thirdwayv Inc.")]
        Thirdwayv_Inc = 1906, // Thirdwayv Inc.
        
        [Description("Echoflex Solutions Inc.")]
        Echoflex_Solutions_Inc = 1907, // Echoflex Solutions Inc.
        
        [Description("C-MAX Asia Limited, Inc.")]
        C_MAX_Asia_Limited_Inc = 1908, // C-MAX Asia Limited, Inc.
        
        [Description("4eBusiness GmbH")]
        Four_eBusiness_GmbH = 1909, // 4eBusiness GmbH
        
        [Description("Cyber Transport Control GmbH")]
        Cyber_Transport_Control_GmbH = 1910, // Cyber Transport Control GmbH
        
        [Description("Cue")]
        Cue = 1911, // Cue
        
        [Description("KOAMTAC INC.")]
        KOAMTAC_INC = 1912, // KOAMTAC INC.
        
        [Description("Loopshore Oy")]
        Loopshore_Oy = 1913, // Loopshore Oy
        
        [Description("Niruha Systems Private Limited")]
        Niruha_Systems_Private_Limited = 1914, // Niruha Systems Private Limited
        
        [Description("AmaterZ, Inc.")]
        AmaterZ_Inc = 1915, // AmaterZ, Inc.
        
        [Description("radius co., ltd.")]
        radius_co_ltd = 1916, // radius co., ltd.
        
        [Description("Sensority, s.r.o.")]
        Sensority_s_r_o = 1917, // Sensority, s.r.o.
        
        [Description("Sparkage Inc.")]
        Sparkage_Inc = 1918, // Sparkage Inc.
        
        [Description("Glenview Software Corporation")]
        Glenview_Software_Corporation = 1919, // Glenview Software Corporation
        
        [Description("Finch Technologies Ltd.")]
        Finch_Technologies_Ltd = 1920, // Finch Technologies Ltd.
        
        [Description("Qingping Technology (Beijing) Co., Ltd.")]
        Qingping_Technology_Beijing_Co_Ltd = 1921, // Qingping Technology (Beijing) Co., Ltd.
        
        [Description("DeviceDrive AS")]
        DeviceDrive_AS = 1922, // DeviceDrive AS
        
        [Description("ESEMBER LIMITED LIABILITY COMPANY")]
        ESEMBER_LIMITED_LIABILITY_COMPANY = 1923, // ESEMBER LIMITED LIABILITY COMPANY
        
        [Description("audifon GmbH & Co. KG")]
        audifon_GmbH_And_Co_KG = 1924, // audifon GmbH & Co. KG
        
        [Description("O2 Micro, Inc.")]
        O2_Micro_Inc = 1925, // O2 Micro, Inc.
        
        [Description("HLP Controls Pty Limited")]
        HLP_Controls_Pty_Limited = 1926, // HLP Controls Pty Limited
        
        [Description("Pangaea Solution")]
        Pangaea_Solution = 1927, // Pangaea Solution
        
        [Description("BubblyNet, LLC")]
        BubblyNet_LLC = 1928, // BubblyNet, LLC
        
        [Description("The Wildflower Foundation")]
        The_Wildflower_Foundation = 1930, // The Wildflower Foundation
        
        [Description("Optikam Tech Inc.")]
        Optikam_Tech_Inc = 1931, // Optikam Tech Inc.
        
        [Description("MINIBREW HOLDING B.V")]
        MINIBREW_HOLDING_B_V = 1932, // MINIBREW HOLDING B.V
        
        [Description("Cybex GmbH")]
        Cybex_GmbH = 1933, // Cybex GmbH
        
        [Description("FUJIMIC NIIGATA, INC.")]
        FUJIMIC_NIIGATA_INC = 1934, // FUJIMIC NIIGATA, INC.
        
        [Description("Hanna Instruments, Inc.")]
        Hanna_Instruments_Inc = 1935, // Hanna Instruments, Inc.
        
        [Description("KOMPAN A/S")]
        KOMPAN_A_S = 1936, // KOMPAN A/S
        
        [Description("Scosche Industries, Inc.")]
        Scosche_Industries_Inc = 1937, // Scosche Industries, Inc.
        
        [Description("Provo Craft")]
        Provo_Craft = 1938, // Provo Craft
        
        [Description("AEV spol. s r.o.")]
        AEV_spol_s_r_o = 1939, // AEV spol. s r.o.
        
        [Description("The Coca-Cola Company")]
        The_Coca_Cola_Company = 1940, // The Coca-Cola Company
        
        [Description("GASTEC CORPORATION")]
        GASTEC_CORPORATION = 1941, // GASTEC CORPORATION
        
        [Description("StarLeaf Ltd")]
        StarLeaf_Ltd = 1942, // StarLeaf Ltd
        
        [Description("Water-i.d. GmbH")]
        Water_i_d_GmbH = 1943, // Water-i.d. GmbH
        
        [Description("HoloKit, Inc.")]
        HoloKit_Inc = 1944, // HoloKit, Inc.
        
        [Description("PlantChoir Inc.")]
        PlantChoir_Inc = 1945, // PlantChoir Inc.
        
        [Description("GuangDong Oppo Mobile Telecommunications Corp., Ltd.")]
        GuangDong_Oppo_Mobile_Telecommunications_Corp_Ltd = 1946, // GuangDong Oppo Mobile Telecommunications Corp., Ltd.
        
        [Description("CST ELECTRONICS (PROPRIETARY) LIMITED")]
        CST_ELECTRONICS_PROPRIETARY_LIMITED = 1947, // CST ELECTRONICS (PROPRIETARY) LIMITED
        
        [Description("Sky UK Limited")]
        Sky_UK_Limited = 1948, // Sky UK Limited
        
        [Description("Digibale Pty Ltd")]
        Digibale_Pty_Ltd = 1949, // Digibale Pty Ltd
        
        [Description("Smartloxx GmbH")]
        Smartloxx_GmbH = 1950, // Smartloxx GmbH
        
        [Description("Pune Scientific LLP")]
        Pune_Scientific_LLP = 1951, // Pune Scientific LLP
        
        [Description("Regent Beleuchtungskorper AG")]
        Regent_Beleuchtungskorper_AG = 1952, // Regent Beleuchtungskorper AG
        
        [Description("Apollo Neuroscience, Inc.")]
        Apollo_Neuroscience_Inc = 1953, // Apollo Neuroscience, Inc.
        
        [Description("Roku, Inc.")]
        Roku_Inc = 1954, // Roku, Inc.
        
        [Description("Comcast Cable")]
        Comcast_Cable = 1955, // Comcast Cable
        
        [Description("Xiamen Mage Information Technology Co., Ltd.")]
        Xiamen_Mage_Information_Technology_Co_Ltd = 1956, // Xiamen Mage Information Technology Co., Ltd.
        
        [Description("RAB Lighting, Inc.")]
        RAB_Lighting_Inc = 1957, // RAB Lighting, Inc.
        
        [Description("Musen Connect, Inc.")]
        Musen_Connect_Inc = 1958, // Musen Connect, Inc.
        
        [Description("Zume, Inc.")]
        Zume_Inc = 1959, // Zume, Inc.
        
        [Description("conbee GmbH")]
        conbee_GmbH = 1960, // conbee GmbH
        
        [Description("Bruel & Kjaer Sound & Vibration")]
        Bruel_And_Kjaer_Sound_And_Vibration = 1961, // Bruel & Kjaer Sound & Vibration
        
        [Description("The Kroger Co.")]
        The_Kroger_Co = 1962, // The Kroger Co.
        
        [Description("Granite River Solutions, Inc.")]
        Granite_River_Solutions_Inc = 1963, // Granite River Solutions, Inc.
        
        [Description("LoupeDeck Oy")]
        LoupeDeck_Oy = 1964, // LoupeDeck Oy
        
        [Description("New H3C Technologies Co.,Ltd")]
        New_H3C_Technologies_Co_Ltd = 1965, // New H3C Technologies Co.,Ltd
        
        [Description("Aurea Solucoes Tecnologicas Ltda.")]
        Aurea_Solucoes_Tecnologicas_Ltda = 1966, // Aurea Solucoes Tecnologicas Ltda.
        
        [Description("Hong Kong Bouffalo Lab Limited")]
        Hong_Kong_Bouffalo_Lab_Limited = 1967, // Hong Kong Bouffalo Lab Limited
        
        [Description("GV Concepts Inc.")]
        GV_Concepts_Inc = 1968, // GV Concepts Inc.
        
        [Description("Thomas Dynamics, LLC")]
        Thomas_Dynamics_LLC = 1969, // Thomas Dynamics, LLC
        
        [Description("Moeco IOT Inc.")]
        Moeco_IOT_Inc = 1970, // Moeco IOT Inc.
        
        [Description("2N TELEKOMUNIKACE a.s.")]
        Two_N_TELEKOMUNIKACE_a_s = 1971, // 2N TELEKOMUNIKACE a.s.
        
        [Description("Hormann KG Antriebstechnik")]
        Hormann_KG_Antriebstechnik = 1972, // Hormann KG Antriebstechnik
        
        [Description("CRONO CHIP, S.L.")]
        CRONO_CHIP_S_L = 1973, // CRONO CHIP, S.L.
        
        [Description("Soundbrenner Limited")]
        Soundbrenner_Limited = 1974, // Soundbrenner Limited
        
        [Description("ETABLISSEMENTS GEORGES RENAULT")]
        ETABLISSEMENTS_GEORGES_RENAULT = 1975, // ETABLISSEMENTS GEORGES RENAULT
        
        [Description("iSwip")]
        iSwip = 1976, // iSwip
        
        [Description("Epona Biotec Limited")]
        Epona_Biotec_Limited = 1977, // Epona Biotec Limited
        
        [Description("Battery-Biz Inc.")]
        Battery_Biz_Inc = 1978, // Battery-Biz Inc.
        
        [Description("EPIC S.R.L.")]
        EPIC_S_R_L = 1979, // EPIC S.R.L.
        
        [Description("KD CIRCUITS LLC")]
        KD_CIRCUITS_LLC = 1980, // KD CIRCUITS LLC
        
        [Description("Genedrive Diagnostics Ltd")]
        Genedrive_Diagnostics_Ltd = 1981, // Genedrive Diagnostics Ltd
        
        [Description("Axentia Technologies AB")]
        Axentia_Technologies_AB = 1982, // Axentia Technologies AB
        
        [Description("REGULA Ltd.")]
        REGULA_Ltd = 1983, // REGULA Ltd.
        
        [Description("Biral AG")]
        Biral_AG = 1984, // Biral AG
        
        [Description("A.W. Chesterton Company")]
        A_W_Chesterton_Company = 1985, // A.W. Chesterton Company
        
        [Description("Radinn AB")]
        Radinn_AB = 1986, // Radinn AB
        
        [Description("CIMTechniques, Inc.")]
        CIMTechniques_Inc = 1987, // CIMTechniques, Inc.
        
        [Description("Johnson Health Tech NA")]
        Johnson_Health_Tech_NA = 1988, // Johnson Health Tech NA
        
        [Description("June Life, Inc.")]
        June_Life_Inc = 1989, // June Life, Inc.
        
        [Description("Bluenetics GmbH")]
        Bluenetics_GmbH = 1990, // Bluenetics GmbH
        
        [Description("iaconicDesign Inc.")]
        iaconicDesign_Inc = 1991, // iaconicDesign Inc.
        
        [Description("WRLDS Creations AB")]
        WRLDS_Creations_AB = 1992, // WRLDS Creations AB
        
        [Description("Skullcandy, Inc.")]
        Skullcandy_Inc = 1993, // Skullcandy, Inc.
        
        [Description("Modul-System HH AB")]
        Modul_System_HH_AB = 1994, // Modul-System HH AB
        
        [Description("West Pharmaceutical Services, Inc.")]
        West_Pharmaceutical_Services_Inc = 1995, // West Pharmaceutical Services, Inc.
        
        [Description("Barnacle Systems Inc.")]
        Barnacle_Systems_Inc = 1996, // Barnacle Systems Inc.
        
        [Description("Smart Wave Technologies Canada Inc")]
        Smart_Wave_Technologies_Canada_Inc = 1997, // Smart Wave Technologies Canada Inc
        
        [Description("Shanghai Top-Chip Microelectronics Tech. Co., LTD")]
        Shanghai_Top_Chip_Microelectronics_Tech_Co_LTD = 1998, // Shanghai Top-Chip Microelectronics Tech. Co., LTD
        
        [Description("NeoSensory, Inc.")]
        NeoSensory_Inc = 1999, // NeoSensory, Inc.
        
        [Description("Hangzhou Tuya Information Technology Co., Ltd")]
        Hangzhou_Tuya_Information_Technology_Co_Ltd = 2000, // Hangzhou Tuya Information Technology Co., Ltd
        
        [Description("Shanghai Panchip Microelectronics Co., Ltd")]
        Shanghai_Panchip_Microelectronics_Co_Ltd = 2001, // Shanghai Panchip Microelectronics Co., Ltd
        
        [Description("React Accessibility Limited")]
        React_Accessibility_Limited = 2002, // React Accessibility Limited
        
        [Description("LIVNEX Co.,Ltd.")]
        LIVNEX_Co_Ltd = 2003, // LIVNEX Co.,Ltd.
        
        [Description("Kano Computing Limited")]
        Kano_Computing_Limited = 2004, // Kano Computing Limited
        
        [Description("hoots classic GmbH")]
        hoots_classic_GmbH = 2005, // hoots classic GmbH
        
        [Description("ecobee Inc.")]
        ecobee_Inc = 2006, // ecobee Inc.
        
        [Description("Nanjing Qinheng Microelectronics Co., Ltd")]
        Nanjing_Qinheng_Microelectronics_Co_Ltd = 2007, // Nanjing Qinheng Microelectronics Co., Ltd
        
        [Description("SOLUTIONS AMBRA INC.")]
        SOLUTIONS_AMBRA_INC = 2008, // SOLUTIONS AMBRA INC.
        
        [Description("Micro-Design, Inc.")]
        Micro_Design_Inc = 2009, // Micro-Design, Inc.
        
        [Description("STARLITE Co., Ltd.")]
        STARLITE_Co_Ltd = 2010, // STARLITE Co., Ltd.
        
        [Description("Remedee Labs")]
        Remedee_Labs = 2011, // Remedee Labs
        
        [Description("ThingOS GmbH")]
        ThingOS_GmbH = 2012, // ThingOS GmbH
        
        [Description("Linear Circuits")]
        Linear_Circuits = 2013, // Linear Circuits
        
        [Description("Unlimited Engineering SL")]
        Unlimited_Engineering_SL = 2014, // Unlimited Engineering SL
        
        [Description("Snap-on Incorporated")]
        Snap_on_Incorporated = 2015, // Snap-on Incorporated
        
        [Description("Edifier International Limited")]
        Edifier_International_Limited = 2016, // Edifier International Limited
        
        [Description("Lucie Labs")]
        Lucie_Labs = 2017, // Lucie Labs
        
        [Description("Alfred Kaercher SE & Co. KG")]
        Alfred_Kaercher_SE_And_Co_KG = 2018, // Alfred Kaercher SE & Co. KG
        
        [Description("Audiowise Technology Inc.")]
        Audiowise_Technology_Inc = 2019, // Audiowise Technology Inc.
        
        [Description("Geeksme S.L.")]
        Geeksme_S_L = 2020, // Geeksme S.L.
        
        [Description("Minut, Inc.")]
        Minut_Inc = 2021, // Minut, Inc.
        
        [Description("Autogrow Systems Limited")]
        Autogrow_Systems_Limited = 2022, // Autogrow Systems Limited
        
        [Description("Komfort IQ, Inc.")]
        Komfort_IQ_Inc = 2023, // Komfort IQ, Inc.
        
        [Description("Packetcraft, Inc.")]
        Packetcraft_Inc = 2024, // Packetcraft, Inc.
        
        [Description("Häfele GmbH & Co KG")]
        H_fele_GmbH_And_Co_KG = 2025, // Häfele GmbH & Co KG
        
        [Description("ShapeLog, Inc.")]
        ShapeLog_Inc = 2026, // ShapeLog, Inc.
        
        [Description("NOVABASE S.R.L.")]
        NOVABASE_S_R_L = 2027, // NOVABASE S.R.L.
        
        [Description("Frecce LLC")]
        Frecce_LLC = 2028, // Frecce LLC
        
        [Description("Joule IQ, INC.")]
        Joule_IQ_INC = 2029, // Joule IQ, INC.
        
        [Description("KidzTek LLC")]
        KidzTek_LLC = 2030, // KidzTek LLC
        
        [Description("Aktiebolaget Sandvik Coromant")]
        Aktiebolaget_Sandvik_Coromant = 2031, // Aktiebolaget Sandvik Coromant
        
        [Description("e-moola.com Pty Ltd")]
        e_moola_com_Pty_Ltd = 2032, // e-moola.com Pty Ltd
        
        [Description("GSM Innovations Pty Ltd")]
        GSM_Innovations_Pty_Ltd = 2033, // GSM Innovations Pty Ltd
        
        [Description("SERENE GROUP, INC")]
        SERENE_GROUP_INC = 2034, // SERENE GROUP, INC
        
        [Description("DIGISINE ENERGYTECH CO. LTD.")]
        DIGISINE_ENERGYTECH_CO_LTD = 2035, // DIGISINE ENERGYTECH CO. LTD.
        
        [Description("MEDIRLAB Orvosbiologiai Fejleszto Korlatolt Felelossegu Tarsasag")]
        MEDIRLAB_Orvosbiologiai_Fejleszto_Korlatolt_Felelossegu_Tarsasag = 2036, // MEDIRLAB Orvosbiologiai Fejleszto Korlatolt Felelossegu Tarsasag
        
        [Description("Byton North America Corporation")]
        Byton_North_America_Corporation = 2037, // Byton North America Corporation
        
        [Description("Shenzhen TonliScience and Technology Development Co.,Ltd")]
        Shenzhen_TonliScience_and_Technology_Development_Co_Ltd = 2038, // Shenzhen TonliScience and Technology Development Co.,Ltd
        
        [Description("Cesar Systems Ltd.")]
        Cesar_Systems_Ltd = 2039, // Cesar Systems Ltd.
        
        [Description("quip NYC Inc.")]
        quip_NYC_Inc = 2040, // quip NYC Inc.
        
        [Description("Direct Communication Solutions, Inc.")]
        Direct_Communication_Solutions_Inc = 2041, // Direct Communication Solutions, Inc.
        
        [Description("Klipsch Group, Inc.")]
        Klipsch_Group_Inc = 2042, // Klipsch Group, Inc.
        
        [Description("Access Co., Ltd")]
        Access_Co_Ltd = 2043, // Access Co., Ltd
        
        [Description("Renault SA")]
        Renault_SA = 2044, // Renault SA
        
        [Description("JSK CO., LTD.")]
        JSK_CO_LTD = 2045, // JSK CO., LTD.
        
        [Description("BIROTA")]
        BIROTA = 2046, // BIROTA
        
        [Description("maxon motor ltd.")]
        maxon_motor_ltd = 2047, // maxon motor ltd.
        
        [Description("Optek")]
        Optek = 2048, // Optek
        
        [Description("CRONUS ELECTRONICS LTD")]
        CRONUS_ELECTRONICS_LTD = 2049, // CRONUS ELECTRONICS LTD
        
        [Description("NantSound, Inc.")]
        NantSound_Inc = 2050, // NantSound, Inc.
        
        [Description("Domintell s.a.")]
        Domintell_s_a = 2051, // Domintell s.a.
        
        [Description("Andon Health Co.,Ltd")]
        Andon_Health_Co_Ltd = 2052, // Andon Health Co.,Ltd
        
        [Description("Urbanminded Ltd")]
        Urbanminded_Ltd = 2053, // Urbanminded Ltd
        
        [Description("TYRI Sweden AB")]
        TYRI_Sweden_AB = 2054, // TYRI Sweden AB
        
        [Description("ECD Electronic Components GmbH Dresden")]
        ECD_Electronic_Components_GmbH_Dresden = 2055, // ECD Electronic Components GmbH Dresden
        
        [Description("SISTEMAS KERN, SOCIEDAD ANÓMINA")]
        SISTEMAS_KERN_SOCIEDAD_AN_MINA = 2056, // SISTEMAS KERN, SOCIEDAD ANÓMINA
        
        [Description("Trulli Audio")]
        Trulli_Audio = 2057, // Trulli Audio
        
        [Description("Altaneos")]
        Altaneos = 2058, // Altaneos
        
        [Description("Nanoleaf Canada Limited")]
        Nanoleaf_Canada_Limited = 2059, // Nanoleaf Canada Limited
        
        [Description("Ingy B.V.")]
        Ingy_B_V = 2060, // Ingy B.V.
        
        [Description("Azbil Co.")]
        Azbil_Co = 2061, // Azbil Co.
        
        [Description("TATTCOM LLC")]
        TATTCOM_LLC = 2062, // TATTCOM LLC
        
        [Description("Paradox Engineering SA")]
        Paradox_Engineering_SA = 2063, // Paradox Engineering SA
        
        [Description("LECO Corporation")]
        LECO_Corporation = 2064, // LECO Corporation
        
        [Description("Becker Antriebe GmbH")]
        Becker_Antriebe_GmbH = 2065, // Becker Antriebe GmbH
        
        [Description("Mstream Technologies., Inc.")]
        Mstream_Technologies_Inc = 2066, // Mstream Technologies., Inc.
        
        [Description("Flextronics International USA Inc.")]
        Flextronics_International_USA_Inc = 2067, // Flextronics International USA Inc.
        
        [Description("Ossur hf.")]
        Ossur_hf = 2068, // Ossur hf.
        
        [Description("SKC Inc")]
        SKC_Inc = 2069, // SKC Inc
        
        [Description("SPICA SYSTEMS LLC")]
        SPICA_SYSTEMS_LLC = 2070, // SPICA SYSTEMS LLC
        
        [Description("Wangs Alliance Corporation")]
        Wangs_Alliance_Corporation = 2071, // Wangs Alliance Corporation
        
        [Description("tatwah SA")]
        tatwah_SA = 2072, // tatwah SA
        
        [Description("Hunter Douglas Inc")]
        Hunter_Douglas_Inc = 2073, // Hunter Douglas Inc
        
        [Description("Shenzhen Conex")]
        Shenzhen_Conex = 2074, // Shenzhen Conex
        
        [Description("DIM3")]
        DIM3 = 2075, // DIM3
        
        [Description("Bobrick Washroom Equipment, Inc.")]
        Bobrick_Washroom_Equipment_Inc = 2076, // Bobrick Washroom Equipment, Inc.
        
        [Description("Potrykus Holdings and Development LLC")]
        Potrykus_Holdings_and_Development_LLC = 2077, // Potrykus Holdings and Development LLC
        
        [Description("iNFORM Technology GmbH")]
        iNFORM_Technology_GmbH = 2078, // iNFORM Technology GmbH
        
        [Description("eSenseLab LTD")]
        eSenseLab_LTD = 2079, // eSenseLab LTD
        
        [Description("Brilliant Home Technology, Inc.")]
        Brilliant_Home_Technology_Inc = 2080, // Brilliant Home Technology, Inc.
        
        [Description("INOVA Geophysical, Inc.")]
        INOVA_Geophysical_Inc = 2081, // INOVA Geophysical, Inc.
        
        [Description("adafruit industries")]
        adafruit_industries = 2082, // adafruit industries
        
        [Description("Nexite Ltd")]
        Nexite_Ltd = 2083, // Nexite Ltd
        
        [Description("8Power Limited")]
        Eight_Power_Limited = 2084, // 8Power Limited
        
        [Description("CME PTE. LTD.")]
        CME_PTE_LTD = 2085, // CME PTE. LTD.
        
        [Description("Hyundai Motor Company")]
        Hyundai_Motor_Company = 2086, // Hyundai Motor Company
        
        [Description("Kickmaker")]
        Kickmaker = 2087, // Kickmaker
        
        [Description("Shanghai Suisheng Information Technology Co., Ltd.")]
        Shanghai_Suisheng_Information_Technology_Co_Ltd = 2088, // Shanghai Suisheng Information Technology Co., Ltd.
        
        [Description("HEXAGON METROLOGY DIVISION ROMER")]
        HEXAGON_METROLOGY_DIVISION_ROMER = 2089, // HEXAGON METROLOGY DIVISION ROMER
        
        [Description("Mitutoyo Corporation")]
        Mitutoyo_Corporation = 2090, // Mitutoyo Corporation
        
        [Description("shenzhen fitcare electronics Co.,Ltd")]
        shenzhen_fitcare_electronics_Co_Ltd = 2091, // shenzhen fitcare electronics Co.,Ltd
        
        [Description("INGICS TECHNOLOGY CO., LTD.")]
        INGICS_TECHNOLOGY_CO_LTD = 2092, // INGICS TECHNOLOGY CO., LTD.
        
        [Description("INCUS PERFORMANCE LTD.")]
        INCUS_PERFORMANCE_LTD = 2093, // INCUS PERFORMANCE LTD.
        
        [Description("ABB S.p.A.")]
        ABB_S_p_A = 2094, // ABB S.p.A.
        
        [Description("Blippit AB")]
        Blippit_AB = 2095, // Blippit AB
        
        [Description("Core Health and Fitness LLC")]
        Core_Health_and_Fitness_LLC = 2096, // Core Health and Fitness LLC
        
        [Description("Foxble, LLC")]
        Foxble_LLC = 2097, // Foxble, LLC
        
        [Description("Intermotive,Inc.")]
        Intermotive_Inc = 2098, // Intermotive,Inc.
        
        [Description("Conneqtech B.V.")]
        Conneqtech_B_V = 2099, // Conneqtech B.V.
        
        [Description("RIKEN KEIKI CO., LTD.,")]
        RIKEN_KEIKI_CO_LTD = 2100, // RIKEN KEIKI CO., LTD.,
        
        [Description("Canopy Growth Corporation")]
        Canopy_Growth_Corporation = 2101, // Canopy Growth Corporation
        
        [Description("Bitwards Oy")]
        Bitwards_Oy = 2102, // Bitwards Oy
        
        [Description("vivo Mobile Communication Co., Ltd.")]
        vivo_Mobile_Communication_Co_Ltd = 2103, // vivo Mobile Communication Co., Ltd.
        
        [Description("Etymotic Research, Inc.")]
        Etymotic_Research_Inc = 2104, // Etymotic Research, Inc.
        
        [Description("A puissance 3")]
        A_puissance_3 = 2105, // A puissance 3
        
        [Description("BPW Bergische Achsen Kommanditgesellschaft")]
        BPW_Bergische_Achsen_Kommanditgesellschaft = 2106, // BPW Bergische Achsen Kommanditgesellschaft
        
        [Description("Piaggio Fast Forward")]
        Piaggio_Fast_Forward = 2107, // Piaggio Fast Forward
        
        [Description("BeerTech LTD")]
        BeerTech_LTD = 2108, // BeerTech LTD
        
        [Description("Tokenize, Inc.")]
        Tokenize_Inc = 2109, // Tokenize, Inc.
        
        [Description("Zorachka LTD")]
        Zorachka_LTD = 2110, // Zorachka LTD
        
        [Description("D-Link Corp.")]
        D_Link_Corp = 2111, // D-Link Corp.
        
        [Description("Down Range Systems LLC")]
        Down_Range_Systems_LLC = 2112, // Down Range Systems LLC
        
        [Description("General Luminaire (Shanghai) Co., Ltd.")]
        General_Luminaire_Shanghai_Co_Ltd = 2113, // General Luminaire (Shanghai) Co., Ltd.
        
        [Description("Tangshan HongJia electronic technology co., LTD.")]
        Tangshan_HongJia_electronic_technology_co_LTD = 2114, // Tangshan HongJia electronic technology co., LTD.
        
        [Description("FRAGRANCE DELIVERY TECHNOLOGIES LTD")]
        FRAGRANCE_DELIVERY_TECHNOLOGIES_LTD = 2115, // FRAGRANCE DELIVERY TECHNOLOGIES LTD
        
        [Description("Pepperl + Fuchs GmbH")]
        Pepperl_Fuchs_GmbH = 2116, // Pepperl + Fuchs GmbH
        
        [Description("Dometic Corporation")]
        Dometic_Corporation = 2117, // Dometic Corporation
        
        [Description("USound GmbH")]
        USound_GmbH = 2118, // USound GmbH
        
        [Description("DNANUDGE LIMITED")]
        DNANUDGE_LIMITED = 2119, // DNANUDGE LIMITED
        
        [Description("JUJU JOINTS CANADA CORP.")]
        JUJU_JOINTS_CANADA_CORP = 2120, // JUJU JOINTS CANADA CORP.
        
        [Description("Dopple Technologies B.V.")]
        Dopple_Technologies_B_V = 2121, // Dopple Technologies B.V.
        
        [Description("ARCOM")]
        ARCOM = 2122, // ARCOM
        
        [Description("Biotechware SRL")]
        Biotechware_SRL = 2123, // Biotechware SRL
        
        [Description("ORSO Inc.")]
        ORSO_Inc = 2124, // ORSO Inc.
        
        [Description("SafePort")]
        SafePort = 2125, // SafePort
        
        [Description("Carol Cole Company")]
        Carol_Cole_Company = 2126, // Carol Cole Company
        
        [Description("Embedded Fitness B.V.")]
        Embedded_Fitness_B_V = 2127, // Embedded Fitness B.V.
        
        [Description("Yealink (Xiamen) Network Technology Co.,LTD")]
        Yealink_Xiamen_Network_Technology_Co_LTD = 2128, // Yealink (Xiamen) Network Technology Co.,LTD
        
        [Description("Subeca, Inc.")]
        Subeca_Inc = 2129, // Subeca, Inc.
        
        [Description("Cognosos, Inc.")]
        Cognosos_Inc = 2130, // Cognosos, Inc.
        
        [Description("Pektron Group Limited")]
        Pektron_Group_Limited = 2131, // Pektron Group Limited
        
        [Description("Tap Sound System")]
        Tap_Sound_System = 2132, // Tap Sound System
        
        [Description("Helios Hockey, Inc.")]
        Helios_Hockey_Inc = 2133, // Helios Hockey, Inc.
        
        [Description("Canopy Growth Corporation")]
        Canopy_Growth_Corporation_2 = 2134, // Canopy Growth Corporation
        
        [Description("Parsyl Inc")]
        Parsyl_Inc = 2135, // Parsyl Inc
        
        [Description("SOUNDBOKS")]
        SOUNDBOKS = 2136, // SOUNDBOKS
        
        [Description("BlueUp")]
        BlueUp = 2137, // BlueUp
        
        [Description("DAKATECH")]
        DAKATECH = 2138, // DAKATECH
        
        [Description("RICOH ELECTRONIC DEVICES CO., LTD.")]
        RICOH_ELECTRONIC_DEVICES_CO_LTD = 2139, // RICOH ELECTRONIC DEVICES CO., LTD.
        
        [Description("ACOS CO.,LTD.")]
        ACOS_CO_LTD = 2140, // ACOS CO.,LTD.
        
        [Description("Guilin Zhishen Information Technology Co.,Ltd.")]
        Guilin_Zhishen_Information_Technology_Co_Ltd = 2141, // Guilin Zhishen Information Technology Co.,Ltd.
        
        [Description("Krog Systems LLC")]
        Krog_Systems_LLC = 2142, // Krog Systems LLC
        
        [Description("COMPEGPS TEAM,SOCIEDAD LIMITADA")]
        COMPEGPS_TEAM_SOCIEDAD_LIMITADA = 2143, // COMPEGPS TEAM,SOCIEDAD LIMITADA
        
        [Description("Alflex Products B.V.")]
        Alflex_Products_B_V = 2144, // Alflex Products B.V.
        
        [Description("SmartSensor Labs Ltd")]
        SmartSensor_Labs_Ltd = 2145, // SmartSensor Labs Ltd
        
        [Description("SmartDrive Inc.")]
        SmartDrive_Inc = 2146, // SmartDrive Inc.
        
        [Description("Yo-tronics Technology Co., Ltd.")]
        Yo_tronics_Technology_Co_Ltd = 2147, // Yo-tronics Technology Co., Ltd.
        
        [Description("Rafaelmicro")]
        Rafaelmicro = 2148, // Rafaelmicro
        
        [Description("Emergency Lighting Products Limited")]
        Emergency_Lighting_Products_Limited = 2149, // Emergency Lighting Products Limited
        
        [Description("LAONZ Co.,Ltd")]
        LAONZ_Co_Ltd = 2150, // LAONZ Co.,Ltd
        
        [Description("Western Digital Techologies, Inc.")]
        Western_Digital_Techologies_Inc = 2151, // Western Digital Techologies, Inc.
        
        [Description("WIOsense GmbH & Co. KG")]
        WIOsense_GmbH_And_Co_KG = 2152, // WIOsense GmbH & Co. KG
        
        [Description("EVVA Sicherheitstechnologie GmbH")]
        EVVA_Sicherheitstechnologie_GmbH = 2153, // EVVA Sicherheitstechnologie GmbH
        
        [Description("Odic Incorporated")]
        Odic_Incorporated = 2154, // Odic Incorporated
        
        [Description("Pacific Track, LLC")]
        Pacific_Track_LLC = 2155, // Pacific Track, LLC
        
        [Description("Revvo Technologies, Inc.")]
        Revvo_Technologies_Inc = 2156, // Revvo Technologies, Inc.
        
        [Description("Biometrika d.o.o.")]
        Biometrika_d_o_o = 2157, // Biometrika d.o.o.
        
        [Description("Vorwerk Elektrowerke GmbH & Co. KG")]
        Vorwerk_Elektrowerke_GmbH_And_Co_KG = 2158, // Vorwerk Elektrowerke GmbH & Co. KG
        
        [Description("Trackunit A/S")]
        Trackunit_A_S = 2159, // Trackunit A/S
        
        [Description("Wyze Labs, Inc")]
        Wyze_Labs_Inc = 2160, // Wyze Labs, Inc
        
        [Description("Dension Elektronikai Kft. (formerly: Dension Audio Systems Ltd.)")]
        Dension_Elektronikai_Kft_formerly_Dension_Audio_Systems_Ltd = 2161, // Dension Elektronikai Kft. (formerly: Dension Audio Systems Ltd.)
        
        [Description("11 Health & Technologies Limited")]
        Eleven_Health_And_Technologies_Limited = 2162, // 11 Health & Technologies Limited
        
        [Description("Innophase Incorporated")]
        Innophase_Incorporated = 2163, // Innophase Incorporated
        
        [Description("Treegreen Limited")]
        Treegreen_Limited = 2164, // Treegreen Limited
        
        [Description("Berner International LLC")]
        Berner_International_LLC = 2165, // Berner International LLC
        
        [Description("SmartResQ ApS")]
        SmartResQ_ApS = 2166, // SmartResQ ApS
        
        [Description("Tome, Inc.")]
        Tome_Inc = 2167, // Tome, Inc.
        
        [Description("The Chamberlain Group, Inc.")]
        The_Chamberlain_Group_Inc = 2168, // The Chamberlain Group, Inc.
        
        [Description("MIZUNO Corporation")]
        MIZUNO_Corporation = 2169, // MIZUNO Corporation
        
        [Description("ZRF, LLC")]
        ZRF_LLC = 2170, // ZRF, LLC
        
        [Description("BYSTAMP")]
        BYSTAMP = 2171, // BYSTAMP
        
        [Description("Crosscan GmbH")]
        Crosscan_GmbH = 2172, // Crosscan GmbH
        
        [Description("Konftel AB")]
        Konftel_AB = 2173, // Konftel AB
        
        [Description("1bar.net Limited")]
        One_bar_net_Limited = 2174, // 1bar.net Limited
        
        [Description("Phillips Connect Technologies LLC")]
        Phillips_Connect_Technologies_LLC = 2175, // Phillips Connect Technologies LLC
        
        [Description("imagiLabs AB")]
        imagiLabs_AB = 2176, // imagiLabs AB
        
        [Description("Optalert")]
        Optalert = 2177, // Optalert
        
        [Description("PSYONIC, Inc.")]
        PSYONIC_Inc = 2178, // PSYONIC, Inc.
        
        [Description("Wintersteiger AG")]
        Wintersteiger_AG = 2179, // Wintersteiger AG
        
        [Description("Controlid Industria, Comercio de Hardware e Servicos de Tecnologia Ltda")]
        Controlid_Industria_Comercio_de_Hardware_e_Servicos_de_Tecnologia_Ltda = 2180, // Controlid Industria, Comercio de Hardware e Servicos de Tecnologia Ltda
        
        [Description("LEVOLOR, INC.")]
        LEVOLOR_INC = 2181, // LEVOLOR, INC.
        
        [Description("Xsens Technologies B.V.")]
        Xsens_Technologies_B_V = 2182, // Xsens Technologies B.V.
        
        [Description("Hydro-Gear Limited Partnership")]
        Hydro_Gear_Limited_Partnership = 2183, // Hydro-Gear Limited Partnership
        
        [Description("EnPointe Fencing Pty Ltd")]
        EnPointe_Fencing_Pty_Ltd = 2184, // EnPointe Fencing Pty Ltd
        
        [Description("XANTHIO")]
        XANTHIO = 2185, // XANTHIO
        
        [Description("sclak s.r.l.")]
        sclak_s_r_l = 2186, // sclak s.r.l.
        
        [Description("Tricorder Arraay Technologies LLC")]
        Tricorder_Arraay_Technologies_LLC = 2187, // Tricorder Arraay Technologies LLC
        
        [Description("GB Solution co.,Ltd")]
        GB_Solution_co_Ltd = 2188, // GB Solution co.,Ltd
        
        [Description("Soliton Systems K.K.")]
        Soliton_Systems_K_K = 2189, // Soliton Systems K.K.
        
        [Description("GIGA-TMS INC")]
        GIGA_TMS_INC = 2190, // GIGA-TMS INC
        
        [Description("Tait International Limited")]
        Tait_International_Limited = 2191, // Tait International Limited
        
        [Description("NICHIEI INTEC CO., LTD.")]
        NICHIEI_INTEC_CO_LTD = 2192, // NICHIEI INTEC CO., LTD.
        
        [Description("SmartWireless GmbH & Co. KG")]
        SmartWireless_GmbH_And_Co_KG = 2193, // SmartWireless GmbH & Co. KG
        
        [Description("Ingenieurbuero Birnfeld UG (haftungsbeschraenkt)")]
        Ingenieurbuero_Birnfeld_UG_haftungsbeschraenkt = 2194, // Ingenieurbuero Birnfeld UG (haftungsbeschraenkt)
        
        [Description("Maytronics Ltd")]
        Maytronics_Ltd = 2195, // Maytronics Ltd
        
        [Description("EPIFIT")]
        EPIFIT = 2196, // EPIFIT
        
        [Description("Gimer medical")]
        Gimer_medical = 2197, // Gimer medical
        
        [Description("Nokian Renkaat Oyj")]
        Nokian_Renkaat_Oyj = 2198, // Nokian Renkaat Oyj
        
        [Description("Current Lighting Solutions LLC")]
        Current_Lighting_Solutions_LLC = 2199, // Current Lighting Solutions LLC
        
        [Description("Sensibo, Inc.")]
        Sensibo_Inc = 2200, // Sensibo, Inc.
        
        [Description("SFS unimarket AG")]
        SFS_unimarket_AG = 2201, // SFS unimarket AG
        
        [Description("Private limited company 'Teltonika'")]
        Private_limited_company_Teltonika = 2202, // Private limited company 'Teltonika'
        
        [Description("Saucon Technologies")]
        Saucon_Technologies = 2203, // Saucon Technologies
        
        [Description("Embedded Devices Co. Company")]
        Embedded_Devices_Co_Company = 2204, // Embedded Devices Co. Company
        
        [Description("J-J.A.D.E. Enterprise LLC")]
        J_J_A_D_E_Enterprise_LLC = 2205, // J-J.A.D.E. Enterprise LLC
        
        [Description("i-SENS, inc.")]
        i_SENS_inc = 2206, // i-SENS, inc.
        
        [Description("Witschi Electronic Ltd")]
        Witschi_Electronic_Ltd = 2207, // Witschi Electronic Ltd
        
        [Description("Aclara Technologies LLC")]
        Aclara_Technologies_LLC = 2208, // Aclara Technologies LLC
        
        [Description("EXEO TECH CORPORATION")]
        EXEO_TECH_CORPORATION = 2209, // EXEO TECH CORPORATION
        
        [Description("Epic Systems Co., Ltd.")]
        Epic_Systems_Co_Ltd = 2210, // Epic Systems Co., Ltd.
        
        [Description("Hoffmann SE")]
        Hoffmann_SE = 2211, // Hoffmann SE
        
        [Description("Realme Chongqing Mobile Telecommunications Corp., Ltd.")]
        Realme_Chongqing_Mobile_Telecommunications_Corp_Ltd = 2212, // Realme Chongqing Mobile Telecommunications Corp., Ltd.
        
        [Description("UMEHEAL Ltd")]
        UMEHEAL_Ltd = 2213, // UMEHEAL Ltd
        
        [Description("Intelligenceworks Inc.")]
        Intelligenceworks_Inc = 2214, // Intelligenceworks Inc.
        
        [Description("TGR 1.618 Limited")]
        TGR_1_618_Limited = 2215, // TGR 1.618 Limited
        
        [Description("Shanghai Kfcube Inc")]
        Shanghai_Kfcube_Inc = 2216, // Shanghai Kfcube Inc
        
        [Description("Fraunhofer IIS")]
        Fraunhofer_IIS = 2217, // Fraunhofer IIS
        
        [Description("SZ DJI TECHNOLOGY CO.,LTD")]
        SZ_DJI_TECHNOLOGY_CO_LTD = 2218, // SZ DJI TECHNOLOGY CO.,LTD
        
        [Description("Coburn Technology, LLC")]
        Coburn_Technology_LLC = 2219, // Coburn Technology, LLC
        
        [Description("Topre Corporation")]
        Topre_Corporation = 2220, // Topre Corporation
        
        [Description("Kayamatics Limited")]
        Kayamatics_Limited = 2221, // Kayamatics Limited
        
        [Description("Moticon ReGo AG")]
        Moticon_ReGo_AG = 2222, // Moticon ReGo AG
        
        [Description("Polidea Sp. z o.o.")]
        Polidea_Sp_z_o_o = 2223, // Polidea Sp. z o.o.
        
        [Description("Trivedi Advanced Technologies LLC")]
        Trivedi_Advanced_Technologies_LLC = 2224, // Trivedi Advanced Technologies LLC
        
        [Description("CORE|vision BV")]
        CORE_vision_BV = 2225, // CORE|vision BV
        
        [Description("PF SCHWEISSTECHNOLOGIE GMBH")]
        PF_SCHWEISSTECHNOLOGIE_GMBH = 2226, // PF SCHWEISSTECHNOLOGIE GMBH
        
        [Description("IONIQ Skincare GmbH & Co. KG")]
        IONIQ_Skincare_GmbH_And_Co_KG = 2227, // IONIQ Skincare GmbH & Co. KG
        
        [Description("Sengled Co., Ltd.")]
        Sengled_Co_Ltd = 2228, // Sengled Co., Ltd.
        
        [Description("TransferFi")]
        TransferFi = 2229, // TransferFi
        
        [Description("Boehringer Ingelheim Vetmedica GmbH")]
        Boehringer_Ingelheim_Vetmedica_GmbH = 2230, // Boehringer Ingelheim Vetmedica GmbH
        
        [Description("ABB Inc")]
        ABB_Inc = 2231, // ABB Inc
        
        [Description("Check Technology Solutions LLC")]
        Check_Technology_Solutions_LLC = 2232, // Check Technology Solutions LLC
        
        [Description("U-Shin Ltd.")]
        U_Shin_Ltd = 2233, // U-Shin Ltd.
        
        [Description("HYPER ICE, INC.")]
        HYPER_ICE_INC = 2234, // HYPER ICE, INC.
        
        [Description("Tokai-rika co.,ltd.")]
        Tokai_rika_co_ltd = 2235, // Tokai-rika co.,ltd.
        
        [Description("Prevayl Limited")]
        Prevayl_Limited = 2236, // Prevayl Limited
        
        [Description("bf1systems limited")]
        bf1systems_limited = 2237, // bf1systems limited
        
        [Description("ubisys technologies GmbH")]
        ubisys_technologies_GmbH = 2238, // ubisys technologies GmbH
        
        [Description("SIRC Co., Ltd.")]
        SIRC_Co_Ltd = 2239, // SIRC Co., Ltd.
        
        [Description("Accent Advanced Systems SLU")]
        Accent_Advanced_Systems_SLU = 2240, // Accent Advanced Systems SLU
        
        [Description("Rayden.Earth LTD")]
        Rayden_Earth_LTD = 2241, // Rayden.Earth LTD
        
        [Description("Lindinvent AB")]
        Lindinvent_AB = 2242, // Lindinvent AB
        
        [Description("CHIPOLO d.o.o.")]
        CHIPOLO_d_o_o = 2243, // CHIPOLO d.o.o.
        
        [Description("CellAssist, LLC")]
        CellAssist_LLC = 2244, // CellAssist, LLC
        
        [Description("J. Wagner GmbH")]
        J_Wagner_GmbH = 2245, // J. Wagner GmbH
        
        [Description("Integra Optics Inc")]
        Integra_Optics_Inc = 2246, // Integra Optics Inc
        
        [Description("Monadnock Systems Ltd.")]
        Monadnock_Systems_Ltd = 2247, // Monadnock Systems Ltd.
        
        [Description("Liteboxer Technologies Inc.")]
        Liteboxer_Technologies_Inc = 2248, // Liteboxer Technologies Inc.
        
        [Description("Noventa AG")]
        Noventa_AG = 2249, // Noventa AG
        
        [Description("Nubia Technology Co.,Ltd.")]
        Nubia_Technology_Co_Ltd = 2250, // Nubia Technology Co.,Ltd.
        
        [Description("JT INNOVATIONS LIMITED")]
        JT_INNOVATIONS_LIMITED = 2251, // JT INNOVATIONS LIMITED
        
        [Description("TGM TECHNOLOGY CO., LTD.")]
        TGM_TECHNOLOGY_CO_LTD = 2252, // TGM TECHNOLOGY CO., LTD.
        
        [Description("ifly")]
        ifly = 2253, // ifly
        
        [Description("ZIMI CORPORATION")]
        ZIMI_CORPORATION = 2254, // ZIMI CORPORATION
        
        [Description("betternotstealmybike UG (with limited liability)")]
        betternotstealmybike_UG_with_limited_liability = 2255, // betternotstealmybike UG (with limited liability)
        
        [Description("ESTOM Infotech Kft.")]
        ESTOM_Infotech_Kft = 2256, // ESTOM Infotech Kft.
        
        [Description("Sensovium Inc.")]
        Sensovium_Inc = 2257, // Sensovium Inc.
        
        [Description("Virscient Limited")]
        Virscient_Limited = 2258, // Virscient Limited
        
        [Description("Novel Bits, LLC")]
        Novel_Bits_LLC = 2259, // Novel Bits, LLC
        
        [Description("ADATA Technology Co., LTD.")]
        ADATA_Technology_Co_LTD = 2260, // ADATA Technology Co., LTD.
        
        [Description("KEYes")]
        KEYes = 2261, // KEYes
        
        [Description("Nome Oy")]
        Nome_Oy = 2262, // Nome Oy
        
        [Description("Inovonics Corp")]
        Inovonics_Corp = 2263, // Inovonics Corp
        
        [Description("WARES")]
        WARES = 2264, // WARES
        
        [Description("Pointr Labs Limited")]
        Pointr_Labs_Limited = 2265, // Pointr Labs Limited
        
        [Description("Miridia Technology Incorporated")]
        Miridia_Technology_Incorporated = 2266, // Miridia Technology Incorporated
        
        [Description("Tertium Technology")]
        Tertium_Technology = 2267, // Tertium Technology
        
        [Description("SHENZHEN AUKEY E BUSINESS CO., LTD")]
        SHENZHEN_AUKEY_E_BUSINESS_CO_LTD = 2268, // SHENZHEN AUKEY E BUSINESS CO., LTD
        
        [Description("code-Q")]
        code_Q = 2269, // code-Q
        
        [Description("Tyco Electronics Corporation a TE Connectivity Ltd Company")]
        Tyco_Electronics_Corporation_a_TE_Connectivity_Ltd_Company = 2270, // Tyco Electronics Corporation a TE Connectivity Ltd Company
        
        [Description("IRIS OHYAMA CO.,LTD.")]
        IRIS_OHYAMA_CO_LTD = 2271, // IRIS OHYAMA CO.,LTD.
        
        [Description("Philia Technology")]
        Philia_Technology = 2272, // Philia Technology
        
        [Description("KOZO KEIKAKU ENGINEERING Inc.")]
        KOZO_KEIKAKU_ENGINEERING_Inc = 2273, // KOZO KEIKAKU ENGINEERING Inc.
        
        [Description("Shenzhen Simo Technology co. LTD")]
        Shenzhen_Simo_Technology_co_LTD = 2274, // Shenzhen Simo Technology co. LTD
        
        [Description("Republic Wireless, Inc.")]
        Republic_Wireless_Inc = 2275, // Republic Wireless, Inc.
        
        [Description("Rashidov ltd")]
        Rashidov_ltd = 2276, // Rashidov ltd
        
        [Description("Crowd Connected Ltd")]
        Crowd_Connected_Ltd = 2277, // Crowd Connected Ltd
        
        [Description("Eneso Tecnologia de Adaptacion S.L.")]
        Eneso_Tecnologia_de_Adaptacion_S_L = 2278, // Eneso Tecnologia de Adaptacion S.L.
        
        [Description("Barrot Technology Limited")]
        Barrot_Technology_Limited = 2279, // Barrot Technology Limited
        
        [Description("Naonext")]
        Naonext = 2280, // Naonext
        
        [Description("Taiwan Intelligent Home Corp.")]
        Taiwan_Intelligent_Home_Corp = 2281, // Taiwan Intelligent Home Corp.
        
        [Description("COWBELL ENGINEERING CO.,LTD.")]
        COWBELL_ENGINEERING_CO_LTD = 2282, // COWBELL ENGINEERING CO.,LTD.
        
        [Description("Beijing Big Moment Technology Co., Ltd.")]
        Beijing_Big_Moment_Technology_Co_Ltd = 2283, // Beijing Big Moment Technology Co., Ltd.
        
        [Description("Denso Corporation")]
        Denso_Corporation = 2284, // Denso Corporation
        
        [Description("IMI Hydronic Engineering International SA")]
        IMI_Hydronic_Engineering_International_SA = 2285, // IMI Hydronic Engineering International SA
        
        [Description("ASKEY")]
        ASKEY = 2286, // ASKEY
        
        [Description("Cumulus Digital Systems, Inc")]
        Cumulus_Digital_Systems_Inc = 2287, // Cumulus Digital Systems, Inc
        
        [Description("Joovv, Inc.")]
        Joovv_Inc = 2288, // Joovv, Inc.
        
        [Description("The L.S. Starrett Company")]
        The_L_S_Starrett_Company = 2289, // The L.S. Starrett Company
        
        [Description("Microoled")]
        Microoled = 2290, // Microoled
        
        [Description("PSP - Pauli Services & Products GmbH")]
        PSP_Pauli_Services_And_Products_GmbH = 2291, // PSP - Pauli Services & Products GmbH
        
        [Description("Kodimo Technologies Company Limited")]
        Kodimo_Technologies_Company_Limited = 2292, // Kodimo Technologies Company Limited
        
        [Description("Tymtix Technologies Private Limited")]
        Tymtix_Technologies_Private_Limited = 2293, // Tymtix Technologies Private Limited
        
        [Description("Dermal Photonics Corporation")]
        Dermal_Photonics_Corporation = 2294, // Dermal Photonics Corporation
        
        [Description("MTD Products Inc & Affiliates")]
        MTD_Products_Inc_And_Affiliates = 2295, // MTD Products Inc & Affiliates
        
        [Description("instagrid GmbH")]
        instagrid_GmbH = 2296, // instagrid GmbH
        
        [Description("Spacelabs Medical Inc.")]
        Spacelabs_Medical_Inc = 2297, // Spacelabs Medical Inc.
        
        [Description("Troo Corporation")]
        Troo_Corporation = 2298, // Troo Corporation
        
        [Description("Darkglass Electronics Oy")]
        Darkglass_Electronics_Oy = 2299, // Darkglass Electronics Oy
        
        [Description("Hill-Rom")]
        Hill_Rom = 2300, // Hill-Rom
        
        [Description("BioIntelliSense, Inc.")]
        BioIntelliSense_Inc = 2301, // BioIntelliSense, Inc.
        
        [Description("Ketronixs Sdn Bhd")]
        Ketronixs_Sdn_Bhd = 2302, // Ketronixs Sdn Bhd
        
        [Description("SUNCORPORATION")]
        SUNCORPORATION = 2308, // SUNCORPORATION
        
        [Description("Yandex Services AG")]
        Yandex_Services_AG = 2309, // Yandex Services AG
        
        [Description("Scope Logistical Solutions")]
        Scope_Logistical_Solutions = 2310, // Scope Logistical Solutions
        
        [Description("User Hello, LLC")]
        User_Hello_LLC = 2311, // User Hello, LLC
        
        [Description("Pinpoint Innovations Limited")]
        Pinpoint_Innovations_Limited = 2312, // Pinpoint Innovations Limited
        
        [Description("70mai Co.,Ltd.")]
        Seventy_mai_Co_Ltd = 2313, // 70mai Co.,Ltd.
        
        [Description("Zhuhai Hoksi Technology CO.,LTD")]
        Zhuhai_Hoksi_Technology_CO_LTD = 2314, // Zhuhai Hoksi Technology CO.,LTD
        
        [Description("EMBR labs, INC")]
        EMBR_labs_INC = 2315, // EMBR labs, INC
        
        [Description("Radiawave Technologies Co.,Ltd.")]
        Radiawave_Technologies_Co_Ltd = 2316, // Radiawave Technologies Co.,Ltd.
        
        [Description("IOT Invent GmbH")]
        IOT_Invent_GmbH = 2317, // IOT Invent GmbH
        
        [Description("OPTIMUSIOT TECH LLP")]
        OPTIMUSIOT_TECH_LLP = 2318, // OPTIMUSIOT TECH LLP
        
        [Description("VC Inc.")]
        VC_Inc = 2319, // VC Inc.
        
        [Description("ASR Microelectronics (Shanghai) Co., Ltd.")]
        ASR_Microelectronics_Shanghai_Co_Ltd = 2320, // ASR Microelectronics (Shanghai) Co., Ltd.
        
        [Description("Douglas Lighting Controls Inc.")]
        Douglas_Lighting_Controls_Inc = 2321, // Douglas Lighting Controls Inc.
        
        [Description("Nerbio Medical Software Platforms Inc")]
        Nerbio_Medical_Software_Platforms_Inc = 2322, // Nerbio Medical Software Platforms Inc
        
        [Description("Braveheart Wireless, Inc.")]
        Braveheart_Wireless_Inc = 2323, // Braveheart Wireless, Inc.
        
        [Description("INEO-SENSE")]
        INEO_SENSE = 2324, // INEO-SENSE
        
        [Description("Honda Motor Co., Ltd.")]
        Honda_Motor_Co_Ltd = 2325, // Honda Motor Co., Ltd.
        
        [Description("Ambient Sensors LLC")]
        Ambient_Sensors_LLC = 2326, // Ambient Sensors LLC
        
        [Description("ASR Microelectronics(ShenZhen)Co., Ltd.")]
        ASR_Microelectronics_ShenZhen_Co_Ltd = 2327, // ASR Microelectronics(ShenZhen)Co., Ltd.
        
        [Description("Technosphere Labs Pvt. Ltd.")]
        Technosphere_Labs_Pvt_Ltd = 2328, // Technosphere Labs Pvt. Ltd.
        
        [Description("NO SMD LIMITED")]
        NO_SMD_LIMITED = 2329, // NO SMD LIMITED
        
        [Description("Albertronic BV")]
        Albertronic_BV = 2330, // Albertronic BV
        
        [Description("Luminostics, Inc.")]
        Luminostics_Inc = 2331, // Luminostics, Inc.
        
        [Description("Oblamatik AG")]
        Oblamatik_AG = 2332, // Oblamatik AG
        
        [Description("Innokind, Inc.")]
        Innokind_Inc = 2333, // Innokind, Inc.
        
        [Description("Melbot Studios, Sociedad Limitada")]
        Melbot_Studios_Sociedad_Limitada = 2334, // Melbot Studios, Sociedad Limitada
        
        [Description("Myzee Technology")]
        Myzee_Technology = 2335, // Myzee Technology
        
        [Description("Omnisense Limited")]
        Omnisense_Limited = 2336, // Omnisense Limited
        
        [Description("KAHA PTE. LTD.")]
        KAHA_PTE_LTD = 2337, // KAHA PTE. LTD.
        
        [Description("Shanghai MXCHIP Information Technology Co., Ltd.")]
        Shanghai_MXCHIP_Information_Technology_Co_Ltd = 2338, // Shanghai MXCHIP Information Technology Co., Ltd.
        
        [Description("JSB TECH PTE LTD")]
        JSB_TECH_PTE_LTD = 2339, // JSB TECH PTE LTD
        
        [Description("Fundacion Tecnalia Research and Innovation")]
        Fundacion_Tecnalia_Research_and_Innovation = 2340, // Fundacion Tecnalia Research and Innovation
        
        [Description("Yukai Engineering Inc.")]
        Yukai_Engineering_Inc = 2341, // Yukai Engineering Inc.
        
        [Description("Gooligum Technologies Pty Ltd")]
        Gooligum_Technologies_Pty_Ltd = 2342, // Gooligum Technologies Pty Ltd
        
        [Description("ROOQ GmbH")]
        ROOQ_GmbH = 2343, // ROOQ GmbH
        
        [Description("AiRISTA")]
        AiRISTA = 2344, // AiRISTA
        
        [Description("Qingdao Haier Technology Co., Ltd.")]
        Qingdao_Haier_Technology_Co_Ltd = 2345, // Qingdao Haier Technology Co., Ltd.
        
        [Description("Sappl Verwaltungs- und Betriebs GmbH")]
        Sappl_Verwaltungs_und_Betriebs_GmbH = 2346, // Sappl Verwaltungs- und Betriebs GmbH
        
        [Description("TekHome")]
        TekHome = 2347, // TekHome
        
        [Description("PCI Private Limited")]
        PCI_Private_Limited = 2348, // PCI Private Limited
        
        [Description("Leggett & Platt, Incorporated")]
        Leggett_And_Platt_Incorporated = 2349, // Leggett & Platt, Incorporated
        
        [Description("PS GmbH")]
        PS_GmbH = 2350, // PS GmbH
        
        [Description("C.O.B.O. SpA")]
        C_O_B_O_SpA = 2351, // C.O.B.O. SpA
        
        [Description("James Walker RotaBolt Limited")]
        James_Walker_RotaBolt_Limited = 2352, // James Walker RotaBolt Limited
        
        [Description("BREATHINGS Co., Ltd.")]
        BREATHINGS_Co_Ltd = 2353, // BREATHINGS Co., Ltd.
        
        [Description("BarVision, LLC")]
        BarVision_LLC = 2354, // BarVision, LLC
        
        [Description("SRAM")]
        SRAM = 2355, // SRAM
        
        [Description("KiteSpring Inc.")]
        KiteSpring_Inc = 2356, // KiteSpring Inc.
        
        [Description("Reconnect, Inc.")]
        Reconnect_Inc = 2357, // Reconnect, Inc.
        
        [Description("Elekon AG")]
        Elekon_AG = 2358, // Elekon AG
        
        [Description("RealThingks GmbH")]
        RealThingks_GmbH = 2359, // RealThingks GmbH
        
        [Description("Henway Technologies, LTD.")]
        Henway_Technologies_LTD = 2360, // Henway Technologies, LTD.
        
        [Description("ASTEM Co.,Ltd.")]
        ASTEM_Co_Ltd = 2361, // ASTEM Co.,Ltd.
        
        [Description("LinkedSemi Microelectronics (Xiamen) Co., Ltd")]
        LinkedSemi_Microelectronics_Xiamen_Co_Ltd = 2362, // LinkedSemi Microelectronics (Xiamen) Co., Ltd
        
        [Description("ENSESO LLC")]
        ENSESO_LLC = 2363, // ENSESO LLC
        
        [Description("Xenoma Inc.")]
        Xenoma_Inc = 2364, // Xenoma Inc.
        
        [Description("Adolf Wuerth GmbH & Co KG")]
        Adolf_Wuerth_GmbH_And_Co_KG = 2365, // Adolf Wuerth GmbH & Co KG
        
        [Description("Catalyft Labs, Inc.")]
        Catalyft_Labs_Inc = 2366, // Catalyft Labs, Inc.
        
        [Description("JEPICO Corporation")]
        JEPICO_Corporation = 2367, // JEPICO Corporation
        
        [Description("Hero Workout GmbH")]
        Hero_Workout_GmbH = 2368, // Hero Workout GmbH
        
        [Description("Rivian Automotive, LLC")]
        Rivian_Automotive_LLC = 2369, // Rivian Automotive, LLC
        
        [Description("TRANSSION HOLDINGS LIMITED")]
        TRANSSION_HOLDINGS_LIMITED = 2370, // TRANSSION HOLDINGS LIMITED
        
        [Description("Inovonics Corp.")]
        Inovonics_Corp_2 = 2371, // Inovonics Corp.
        
        [Description("Agitron d.o.o.")]
        Agitron_d_o_o = 2372, // Agitron d.o.o.
        
        [Description("Globe (Jiangsu) Co., Ltd")]
        Globe_Jiangsu_Co_Ltd = 2373, // Globe (Jiangsu) Co., Ltd
        
        [Description("AMC International Alfa Metalcraft Corporation AG")]
        AMC_International_Alfa_Metalcraft_Corporation_AG = 2374, // AMC International Alfa Metalcraft Corporation AG
        
        [Description("First Light Technologies Ltd.")]
        First_Light_Technologies_Ltd = 2375, // First Light Technologies Ltd.
        
        [Description("Wearable Link Limited")]
        Wearable_Link_Limited = 2376, // Wearable Link Limited
        
        [Description("Metronom Health Europe")]
        Metronom_Health_Europe = 2377, // Metronom Health Europe
        
        [Description("Zwift, Inc.")]
        Zwift_Inc = 2378, // Zwift, Inc.
        
        [Description("Kindeva Drug Delivery L.P.")]
        Kindeva_Drug_Delivery_L_P = 2379, // Kindeva Drug Delivery L.P.
        
        [Description("GimmiSys GmbH")]
        GimmiSys_GmbH = 2380, // GimmiSys GmbH
        
        [Description("tkLABS INC.")]
        tkLABS_INC = 2381, // tkLABS INC.
        
        [Description("PassiveBolt, Inc.")]
        PassiveBolt_Inc = 2382, // PassiveBolt, Inc.
        
        [Description("Mikrotikls")]
        Mikrotikls = 2383, // Mikrotikls
        
        [Description("Capetech")]
        Capetech = 2384, // Capetech
        
        [Description("PPRS")]
        PPRS = 2385, // PPRS
        
        [Description("Apptricity Corporation")]
        Apptricity_Corporation = 2386, // Apptricity Corporation
        
        [Description("LogiLube, LLC")]
        LogiLube_LLC = 2387, // LogiLube, LLC
        
        [Description("Julbo")]
        Julbo = 2388, // Julbo
        
        [Description("Breville Group")]
        Breville_Group = 2389, // Breville Group
        
        [Description("Kerlink")]
        Kerlink = 2390, // Kerlink
        
        [Description("Ohsung Electronics")]
        Ohsung_Electronics = 2391, // Ohsung Electronics
        
        [Description("ZTE Corporation")]
        ZTE_Corporation = 2392, // ZTE Corporation
        
        [Description("HerdDogg, Inc")]
        HerdDogg_Inc = 2393, // HerdDogg, Inc
        
        [Description("Selekt Bilgisayar, lletisim Urunleri lnsaat Sanayi ve Ticaret Limited Sirketi")]
        Selekt_Bilgisayar_lletisim_Urunleri_lnsaat_Sanayi_ve_Ticaret_Limited_Sirketi = 2394, // Selekt Bilgisayar, lletisim Urunleri lnsaat Sanayi ve Ticaret Limited Sirketi
        
        [Description("Lismore Instruments Limited")]
        Lismore_Instruments_Limited = 2395, // Lismore Instruments Limited
        
        [Description("LogiLube, LLC")]
        LogiLube_LLC_2 = 2396, // LogiLube, LLC
        
        [Description("ETC")]
        ETC = 2397, // ETC
        
        [Description("BioEchoNet inc.")]
        BioEchoNet_inc = 2398, // BioEchoNet inc.
        
        [Description("NUANCE HEARING LTD")]
        NUANCE_HEARING_LTD = 2399, // NUANCE HEARING LTD
        
        [Description("Sena Technologies Inc.")]
        Sena_Technologies_Inc = 2400, // Sena Technologies Inc.
        
        [Description("Linkura AB")]
        Linkura_AB = 2401, // Linkura AB
        
        [Description("GL Solutions K.K.")]
        GL_Solutions_K_K = 2402, // GL Solutions K.K.
        
        [Description("Moonbird BV")]
        Moonbird_BV = 2403, // Moonbird BV
        
        [Description("Countrymate Technology Limited")]
        Countrymate_Technology_Limited = 2404, // Countrymate Technology Limited
        
        [Description("Asahi Kasei Corporation")]
        Asahi_Kasei_Corporation = 2405, // Asahi Kasei Corporation
        
        [Description("PointGuard, LLC")]
        PointGuard_LLC = 2406, // PointGuard, LLC
        
        [Description("Neo Materials and Consulting Inc.")]
        Neo_Materials_and_Consulting_Inc = 2407, // Neo Materials and Consulting Inc.
        
        [Description("Actev Motors, Inc.")]
        Actev_Motors_Inc = 2408, // Actev Motors, Inc.
        
        [Description("Woan Technology (Shenzhen) Co., Ltd.")]
        Woan_Technology_Shenzhen_Co_Ltd = 2409, // Woan Technology (Shenzhen) Co., Ltd.
        
        [Description("dricos, Inc.")]
        dricos_Inc = 2410, // dricos, Inc.
        
        [Description("Guide ID B.V.")]
        Guide_ID_B_V = 2411, // Guide ID B.V.
        
        [Description("9374-7319 Quebec inc")]
        Quebec_inc = 2412, // 9374-7319 Quebec inc
        
        [Description("Gunwerks, LLC")]
        Gunwerks_LLC = 2413, // Gunwerks, LLC
        
        [Description("Band Industries, inc.")]
        Band_Industries_inc = 2414, // Band Industries, inc.
        
        [Description("Lund Motion Products, Inc.")]
        Lund_Motion_Products_Inc = 2415, // Lund Motion Products, Inc.
        
        [Description("IBA Dosimetry GmbH")]
        IBA_Dosimetry_GmbH = 2416, // IBA Dosimetry GmbH
        
        [Description("GA")]
        GA = 2417, // GA
        
        [Description("Zavod Flometr (CJSC)")]
        Zavod_Flometr_CJSC = 2418, // Zavod Flometr (CJSC)
        
        [Description("Popit Oy")]
        Popit_Oy = 2419, // Popit Oy
        
        [Description("ABEYE")]
        ABEYE = 2420, // ABEYE
        
        [Description("BlueIOT(Beijing) Technology Co.,Ltd")]
        BlueIOT_Beijing_Technology_Co_Ltd = 2421, // BlueIOT(Beijing) Technology Co.,Ltd
    }
}