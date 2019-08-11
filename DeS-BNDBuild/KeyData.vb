﻿Public Module KeyData

    'Data0.bhd is not a bhd, but we'll use it to operate on the bdt
    Public archiveDict As Dictionary(Of UInteger, String) = New Dictionary(Of UInteger, String) From
        {{&H494F748F, "Data0"}, {&HCAFFC093, "Data1"}, {&H5F1BF9C, "Data2"}, {&H3141CE9C, "Data3"}, {&H98A201D9, "Data4"}, {&H9B6359B7, "Data5"}, {&H62835BFB, "DLC1"}, {&HB11F1A3D, "DLC2"}, {&H68402770, "Data1Sekiro"}, {&H25524AAB, "Data2Sekiro"}, {&H4A0F1FF5, "Data3Sekiro"}, {&H2F15DDDE, "Data4Sekiro"}, {&H1B18A8FB, "Data5Sekiro"}}

    Public modDict As Dictionary(Of String, Byte()) = New Dictionary(Of String, Byte()) From
        {{"Data1", {&H9B, &H61, &HF, &HA2, &HFD, &H19, &HCE, &HB1, &H9F, &H2, &HEC, &H9, &HC6, &H10, &HEC, &HDB,
                    &HAA, &HDB, &HBB, &H52, &HED, &H57, &HDB, &H46, &H1, &HC4, &H4, &H10, &H13, &HEF, &HC0, &HF6,
                    &HC0, &H99, &H93, &H0, &H83, &H2, &H6F, &H2F, &H3B, &H4A, &H73, &H1E, &H99, &HFD, &H31, &HC3,
                    &H27, &H8E, &HEE, &H49, &HB, &H7E, &HAD, &H23, &H16, &HD3, &H51, &H14, &H19, &H85, &H96, &HE5,
                    &H75, &H73, &HDB, &H50, &H79, &HC9, &HB2, &HC, &HB3, &H1A, &HC, &H19, &H45, &HB1, &HA9, &H46,
                    &HA3, &H3F, &HE4, &H65, &HB3, &H98, &H63, &HF2, &H3B, &H7A, &H3E, &HCF, &H16, &H7A, &H1E, &HB4,
                    &HBB, &H8E, &H4D, &H97, &H6F, &HA0, &HBA, &HA6, &HC1, &H76, &H29, &H29, &H2C, &H32, &H34, &H84,
                    &HCA, &HBA, &H7B, &HF7, &H90, &HCD, &H82, &HA0, &H69, &H27, &HF, &HC, &HBE, &H43, &H48, &H93,
                    &H15, &H8A, &H94, &H27, &H6E, &H70, &H73, &H96, &H63, &HCE, &HF9, &HE9, &HA7, &H34, &HC1, &HA8,
                    &H62, &H64, &H65, &HB0, &H23, &H49, &H91, &HC2, &H80, &H7D, &H19, &H97, &H5D, &HC1, &H3A, &HDA,
                    &H13, &H92, &HE4, &H14, &H1, &H76, &HE7, &H5, &HF3, &HB7, &HC2, &HAA, &HF6, &HBF, &HEA, &H26,
                    &H14, &HC5, &H77, &H46, &HCD, &H87, &H2F, &H5B, &H45, &H1B, &H12, &H55, &H25, &H1F, &H1A, &HAD,
                    &H93, &H44, &H29, &HBE, &H33, &HA3, &HEB, &H5A, &HD5, &HA6, &H1B, &HA3, &H95, &H1D, &H48, &H3D,
                    &H62, &H22, &H81, &HD3, &H8, &HEA, &HD, &H58, &H33, &HB, &H5F, &HA7, &H6F, &HBC, &HB5, &H58,
                    &HEE, &HB, &HD1, &H44, &HA6, &H6F, &H49, &H36, &H88, &HC2, &HFE, &HB4, &HA6, &HD5, &H57, &HDD,
                    &H56, &H45, &H0, &H20, &H81, &H71, &H27, &H5A, &HA6, &HFE, &H16, &HBA, &HC9, &H6A, &H98, &HD3, &H0}},
         {"Data2", {&H2F, &H55, &HFF, &HA4, &HFC, &HC, &HA5, &HBB, &H1D, &H77, &HDA, &HE7, &H33, &HAF, &H82, &H4B,
                    &H78, &HE7, &H2D, &H0, &H4, &HD, &H86, &H1B, &H4F, &H7E, &HD0, &H9F, &H1D, &HA0, &HD7, &HC3,
                    &HC4, &HFE, &H53, &H1C, &H4, &H1D, &H9C, &H9A, &H10, &H4C, &H6A, &H7D, &H73, &HB6, &H2B, &HB8,
                    &H9, &H47, &H72, &HA0, &H69, &HF8, &HC8, &H5E, &H67, &H1, &H4F, &H20, &HE0, &H53, &H67, &HC4,
                    &HF, &H4C, &HE4, &H63, &HD3, &H86, &H1E, &H33, &H99, &H41, &H31, &H79, &H1B, &HE3, &H4B, &H86,
                    &HAB, &HB0, &H8D, &H13, &H87, &H54, &H2, &H23, &H54, &H9E, &HB1, &HDD, &HD5, &HE3, &HFA, &H1E,
                    &HF, &H79, &H45, &H49, &H32, &H82, &H95, &H9B, &HD2, &HE4, &HCE, &H4C, &HA6, &HB2, &HE8, &H23,
                    &H40, &HB3, &H30, &H51, &H18, &HFF, &H70, &HA1, &HD2, &H6, &H22, &H7E, &H9D, &HAB, &H38, &HB,
                    &H54, &H5E, &H9E, &HCC, &H49, &H96, &H39, &H33, &H73, &HBC, &HF8, &H6, &H94, &H1C, &HB3, &H9C,
                    &H40, &H79, &HD0, &H67, &HA5, &HC, &HB0, &H4C, &HE, &HD4, &HA8, &H76, &H2, &HA5, &H23, &HCE,
                    &H55, &H71, &HEF, &HED, &H1, &HA7, &HFF, &H9C, &H54, &HF6, &H2A, &H7A, &H75, &H49, &HE0, &H3,
                    &HA0, &H5B, &HD7, &H16, &HA8, &HD3, &HEA, &HE5, &H4A, &H4E, &HD0, &HD8, &H8E, &H77, &H8A, &HFB,
                    &H84, &H3B, &H7F, &HC8, &H83, &H32, &H2D, &H46, &HA5, &HE1, &HB5, &H1A, &HA9, &HD0, &H64, &HC5,
                    &H8E, &H59, &H49, &HBC, &HDC, &H63, &H4B, &H66, &H9B, &H57, &HD7, &HBE, &HA9, &H31, &HB5, &HBB,
                    &H3, &H3B, &H7, &H74, &H31, &HDA, &H22, &H5, &H74, &H78, &H9F, &H1A, &H32, &H57, &HD2, &H42,
                    &HAF, &HF5, &HB9, &H1B, &HE5, &HA4, &H25, &H39, &HD9, &H3D, &H1F, &HD5, &H2B, &H40, &H26, &HBC, &H0}},
         {"Data3", {&H81, &H69, &H6C, &HF8, &HE0, &H1B, &HF0, &HB3, &HC4, &HE, &H16, &H21, &H9E, &H67, &HA2, &H1E,
                    &HAF, &H4C, &H73, &H4C, &HA4, &HEE, &H8C, &H51, &H14, &HC7, &H5B, &H87, &HCF, &H9, &HC3, &H1C,
                    &H91, &H5B, &HC7, &HF4, &H88, &H8E, &HAF, &H3C, &HB, &HCA, &H66, &H2B, &H5A, &H7A, &HED, &H38,
                    &H56, &H9B, &H19, &H8C, &H21, &HF3, &H97, &HC5, &H36, &H13, &H66, &HB5, &HA9, &H4B, &HFF, &H95,
                    &H21, &H6D, &HB0, &HDF, &H79, &H35, &HEE, &H5A, &H8, &H87, &H12, &H58, &H2, &H9D, &H1A, &H6F,
                    &HB7, &H51, &H2E, &H6B, &H5A, &HE9, &H3A, &HE6, &HA7, &H1C, &HE1, &H49, &H41, &HB5, &H9D, &H1D,
                    &HF2, &H95, &H79, &H82, &HA8, &H24, &H81, &H37, &H1D, &HB8, &H36, &HE6, &H5F, &H7B, &H1F, &H3C,
                    &HCE, &H4, &H2B, &H17, &H61, &H89, &H3A, &HD5, &H7B, &HCE, &HB, &H36, &HF4, &H0, &HFA, &HF0,
                    &H9E, &HE, &HAF, &H7, &HA4, &HFF, &HC5, &HFE, &H27, &HF1, &H7E, &HDE, &HA2, &H82, &H15, &HEF,
                    &H22, &H73, &HF9, &H48, &H7E, &H57, &HBD, &H78, &HE4, &HF9, &H38, &H8E, &HE3, &H24, &H47, &H2A,
                    &H54, &HBD, &H4B, &H1C, &H6B, &H72, &H4C, &HC5, &H23, &HF7, &HEE, &H0, &HA5, &H88, &H87, &H78,
                    &H98, &HD0, &H72, &H3E, &H8A, &HB1, &H34, &H54, &H9B, &H43, &HB6, &H3A, &H10, &H9D, &H44, &H10,
                    &H3A, &HF2, &H43, &HBD, &H51, &HF7, &HC4, &H8B, &H51, &HC8, &H3E, &H3F, &HC1, &H7, &H15, &HD3,
                    &HE6, &HFE, &HE5, &H4A, &H29, &H28, &H3A, &H89, &HF7, &HFE, &HB3, &H5A, &H25, &H64, &H2A, &H3F,
                    &H7, &H99, &HC5, &HDC, &HB5, &HCF, &H41, &HFB, &H57, &HB0, &HDA, &H1E, &H9C, &H9C, &H7C, &H6D,
                    &H3D, &HF0, &H60, &H44, &H35, &H0, &H78, &HCF, &H25, &H4D, &HB4, &H3D, &H58, &HAD, &HBC, &HA8, &H0}},
         {"Data4", {&HF7, &H95, &HF, &HC6, &H95, &H6A, &H12, &H81, &H89, &H77, &H6B, &H55, &HD1, &H5E, &H43, &HB6,
                    &HBE, &HD9, &H93, &HF7, &HD0, &H4B, &H64, &H86, &H81, &H2E, &H19, &H23, &H23, &HCB, &HBE, &HD5,
                    &H39, &HDC, &H3F, &H15, &H26, &H49, &HDE, &H23, &H99, &HA8, &H90, &H85, &HBC, &H2B, &HDE, &HAC,
                    &H8, &H2D, &H1C, &HCD, &HC3, &H2, &H8D, &HF2, &H97, &H53, &H38, &H20, &HA, &H80, &H5D, &HBD,
                    &H9, &H91, &HC2, &H79, &H9B, &H3F, &HC9, &H62, &H9F, &H56, &HA6, &HC, &HC4, &HA1, &H6E, &H89,
                    &H98, &HC3, &H2A, &H81, &H3F, &H4D, &H55, &H9B, &H2C, &H70, &H48, &HB9, &H1C, &HD3, &H75, &HD0,
                    &HDA, &HE0, &H92, &H49, &H59, &H9C, &HF1, &HBC, &H4D, &HE1, &H15, &H8B, &H6B, &H44, &HE0, &HF2,
                    &H4B, &HBE, &H74, &HC4, &HD0, &HB7, &H9E, &H50, &HCA, &HC5, &H2B, &H83, &H6E, &HD4, &H48, &HB7,
                    &H10, &H31, &HF1, &H29, &HC1, &H27, &HE0, &HFC, &H1F, &HC6, &H5, &H1F, &HAC, &H88, &H3F, &HAA,
                    &H8, &HF4, &H3F, &H2C, &HF5, &H14, &HBE, &H8E, &HC3, &H18, &HE9, &HAF, &HC9, &HA8, &H7B, &HA,
                    &HDA, &H42, &H76, &HF6, &H92, &H50, &H14, &H6E, &HAA, &HF, &HA4, &H8B, &H20, &H12, &H4F, &H83,
                    &H1D, &H96, &HD4, &HDE, &HA9, &H8F, &HB5, &HE1, &HA6, &H22, &HED, &HF8, &HA6, &HAB, &HE9, &H20,
                    &HC9, &H5F, &H28, &HDC, &HCA, &H4E, &H18, &HD0, &HE9, &H9C, &H33, &H0, &H46, &HC, &HB4, &HD4,
                    &H3C, &HF4, &H69, &HE5, &HFA, &HF5, &H14, &HA0, &HE9, &H21, &H19, &H19, &H14, &HE8, &HAC, &HEF,
                    &HD, &H8, &HBD, &H85, &H8C, &HC, &H7B, &H36, &H79, &H26, &HC0, &H5A, &HEA, &HC9, &H9E, &H91,
                    &HE7, &H57, &H7A, &HCE, &HB9, &HAF, &HD2, &H99, &H46, &H1, &HD8, &H68, &H65, &H1A, &HF5, &HAD, &H0}},
         {"Data5", {&HD1, &H4, &H32, &HEA, &H3B, &HC4, &HCF, &HE0, &HA, &H71, &H50, &H26, &H37, &H4D, &H43, &H10,
                    &H9A, &H31, &H94, &H4A, &H4C, &H6D, &HE4, &H7D, &H68, &HF2, &H97, &HDB, &H1B, &HCF, &H1E, &H9D,
                    &H95, &H3C, &HE2, &H3E, &HDE, &HB8, &H46, &HC6, &HD3, &H70, &H75, &HBE, &HA, &HC6, &H6A, &HE3,
                    &HD, &H1C, &H28, &H47, &H8E, &HFA, &H2E, &HAA, &HC8, &H0, &H61, &H3, &HC2, &H87, &H70, &H33,
                    &H95, &HBB, &H67, &HD2, &H95, &HBD, &HB0, &HED, &HD6, &H8C, &HB1, &H8A, &HA2, &HA1, &H19, &HC2,
                    &HF4, &H5B, &HBD, &H2, &H6D, &HD3, &H9F, &HC8, &HEC, &HEF, &H5F, &H7F, &H93, &H4C, &HDC, &H5,
                    &HC3, &HB1, &H66, &HAD, &H6, &H94, &H8F, &H8, &H8B, &HD, &HBA, &HC2, &H2E, &H81, &H49, &H71,
                    &H8, &H45, &HBB, &HCE, &H54, &H5C, &HF9, &H31, &H8B, &H97, &HBD, &HF4, &H7D, &H58, &H3, &H41,
                    &HBA, &H15, &H82, &H77, &H1C, &H85, &H4, &H9B, &HD3, &H41, &HBB, &HA0, &H35, &H48, &H14, &H72,
                    &H28, &H51, &HEA, &H11, &H91, &H39, &H8B, &H23, &HB1, &H74, &H9F, &H30, &H6F, &H1, &H7, &H6B,
                    &H10, &H41, &H43, &H12, &H66, &HB9, &HD1, &H88, &HAE, &HF1, &H41, &H12, &HC9, &HDD, &H3A, &H4A,
                    &HFA, &H77, &H22, &H9, &H10, &H77, &HE9, &H89, &H7F, &HDA, &HA0, &H32, &H20, &H4C, &H9E, &H37,
                    &H19, &H51, &HF0, &HA9, &H24, &H0, &H7, &H6B, &H3D, &H37, &H49, &HF9, &HCD, &HE7, &HD, &H74,
                    &H5D, &H46, &H3F, &H68, &HFB, &HE4, &H36, &H46, &H13, &HD0, &H3A, &HB1, &HD9, &H5B, &HE2, &HDC,
                    &H87, &H15, &H65, &HAF, &H23, &HF0, &H65, &H8E, &H27, &H10, &H10, &HE1, &H32, &H9, &HC2, &H8B,
                    &H5A, &H4D, &HD, &H62, &H67, &HC4, &H7A, &HD0, &H89, &H6B, &HE4, &H79, &H53, &HE5, &HA4, &HBC, &H0}},
         {"DLC1", {&H9D, &H5A, &H6F, &H3F, &H35, &HB3, &H25, &HBF, &H8E, &HCC, &H11, &H8C, &HD9, &HCA, &HC5, &H4C,
                   &H39, &HDE, &HD1, &H3B, &H8D, &H80, &H71, &HA8, &HDD, &H16, &H33, &H70, &H91, &H9, &H6E, &HD1,
                   &HDC, &HCA, &HD3, &HC6, &H1F, &HC9, &H31, &HCE, &HAA, &H33, &HC2, &HD0, &HFE, &HA0, &H9C, &H92,
                   &HB3, &H62, &H8E, &HD6, &H9B, &H9F, &HD6, &HEA, &HEF, &HC7, &H23, &H7A, &HF7, &H3F, &H35, &HA5,
                   &H3, &H1F, &HED, &HF5, &H54, &H97, &H5, &H72, &H8E, &H30, &H35, &H5B, &HE6, &H28, &H7, &HE,
                   &H2C, &HFB, &HB9, &H9C, &H92, &H4C, &H40, &HDA, &H20, &H90, &H5E, &H16, &H9C, &H6C, &HB3, &H54,
                   &H34, &H4B, &H9C, &HA5, &H6A, &H4, &H5, &H48, &HE3, &H13, &H8E, &HA7, &H43, &H99, &H7A, &H81,
                   &H82, &H8B, &H4D, &HE3, &H75, &H57, &H12, &HCA, &HA8, &H5, &H93, &HB3, &H6D, &HE, &HD8, &HBA,
                   &HEA, &HD9, &HE2, &HB7, &H58, &H55, &HE3, &H58, &H46, &H27, &HB1, &HDE, &H80, &HCB, &H88, &H75,
                   &H21, &HFA, &HD3, &H2A, &H5A, &H4C, &HC2, &H37, &HD1, &H76, &H1F, &H52, &HD0, &H1A, &HCE, &HF0,
                   &H63, &HB, &H55, &H64, &H2, &HFD, &HF9, &HD5, &H42, &H67, &H58, &HC8, &HD5, &HAA, &H2A, &H43,
                   &H43, &HD0, &HA2, &HEB, &HBB, &H1B, &H12, &HFE, &HC3, &H9F, &HA9, &HBC, &H21, &H1C, &HA9, &H4D,
                   &H2B, &HBE, &HD9, &H20, &HC3, &HC, &H78, &HBA, &HC1, &HA2, &H1, &H3C, &H87, &H23, &H6E, &H5B,
                   &HC9, &H87, &H87, &HDE, &H8, &H86, &HBA, &H85, &H2A, &H5C, &HC1, &HA5, &HB0, &H3C, &H49, &HA1,
                   &H72, &HCE, &HF7, &H95, &H8B, &H8A, &HC, &H25, &HD9, &H62, &H28, &H2D, &H6A, &H23, &HE6, &H1A,
                   &HEF, &HF2, &H35, &HDC, &HA7, &H88, &H50, &HE, &HA2, &HCD, &H70, &HD1, &HF5, &H8C, &H21, &HB0, &H0}},
         {"DLC2", {&HF5, &H5E, &H1A, &HE4, &H4C, &HC1, &HFB, &H92, &H37, &HAC, &H5E, &H89, &H82, &HCD, &HC3, &HAF,
                   &HFC, &HE8, &HFE, &HBE, &HB9, &H84, &H23, &H55, &H59, &HC8, &H51, &H6B, &HDA, &H4, &H24, &H17,
                   &H4A, &HBA, &H2F, &H36, &H21, &H24, &HBD, &HA0, &HAF, &H22, &H57, &HB8, &HF3, &H28, &HAC, &H3B,
                   &H81, &HE1, &HA0, &H3E, &H66, &H9, &H1B, &HC, &HC8, &HEF, &H5C, &HDB, &HB8, &H73, &H1E, &H1B,
                   &H7, &HD4, &H9E, &HC3, &HB0, &H68, &HF9, &HEA, &H8E, &H8D, &HF2, &H73, &H14, &HFC, &H31, &HDB,
                   &H8F, &H3C, &HCB, &HE5, &HF8, &H5A, &H7A, &HB3, &H2A, &H32, &H55, &H34, &H7, &HFA, &HFB, &HE6,
                   &HC4, &HEC, &H5E, &H39, &H58, &HAD, &H31, &HC8, &HBC, &HB4, &H76, &H6D, &H57, &HD, &H35, &H73,
                   &H2C, &HBB, &HF7, &H62, &H27, &HE6, &H7B, &H51, &HF2, &HA4, &HEB, &HE5, &H11, &HA5, &H61, &HB9,
                   &H2B, &HA0, &HC6, &H99, &H99, &H40, &H1B, &H91, &H89, &H8C, &HDF, &H59, &H6, &H6, &H6C, &H8C,
                   &H4D, &HCC, &H9, &H2D, &HFB, &HD9, &HAA, &HCE, &H6E, &H6A, &HD1, &H6E, &H1E, &H64, &HDC, &H64,
                   &H13, &HFF, &HC4, &HF1, &HB1, &H12, &H28, &HCC, &HB2, &HAE, &H3B, &HE7, &HEB, &H54, &HDB, &H2F,
                   &H32, &HAB, &HC3, &HE0, &H5E, &H90, &HD3, &H26, &H10, &H23, &HBF, &H51, &H3E, &H73, &H9, &H3,
                   &HCC, &H82, &HED, &H32, &H3C, &H8F, &H2B, &HAF, &H98, &HFB, &H64, &HB, &HF9, &H5, &H7E, &H15,
                   &H5E, &HD5, &H1, &H94, &H8, &H64, &H2F, &HAE, &HBB, &HE2, &H91, &H95, &H2E, &H3C, &H81, &HE4,
                   &HBB, &H37, &H61, &H80, &H9C, &HC5, &HF2, &H6A, &H7C, &H3A, &HBC, &H88, &HF6, &H58, &H6C, &HFE,
                   &HD3, &H69, &H1F, &HA3, &H50, &HDA, &HAA, &H68, &HC5, &H4, &HC6, &HAF, &HF5, &HD4, &H25, &HB4, &H0}},
         {"Data1Sekiro", {&H4D, &H7F, &HEE, &H10, &H44, &HD, &HEE, &HF3, &H53, &H85, &H38, &H60, &H73, &HD3, &H28, &HD5, &H74,
                                &H12, &H96, &HBE, &HDF, &H66, &H2F, &HEF, &H36, &H43, &H2B, &HD7, &HFF, &HE6, &H67, &HC0, &HAB,
                                &H50, &HBA, &H40, &H5F, &HC, &HBC, &HF7, &HBF, &HAF, &H5E, &HE7, &H5B, &H61, &H14, &HC, &HD0,
                                &H51, &H7, &HE4, &HB8, &H9D, &H26, &HBA, &HF2, &HC4, &H77, &H56, &HDF, &HF8, &HAF, &H40, &HD1,
                                &H67, &HF, &HD0, &HA1, &H28, &HE6, &H5C, &H30, &HB, &HB3, &HA8, &HBB, &H7, &H88, &HF7, &H50,
                                &H34, &HB, &H6, &H98, &H41, &H6C, &H1C, &H36, &HFE, &HBC, &H9D, &HFE, &HBB, &H61, &H67, &H72,
                                &H1B, &H45, &HDE, &H6D, &H7, &H79, &HB, &HB9, &H9B, &H30, &H38, &H8, &HC3, &HA7, &H12, &H78,
                                &HBD, &H88, &HDB, &HF1, &H90, &H76, &HCE, &HF7, &HEE, &H83, &H13, &H9D, &H78, &H9B, &HC2, &H42,
                                &H46, &H4D, &HDF, &H1C, &H47, &H41, &HD5, &H81, &HB2, &HE8, &H9D, &HFE, &H49, &HC8, &HDA, &H96,
                                &HF3, &H57, &H3, &H26, &H77, &H11, &HE6, &H2A, &H36, &H4, &H8B, &H29, &HBE, &HBC, &H65, &H34,
                                &HE8, &H42, &HA, &HFB, &H54, &H5C, &HDC, &H8C, &H4A, &HC9, &H8C, &HA3, &H2, &H60, &H61, &HA1,
                                &HFF, &H23, &H8B, &H62, &H8F, &HAD, &H8E, &H76, &H67, &H0, &HAA, &H2A, &H2D, &HCD, &H3C, &H7B,
                                &HC4, &HD0, &HB, &HFE, &H11, &HBF, &HDB, &HEF, &HD3, &H29, &H9B, &H38, &H1D, &H4F, &HBA, &HEA,
                                &HDF, &HA2, &H79, &HCF, &HB2, &HF5, &H23, &H65, &HFD, &HC9, &H8E, &HFC, &H12, &HB2, &HEE, &HFC,
                                &H71, &H4C, &H4C, &HE1, &HEF, &HBF, &H56, &HD5, &H7D, &H34, &HFA, &H86, &H73, &HA7, &HFA, &H9B,
                                &H1B, &H4D, &HAF, &HBA, &HDF, &HCE, &HE6, &H5E, &H69, &H75, &H6C, &H1, &H7E, &H69, &HF7, &H0}},
         {"Data3Sekiro", {&H43,
                                &HED, &H91, &H4C, &HD4, &H1F, &H2, &HE0, &HB9, &HF0, &H19, &HE4, &H85, &H14, &H67, &H41, &H85,
                                &HFC, &H29, &H29, &HD7, &H5E, &HC4, &HFB, &H2, &H25, &H49, &H96, &HBF, &H36, &H18, &H9E, &H6B,
                                &HCC, &H31, &H44, &H78, &HE1, &HD1, &H32, &H17, &HB7, &HB4, &HA6, &H21, &HDC, &HDA, &H42, &HC7,
                                &HD1, &H59, &H60, &HE3, &H5F, &H96, &HAC, &H4C, &H76, &HAF, &H11, &H8E, &HDC, &HBD, &H39, &H34,
                                &H78, &H8E, &H9, &HC3, &HA1, &H4F, &H9A, &H7F, &H8D, &H11, &H5F, &H5A, &H17, &H83, &H5D, &H4C,
                                &H37, &H54, &H32, &H20, &HAC, &HA8, &H7, &HBF, &H22, &H2E, &HB5, &H8C, &HED, &H71, &HE1, &H9B,
                                &H86, &H9D, &H63, &HC3, &H75, &H3D, &H90, &H9B, &H41, &H73, &H7C, &H3D, &H46, &H9E, &H35, &HF0,
                                &H86, &H6C, &H40, &H32, &H5, &H0, &H7D, &H4E, &H18, &H1B, &H92, &HBD, &H50, &HFE, &H6F, &HEB,
                                &H86, &H8C, &H17, &H83, &H77, &H29, &H19, &HA6, &HBB, &HF1, &H22, &H2, &H6D, &H75, &H6C, &H56,
                                &H3C, &H69, &H7E, &HFB, &HD9, &H5C, &H2B, &H42, &HFD, &H47, &H92, &H25, &H54, &HA2, &H90, &H74,
                                &H6A, &H4D, &H33, &H85, &H44, &H66, &HF2, &HEB, &HBD, &HB9, &H90, &H26, &HF3, &H26, &H30, &HF4,
                                &H95, &H31, &H8E, &H8, &HE4, &HDA, &H5C, &HA7, &H26, &H3E, &HCF, &H4B, &HEE, &H11, &HB4, &HAF,
                                &H5B, &HD1, &HB1, &H82, &H1D, &HAE, &H4, &HF6, &H99, &HCA, &HC5, &H64, &H2E, &H29, &HB1, &H85,
                                &H23, &H6E, &HB6, &H94, &HF6, &H29, &H91, &H4B, &H79, &H79, &H85, &H68, &HD6, &H9C, &H10, &HF,
                                &H56, &H10, &H9B, &H89, &H70, &H88, &H8F, &HED, &H2E, &HF4, &H7C, &H6, &H7E, &H37, &HDA, &H6C,
                                &H59, &HA1, &HC0, &H0, &H5B, &H48, &HF0, &H2, &H1D, &HE8, &H8B, &H80, &HE5, &H98, &HC7, &H0}},
         {"Data2Sekiro", {&H53,
                                &H93, &H47, &H96, &HE9, &HD1, &H83, &H37, &H25, &HB2, &H54, &H86, &HE5, &HB4, &H36, &HA9, &H74,
                                &H3A, &HB5, &HF3, &H4E, &H48, &H57, &HA2, &H99, &H85, &H87, &H54, &H77, &H8F, &H91, &H69, &H76,
                                &H54, &HCE, &H66, &H6, &H45, &HCB, &HE7, &H70, &HE2, &H9A, &H83, &HB0, &HC1, &H27, &HB1, &H8B,
                                &HA2, &H90, &H83, &H73, &HC3, &H67, &H3A, &H84, &HA5, &HCC, &H53, &HA3, &H4D, &HE3, &H32, &HE8,
                                &HE1, &HF2, &H3E, &H97, &H70, &HE, &H3, &H58, &H27, &H75, &H8B, &H4A, &H69, &H43, &H42, &H3C,
                                &H12, &H80, &H2D, &H74, &H9, &H4D, &H7E, &H19, &H77, &HE1, &HEC, &H5D, &H87, &H99, &HDF, &H55,
                                &H6B, &H79, &H6A, &H89, &H20, &HE9, &H48, &H6A, &H66, &H45, &H86, &H20, &H9E, &HC8, &HA2, &H4,
                                &H44, &H1F, &H2B, &H5E, &H83, &H85, &HF6, &HED, &H12, &HE6, &H15, &HFE, &H5D, &H10, &H38, &H6E,
                                &H5A, &H88, &HAA, &HE2, &HA9, &HAB, &H49, &H93, &H50, &HE5, &H61, &HCE, &H64, &HE9, &HAC, &H87,
                                &HE0, &H7A, &H55, &HD7, &H6B, &HA8, &H78, &H2B, &H1C, &HAB, &HCE, &H85, &HD6, &H2A, &HB3, &H9E,
                                &H1F, &HC5, &H83, &HC3, &H37, &HDC, &H83, &HE9, &HDA, &H33, &H97, &H40, &HBE, &HB1, &H37, &HF0,
                                &H3F, &H8E, &H13, &HFD, &H4A, &H92, &H80, &H16, &HE2, &HA2, &HC8, &H37, &H3B, &H75, &H5F, &H85,
                                &H2B, &H82, &H8C, &H1C, &HB, &HE1, &HFD, &H23, &HD1, &H7E, &HEB, &H8D, &H94, &HA3, &H29, &H2A,
                                &H4A, &H87, &HDE, &HFF, &HE3, &H60, &HE, &H51, &HBB, &HEF, &H76, &HF, &H54, &H85, &HE6, &H19,
                                &HC, &H93, &H30, &H3D, &H4A, &HFD, &HF4, &HBD, &HC8, &H57, &HE1, &H25, &HA0, &H65, &H90, &HD0,
                                &HE9, &H48, &HD6, &HC8, &HA4, &H4C, &H2C, &H5C, &HF1, &H97, &H15, &H4E, &HE8, &H18, &HAA, &H0}},
         {"Data4Sekiro", {&H81,
                                &HE9, &H1D, &H7, &H13, &H81, &H9E, &HBA, &HF, &H3A, &HAA, &HE6, &H5E, &H30, &HC4, &HE, &H5E,
                                &HC0, &HE3, &H3F, &H2B, &H99, &HD3, &H9A, &HB0, &HCA, &HA5, &H4D, &H3A, &H4F, &H41, &H2F, &H3C,
                                &HEB, &HFD, &H96, &H3E, &H26, &H2, &H8B, &HF2, &H7D, &H23, &H29, &H62, &H66, &H6A, &H20, &H7F,
                                &HC9, &H4C, &HB5, &HF0, &H81, &H8A, &H5B, &HF2, &H2D, &H37, &H79, &HC, &HD9, &H93, &H11, &H3D,
                                &HDB, &HED, &HF8, &H70, &H50, &H1B, &HA7, &H9D, &H2F, &HFE, &HCD, &H28, &HA7, &H51, &H6F, &HEE,
                                &HFE, &HB2, &HD3, &HB, &H69, &HBA, &H1, &H70, &H5E, &HCF, &H25, &HE8, &H87, &H5, &H96, &HEE,
                                &HA5, &H9E, &H85, &HE7, &H37, &H66, &H29, &HAB, &H2B, &HBB, &H54, &H2, &HE8, &H37, &H4F, &HB1,
                                &H4A, &H8F, &H38, &HD2, &H14, &H88, &HCB, &H3, &HFC, &H6, &HDE, &HD8, &H32, &HFF, &H9C, &HAF,
                                &HAE, &H62, &H26, &H88, &H13, &HFE, &H4B, &HBB, &H72, &HE8, &HE0, &HCE, &H4D, &H7A, &H2, &HDA,
                                &HE3, &H41, &H46, &H49, &HF4, &HFC, &HC0, &HB7, &HCD, &H11, &H9C, &HBC, &H9F, &H80, &HBC, &HAB,
                                &H44, &HDE, &H9F, &HE6, &H7F, &H13, &H70, &H4D, &HCB, &HA6, &HDA, &HFC, &H99, &H2C, &H69, &HE3,
                                &HB5, &H99, &H8E, &HB9, &H7A, &H10, &HD8, &H5E, &H46, &HA3, &H16, &H5B, &H68, &H18, &H20, &H72,
                                &H4F, &H1C, &HBB, &H59, &HB4, &HFD, &H2D, &H6F, &H7E, &HED, &H68, &HC1, &H64, &H69, &H20, &HAD,
                                &H24, &H10, &H50, &HC7, &H9A, &HDF, &H25, &H6F, &HAD, &HD0, &HAC, &H1D, &H9C, &H7F, &H3C, &HA6,
                                &HCB, &H3B, &H94, &H25, &HA0, &H69, &HC4, &H92, &H92, &H66, &H4A, &HC3, &H49, &HF2, &H5E, &H61,
                                &HD1, &H40, &H1D, &HC0, &H12, &H73, &H0, &HA3, &H7A, &H3E, &HB9, &H2, &H72, &HC4, &HAB, &H0}},
         {"Data5Sekiro", {&HEB,
                                &HD5, &H7C, &H6D, &H2C, &H97, &H65, &HC7, &HA, &HDC, &H53, &H2E, &H6, &HA5, &HEF, &H63, &HA1,
                                &HEE, &H82, &HF0, &H4F, &H78, &H4A, &H22, &H4C, &HEA, &HFC, &H4, &H28, &HBD, &H4D, &H3D, &HB9,
                                &H4D, &H12, &HA8, &HD4, &H7, &HAC, &H26, &HC5, &H5D, &H8A, &H24, &HEC, &H58, &HB2, &HE2, &HA7,
                                &H1F, &H7E, &HA7, &HBE, &HE1, &H72, &H26, &HCB, &H8D, &HA0, &HD6, &HAE, &H6E, &HFF, &H48, &HD6,
                                &H87, &H84, &H58, &HB4, &H1D, &HD6, &H10, &H41, &HF, &H77, &HAB, &H7D, &H7C, &H73, &HEB, &H14,
                                &H5C, &HC6, &HCF, &H47, &H10, &H77, &H60, &HD1, &H83, &HFB, &H21, &HAE, &H4E, &HF5, &H72, &H9E,
                                &HA, &HD3, &H2F, &H4, &HA6, &H59, &HF, &H8F, &HE6, &H81, &HAF, &H79, &H3, &HD4, &HC1, &HFF,
                                &H75, &H23, &H4B, &H25, &HA8, &HFD, &H13, &H41, &HE0, &HC5, &H7F, &H1F, &H3F, &HF8, &HF7, &H99,
                                &H3E, &HF5, &H4C, &HD0, &H9, &H2E, &H20, &H6F, &HD5, &HAC, &H70, &H2B, &H12, &HAB, &H8C, &HAF,
                                &H1, &HC4, &HE4, &H63, &HE1, &HBB, &HFE, &H70, &H48, &HEB, &H29, &H50, &HB9, &HD6, &H3F, &H4,
                                &HBC, &HBE, &H1B, &H92, &H35, &H47, &H58, &H91, &HB7, &HA7, &H20, &H9, &HE2, &H51, &H75, &HF0,
                                &HA, &H5F, &H73, &HBF, &H67, &H21, &HB6, &HB6, &H7A, &HD3, &H2B, &H96, &H3A, &H38, &HD3, &HA2,
                                &HE6, &H5A, &HF5, &HD9, &HAC, &H29, &H2E, &HAE, &H40, &H36, &H15, &H2C, &HC9, &HCD, &H65, &HB6,
                                &H62, &H3E, &HAC, &H6E, &H38, &HCC, &H6D, &H2C, &H81, &H98, &HB1, &H51, &H59, &H59, &H7, &H6D,
                                &HBE, &H27, &H1E, &HFD, &H30, &H49, &H2D, &H2D, &H50, &H60, &H99, &HB, &HC, &HBA, &HEB, &HEC,
                                &HD8, &H9, &H4F, &H3D, &H9E, &HFE, &HEE, &HDB, &H1D, &HF0, &HB5, &H51, &H7F, &HBE, &HBB, &H0}}
    }



    Public expDict As Dictionary(Of String, Byte()) = New Dictionary(Of String, Byte()) From
        {{"Data1", {&H49, &H5B, &H7E, &HB}}, {"Data2", {&H9, &HE2, &HAE, &H2F}}, {"Data3", {&H57, &HCD, &HC5, &HB}},
         {"Data4", {&HB7, &H3A, &HA6, &H2F}}, {"Data5", {&HF7, &H33, &H4B, &H15}}, {"DLC1", {&H63, &HF2, &HEC, &H15}}, {"DLC2", {&H2F, &H99, &H0, &H1F}},
         {"Data1Sekiro", {&H27, &HF9, &H48, &H2A}}, {"Data2Sekiro", {&H91, &H29, &HF1, &HFF}}, {"Data3Sekiro", {&H4F, &HA1, &H55, &HEA}}, {"Data4Sekiro", {&H87, &H8E, &HCD, &H18}}, {"Data5Sekiro", {&HC7, &H4C, &H51, &HF9}}}

End Module