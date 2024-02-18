using System.Collections.Generic;

//Shop Data Holder
[System.Serializable] public class CharactersShopData
{
	public List<int> purchasedCharactersIndexes = new List<int> ();
}

[System.Serializable] public class CharactersShopData2
{
	public List<int> purchasedCharactersIndexes2 = new List<int> ();
}

[System.Serializable] public class PlayerData
{
    public string nombre;
    public int coins = 0;
    public int exp = 0;
    public int expTotal = 0;
    public int requisito = 20;
    public int etapa = 0;
    public int etapaMaxima = 3;
    public int A111J = 0;
    public int A111S = 0;
    public int A112J = 0;
    public int A112S = 0;
    public int A113J = 0;
    public int A113S = 0;
    public int A114J = 0;
    public int A114S = 0;
    public int A12J = 0;
    public int A12S = 0;
    public int A13J = 0;
    public int A13S = 0;
    public int A14J = 0;
    public int A14S = 0;
    public int A15J = 0;
    public int A15S = 0;
    public int A1502J = 0;
    public int A1502S = 0;
    public int A161J = 0;
    public int A161S = 0;
    public int A162J = 0;
    public int A162S = 0;
    public int A163J = 0;
    public int A163S = 0;
    public int A17J = 0;
    public int A17S = 0;
    public int A18J = 0;
    public int A18S = 0;
    public int A19J = 0;
    public int A19S = 0;
    public int A110J = 0;
    public int A110S = 0;
    public int A1111J = 0;
    public int A1111S = 0;
    public int A1112J = 0;
    public int A1112S = 0;
    public int A1113J = 0;
    public int A1113S = 0;
    public int A1doceJ = 0;
    public int A1doceS = 0;
    public int A1xceJ = 0;
    public int A1xceS = 0;
    public int A1catorceJ = 0;
    public int A1catorceS = 0;
    public int A1151J = 0;
    public int A1151S = 0;
    public int A1152J = 0;
    public int A1152S = 0;
    public int A1153J = 0;
    public int A1153S = 0;
    public int A211J = 0;
    public int A211S = 0;
    public int A212J = 0;
    public int A212S = 0;
    public int A213J = 0;
    public int A213S = 0;
    public int A214J = 0;
    public int A214S = 0;
    public int A221J = 0;
    public int A221S = 0;
    public int A222J = 0;
    public int A222S = 0;
    public int A223J = 0;
    public int A223S = 0;
    public int A224J = 0;
    public int A224S = 0;
    public int A23J = 0;
    public int A23S = 0;
    public int A241J = 0;
    public int A241S = 0;
    public int A242J = 0;
    public int A242S = 0;
    public int A243J = 0;
    public int A243S = 0;
    public int A26J = 0;
    public int A26S = 0;
    public int A27J = 0;
    public int A27S = 0;
    public int A281J = 0;
    public int A281S = 0;
    public int A282J = 0;
    public int A282S = 0;
    public int A283J = 0;
    public int A283S = 0;
    public int A33J = 0;
    public int A33S = 0;
    public int A34J = 0;
    public int A34S = 0;
    public int A351J = 0;
    public int A351S = 0;
    public int A352J = 0;
    public int A352S = 0;
    public int A353J = 0;
    public int A353S = 0;
    public int A354J = 0;
    public int A354S = 0;
    public int A36J = 0;
    public int A36S = 0;
    public int A37J = 0;
    public int A37S = 0;
    public int A381J = 0;
    public int A381S = 0;
    public int A382J = 0;
    public int A382S = 0;
    public int A383J = 0;
    public int A383S = 0;
    public int A39J = 0;
    public int A39S = 0;
    public int A310J = 0;
    public int A310S = 0;
    public int A41J = 0;
    public int A41S = 0;
    public int A42J = 0;
    public int A42S = 0;
    public int A43J = 0;
    public int A43S = 0;
    public int A44J = 0;
    public int A44S = 0;
    public int A451J = 0;
    public int A451S = 0;
    public int A452J = 0;
    public int A452S = 0;
    public int A453J = 0;
    public int A453S = 0;
    public int A46J = 0;
    public int A46S = 0;
    public int A471J = 0;
    public int A471S = 0;
    public int A472J = 0;
    public int A472S = 0;
    public int A473J = 0;
    public int A473S = 0;
    public int A481J = 0;
    public int A481S = 0;
    public int A482J = 0;
    public int A482S = 0;
    public int A483J = 0;
    public int A483S = 0;
    public int A491J = 0;
    public int A491S = 0;
    public int A492J = 0;
    public int A492S = 0;
    public int A493J = 0;
    public int A493S = 0;
    public int A410J = 0;
    public int A410S = 0;
    public int A4111J = 0;
    public int A4111S = 0;
    public int A4112J = 0;
    public int A4112S = 0;
    public int A4113J = 0;
    public int A4113S = 0;
    public int A4121J = 0;
    public int A4121S = 0;
    public int A4122J = 0;
    public int A4122S = 0;
    public int A4123J = 0;
    public int A4123S = 0;
    public int A511J = 0;
    public int A511S = 0;
    public int A512J = 0;
    public int A512S = 0;
    public int A513J = 0;
    public int A513S = 0;
    public int A514J = 0;
    public int A514S = 0;
    public int A515J = 0;
    public int A515S = 0;
    public int A516J = 0;
    public int A516S = 0;
    public int A52J = 0;
    public int A52S = 0;
    public int A531J = 0;
    public int A531S = 0;
    public int A532J = 0;
    public int A532S = 0;
    public int A533J = 0;
    public int A533S = 0;
    public int A541J = 0;
    public int A541S = 0;
    public int A542J = 0;
    public int A542S = 0;
    public int A543J = 0;
    public int A543S = 0;
    public int A551J = 0;
    public int A551S = 0;
    public int A552J = 0;
    public int A552S = 0;
    public int A553J = 0;
    public int A553S = 0;
    public int A554J = 0;
    public int A554S = 0;
    public int A56J = 0;
    public int A56S = 0;
    public int A57J = 0;
    public int A57S = 0;
    public int A581J = 0;
    public int A581S = 0;
    public int A582J = 0;
    public int A582S = 0;
    public int A583J = 0;
    public int A583S = 0;
    public int A584J = 0;
    public int A584S = 0;
    public int A59J = 0;
    public int A59S = 0;
    public int A5101J = 0;
    public int A5101S = 0;
    public int A5102J = 0;
    public int A5102S = 0;
    public int A5103J = 0;
    public int A5103S = 0;
    public int A5111J = 0;
    public int A5111S = 0;
    public int A5112J = 0;
    public int A5112S = 0;
    public int A5113J = 0;
    public int A5113S = 0;
    public int A5121J = 0;
    public int A5121S = 0;
    public int A5122J = 0;
    public int A5122S = 0;
    public int A5123J = 0;
    public int A5123S = 0;
    public int A5124J = 0;
    public int A5124S = 0;
    public int A611J = 0;
    public int A611S = 0;
    public int A612J = 0;
    public int A612S = 0;
    public int A62J = 0;
    public int A62S = 0;
    public int A631J = 0;
    public int A631S = 0;
    public int A632J = 0;
    public int A632S = 0;
    public int A633J = 0;
    public int A633S = 0;
    public int A634J = 0;
    public int A634S = 0;
    public int A635J = 0;
    public int A635S = 0;
    public int A64J = 0;
    public int A64S = 0;
    public int A642J = 0;
    public int A642S = 0;
    public int A643J = 0;
    public int A643S = 0;
    public int A644J = 0;
    public int A644S = 0;
    public int A645J = 0;
    public int A645S = 0;
    public int A65J = 0;
    public int A65S = 0;
    public int A66J = 0;
    public int A66S = 0;
    public int A671J = 0;
    public int A671S = 0;
    public int A672J = 0;
    public int A672S = 0;
    public int A673J = 0;
    public int A673S = 0;
    public int A674J = 0;
    public int A674S = 0;
    public int A681J = 0;
    public int A681S = 0;
    public int A682J = 0;
    public int A682S = 0;
    public int A683J = 0;
    public int A683S = 0;
    public int A691J = 0;
    public int A691S = 0;
    public int A692J = 0;
    public int A692S = 0;
    public int A693J = 0;
    public int A693S = 0;
    public int A610J = 0;
    public int A610S = 0;
    public int A6102J = 0;
    public int A6102S = 0;
    public int A6103J = 0;
    public int A6103S = 0;
    public int A6111J = 0;
    public int A6111S = 0;
    public int A6112J = 0;
    public int A6112S = 0;
    public int A6113J = 0;
    public int A6113S = 0;
    public int A6114J = 0;
    public int A6114S = 0;
    public int A6121J = 0;
    public int A6121S = 0;
    public int A6122J = 0;
    public int A6122S = 0;
    public int A6123J = 0;
    public int A6123S = 0;
    public int A6124J = 0;
    public int A6124S = 0;
    public int A6131J = 0;
    public int A6131S = 0;
    public int A6132J = 0;
    public int A6132S = 0;
    public int A6133J = 0;
    public int A6133S = 0;
    public int A6134J = 0;
    public int A6134S = 0;
    public int A6141J = 0;
    public int A6141S = 0;
    public int A6142J = 0;
    public int A6142S = 0;
    public int A6143J = 0;
    public int A6143S = 0;
    public int A6151J = 0;
    public int A6151S = 0;
    public int A6152J = 0;
    public int A6152S = 0;
    public int A6153J = 0;
    public int A6153S = 0;
    public int A6161J = 0;
    public int A6161S = 0;
    public int A6162J = 0;
    public int A6162S = 0;
    public int A6163J = 0;
    public int A6163S = 0;
    public int A711J = 0;
    public int A711S = 0;
    public int A712J = 0;
    public int A712S = 0;
    public int A713J = 0;
    public int A713S = 0;
    public int A714J = 0;
    public int A714S = 0;
    public int A715J = 0;
    public int A715S = 0;
    public int A721J = 0;
    public int A721S = 0;
    public int A722J = 0;
    public int A722S = 0;
    public int A723J = 0;
    public int A723S = 0;
    public int A731J = 0;
    public int A731S = 0;
    public int A732J = 0;
    public int A732S = 0;
    public int A733J = 0;
    public int A733S = 0;
    public int A74J = 0;
    public int A74S = 0;
    public int A751J = 0;
    public int A751S = 0;
    public int A752J = 0;
    public int A752S = 0;
    public int A753J = 0;
    public int A753S = 0;
    public int A76J = 0;
    public int A76S = 0;
    public int A771J = 0;
    public int A771S = 0;
    public int A772J = 0;
    public int A772S = 0;
    public int A773J = 0;
    public int A773S = 0;
    public int A79J = 0;
    public int A79S = 0;
    public int A792J = 0;
    public int A792S = 0;
    public int A793J = 0;
    public int A793S = 0;
    public int A7101J = 0;
    public int A7101S = 0;
    public int A7102J = 0;
    public int A7102S = 0;
    public int A7103J = 0;
    public int A7103S = 0;
    public int A25DA = 0;
    public int A25DE = 0;
    public int A25DI = 0;
    public int A25DO = 0;
    public int A25DU = 0;
    public int A25LA = 0;
    public int A25LE = 0;
    public int A25LI = 0;
    public int A25LO = 0;
    public int A25LU = 0;
    public int A25MA = 0;
    public int A25ME = 0;
    public int A25MI = 0;
    public int A25MO = 0;
    public int A25MU = 0;
    public int A25NA = 0;
    public int A25NE = 0;
    public int A25NI = 0;
    public int A25NO = 0;
    public int A25NU = 0;
    public int A25PA = 0;
    public int A25PE = 0;
    public int A25PI = 0;
    public int A25PO = 0;
    public int A25PU = 0;
    public int A25SA = 0;
    public int A25SE = 0;
    public int A25SI = 0;
    public int A25SO = 0;
    public int A25SU = 0;
    public int A31A = 0;
    public int A31D = 0;
    public int A31E = 0;
    public int A31F = 0;
    public int A31I = 0;
    public int A31L = 0;
    public int A31M = 0;
    public int A31N = 0;
    public int A31O = 0;
    public int A31P = 0;
    public int A31R = 0;
    public int A31S = 0;
    public int A31T = 0;
    public int A31U = 0;
    public int A321 = 0;
    public int A322 = 0;
    public int A323 = 0;
    public int A324 = 0;
    public int A325 = 0;
    public int A326 = 0;
    public int A327 = 0;
    public int A328 = 0;
    public int A329 = 0;
    public int A3210 = 0;
    public int A3211 = 0;
    public int A3212 = 0;
    public int A3213 = 0;
    public int A3214 = 0;
    public int A3215 = 0;
    public int A781 = 0;
    public int A782 = 0;
    public int A783 = 0;
    public int A784 = 0;
    public int A785 = 0;
    public int A25DAS = 0;
    public int A25DES = 0;
    public int A25DIS = 0;
    public int A25DOS = 0;
    public int A25DUS = 0;
    public int A25LAS = 0;
    public int A25LES = 0;
    public int A25LIS = 0;
    public int A25LOS = 0;
    public int A25LUS = 0;
    public int A25MAS = 0;
    public int A25MES = 0;
    public int A25MIS = 0;
    public int A25MOS = 0;
    public int A25MUS = 0;
    public int A25NAS = 0;
    public int A25NES = 0;
    public int A25NIS = 0;
    public int A25NOS = 0;
    public int A25NUS = 0;
    public int A25PAS = 0;
    public int A25PES = 0;
    public int A25PIS = 0;
    public int A25POS = 0;
    public int A25PUS = 0;
    public int A25SAS = 0;
    public int A25SES = 0;
    public int A25SIS = 0;
    public int A25SOS = 0;
    public int A25SUS = 0;
    public int A31AS = 0;
    public int A31DS = 0;
    public int A31ES = 0;
    public int A31FS = 0;
    public int A31IS = 0;
    public int A31LS = 0;
    public int A31MS = 0;
    public int A31NS = 0;
    public int A31OS = 0;
    public int A31PS = 0;
    public int A31RS = 0;
    public int A31SS = 0;
    public int A31TS = 0;
    public int A31US = 0;
    public int A321S = 0;
    public int A322S = 0;
    public int A323S = 0;
    public int A324S = 0;
    public int A325S = 0;
    public int A326S = 0;
    public int A327S = 0;
    public int A328S = 0;
    public int A329S = 0;
    public int A3210S = 0;
    public int A3211S = 0;
    public int A3212S = 0;
    public int A3213S = 0;
    public int A3214S = 0;
    public int A3215S = 0;
    public int A781S = 0;
    public int A782S = 0;
    public int A783S = 0;
    public int A784S = 0;
    public int A785S = 0;
    public int A81 = 0;
    public int A82 = 0;
    public int A83 = 0;
    public int A84 = 0;
    public int A85 = 0;
    public int A86 = 0;
    public int A87 = 0;
    public int A88= 0;
    public int A891 = 0;
    public int A892 = 0;
    public int A893 = 0;
    public int A810 = 0;

    



    

    public int selectedCharacterIndex = 0;
    public int selectedCharacterIndex2 = 0;
}

public static class Neuro
{
	static PlayerData playerData = new PlayerData ();
	static CharactersShopData charactersShopData = new CharactersShopData ();
    static CharactersShopData2 charactersShopData2 = new CharactersShopData2 ();

	static Character selectedCharacter;
    static Character2 selectedCharacter2;

    static Neuro()
    {
        LoadPlayerData();
        LoadCharactersShopData();
        LoadCharactersShopData2();

    }

    public static Character GetSelectedCharacter(){return selectedCharacter;}

    public static Character2 GetSelectedCharacter2(){return selectedCharacter2;}

    public static void SetSelectedCharacter(Character character, int index)
    {
        selectedCharacter = character;
        playerData.selectedCharacterIndex = index;
        SavePlayerData();
    }

    public static void SetSelectedCharacter2(Character2 character2, int index)
    {
        selectedCharacter2 = character2;
        playerData.selectedCharacterIndex2 = index;
        SavePlayerData();
    }

    public static int GetSelectedCharacterIndex(){return playerData.selectedCharacterIndex;}

    public static int GetSelectedCharacterIndex2(){return playerData.selectedCharacterIndex2;}

    public static void SetNombre(string s)
    {
        playerData.nombre = s;
        SavePlayerData();
    }
    

    

    public static int GetCoins ()
    {
        return playerData.coins;
    }

    public static int GetExp ()
    {
        return playerData.exp;
    }

    public static int GetExpTotal ()
    {
        return playerData.expTotal;
    }

    public static int GetEtapa ()
    {
        return playerData.etapa;
    }

    public static string GetNombre ()
    {
        return playerData.nombre;
    }



    public static int GetA111J ()
    {
        return playerData.A111J;
    }

    public static int GetA111S ()
    {
        return playerData.A111S;
    }

    public static int GetA112J ()
    {
        return playerData.A112J;
    }

    public static int GetA112S ()
    {
        return playerData.A112S;
    }

    public static int GetA113J ()
    {
        return playerData.A113J;
    }

    public static int GetA113S ()
    {
        return playerData.A113S;
    }

    public static int GetA114J ()
    {
        return playerData.A114J;
    }

    public static int GetA114S ()
    {
        return playerData.A114S;
    }

    public static int GetA12J ()
    {
        return playerData.A12J;
    }

    public static int GetA12S ()
    {
        return playerData.A12S;
    }

    public static int GetA13J ()
    {
        return playerData.A13J;
    }

    public static int GetA13S ()
    {
        return playerData.A13S;
    }

    public static int GetA14J ()
    {
        return playerData.A14J;
    }

    public static int GetA14S ()
    {
        return playerData.A14S;
    }

    public static int GetA15J ()
    {
        return playerData.A15J;
    }

    public static int GetA15S ()
    {
        return playerData.A15S;
    }

    public static int GetA1502J ()
    {
        return playerData.A1502J;
    }

    public static int GetA1502S ()
    {
        return playerData.A1502S;
    }

    public static int GetA161J ()
    {
        return playerData.A161J;
    }

    public static int GetA161S ()
    {
        return playerData.A161S;
    }

    public static int GetA162J ()
    {
        return playerData.A162J;
    }

    public static int GetA162S ()
    {
        return playerData.A162S;
    }

    public static int GetA163J ()
    {
        return playerData.A163J;
    }

    public static int GetA163S ()
    {
        return playerData.A163S;
    }

    public static int GetA17J ()
    {
        return playerData.A17J;
    }

    public static int GetA17S ()
    {
        return playerData.A17S;
    }

    public static int GetA18J ()
    {
        return playerData.A18J;
    }

    public static int GetA18S ()
    {
        return playerData.A18S;
    }

    public static int GetA19J ()
    {
        return playerData.A19J;
    }

    public static int GetA19S ()
    {
        return playerData.A19S;
    }

    public static int GetA110J ()
    {
        return playerData.A110J;
    }

    public static int GetA110S ()
    {
        return playerData.A110S;
    }

    public static int GetA1111J()
    {
        return playerData.A1111J;
    }

    public static int GetA1111S ()
    {
        return playerData.A1111S;
    }

    public static int GetA1112J()
    {
        return playerData.A1112J;
    }

    public static int GetA1112S ()
    {
        return playerData.A1112S;
    }

    public static int GetA1113J()
    {
        return playerData.A1113J;
    }

    public static int GetA1113S ()
    {
        return playerData.A1113S;
    }

    public static int GetAdoceJ()
    {
        return playerData.A1doceJ;
    }

    public static int GetA1doceS()
    {
        return playerData.A1doceS;
    }

    public static int GetA1xceJ()
    {
        return playerData.A1xceJ;
    }

    public static int GetA1xceS()
    {
        return playerData.A1xceS;
    }

    public static int GetA1catorceJ()
    {
        return playerData.A1catorceJ;
    }

    public static int GetA1catorceS()
    {
        return playerData.A1catorceS;
    }

    public static int GetA1151J()
    {
        return playerData.A1151J;
    }

    public static int GetA1151S()
    {
        return playerData.A1151S;
    }

    public static int GetA1152J()
    {
        return playerData.A1152J;
    }

    public static int GetA1152S()
    {
        return playerData.A1152S;
    }

    public static int GetA1153J()
    {
        return playerData.A1153J;
    }

    public static int GetA1153S()
    {
        return playerData.A1153S;
    }

    public static int GetA211J()
    {
        return playerData.A211J;
    }

    public static int Get211S()
    {
        return playerData.A211S;
    }

    public static int GetA212J()
    {
        return playerData.A212J;
    }

    public static int Get212S()
    {
        return playerData.A212S;
    }

    public static int GetA213J()
    {
        return playerData.A213J;
    }

    public static int Get213S()
    {
        return playerData.A213S;
    }

    public static int GetA214J()
    {
        return playerData.A214J;
    }

    public static int Get214S()
    {
        return playerData.A214S;
    }

    public static int GetA221J()
    {
        return playerData.A221J;
    }

    public static int Get221S()
    {
        return playerData.A221S;
    }

    public static int GetA222J()
    {
        return playerData.A222J;
    }

    public static int Get222S()
    {
        return playerData.A222S;
    }

    public static int GetA223J()
    {
        return playerData.A223J;
    }

    public static int Get223S()
    {
        return playerData.A223S;
    }

    public static int GetA224J()
    {
        return playerData.A224J;
    }

    public static int Get224S()
    {
        return playerData.A224S;
    }

    public static int GetA23J()
    {
        return playerData.A23J;
    }

    public static int Get23S()
    {
        return playerData.A23S;
    }

    public static int GetA241J()
    {
        return playerData.A241J;
    }

    public static int Get241S()
    {
        return playerData.A241S;
    }

    public static int GetA242J()
    {
        return playerData.A242J;
    }

    public static int Get242S()
    {
        return playerData.A242S;
    }

    public static int GetA243J()
    {
        return playerData.A243J;
    }

    public static int Get243S()
    {
        return playerData.A243S;
    }

    public static int GetA26J()
    {
        return playerData.A26J;
    }

    public static int Get26S()
    {
        return playerData.A26S;
    }

    public static int GetA27J()
    {
        return playerData.A27J;
    }

    public static int Get27S()
    {
        return playerData.A27S;
    }

    public static int GetA281J()
    {
        return playerData.A281J;
    }

    public static int Get281S()
    {
        return playerData.A281S;
    }

    public static int GetA282J()
    {
        return playerData.A282J;
    }

    public static int Get282S()
    {
        return playerData.A282S;
    }

    public static int GetA283J()
    {
        return playerData.A283J;
    }

    public static int Get283S()
    {
        return playerData.A283S;
    }

    public static int GetA33J()
    {
        return playerData.A33J;
    }

    public static int Get33S()
    {
        return playerData.A33S;
    }

    public static int GetA34J()
    {
        return playerData.A34J;
    }

    public static int Get34S()
    {
        return playerData.A34S;
    }

    public static int GetA351J()
    {
        return playerData.A351J;
    }

    public static int Get351S()
    {
        return playerData.A351S;
    }

    public static int GetA352J()
    {
        return playerData.A352J;
    }

    public static int Get352S()
    {
        return playerData.A352S;
    }

    public static int GetA353J()
    {
        return playerData.A353J;
    }

    public static int Get353S()
    {
        return playerData.A353S;
    }

    public static int GetA354J()
    {
        return playerData.A354J;
    }

    public static int Get354S()
    {
        return playerData.A354S;
    }

    public static int GetA36J()
    {
        return playerData.A36J;
    }

    public static int Get36S()
    {
        return playerData.A36S;
    }

    public static int GetA37J()
    {
        return playerData.A37J;
    }

    public static int Get37S()
    {
        return playerData.A37S;
    }

    public static int GetA381J()
    {
        return playerData.A381J;
    }

    public static int Get381S()
    {
        return playerData.A381S;
    }

    public static int GetA382J()
    {
        return playerData.A382J;
    }

    public static int Get382S()
    {
        return playerData.A382S;
    }

    public static int GetA383J()
    {
        return playerData.A383J;
    }

    public static int Get383S()
    {
        return playerData.A383S;
    }

    public static int GetA39J()
    {
        return playerData.A39J;
    }

    public static int Get39S()
    {
        return playerData.A39S;
    }

    public static int GetA310J()
    {
        return playerData.A310J;
    }

    public static int Get310S()
    {
        return playerData.A310S;
    }

    public static int GetA41J()
    {
        return playerData.A41J;
    }

    public static int Get41S()
    {
        return playerData.A41S;
    }

    public static int GetA42J()
    {
        return playerData.A42J;
    }

    public static int Get42S()
    {
        return playerData.A42S;
    }

    public static int GetA43J()
    {
        return playerData.A43J;
    }

    public static int Get43S()
    {
        return playerData.A43S;
    }

    public static int GetA44J()
    {
        return playerData.A44J;
    }

    public static int Get44S()
    {
        return playerData.A44S;
    }

    public static int GetA451J()
    {
        return playerData.A451J;
    }

    public static int Get451S()
    {
        return playerData.A451S;
    }

    public static int GetA452J()
    {
        return playerData.A452J;
    }

    public static int Get452S()
    {
        return playerData.A452S;
    }

    public static int GetA453J()
    {
        return playerData.A453J;
    }

    public static int Get453S()
    {
        return playerData.A453S;
    }

    public static int GetA46J()
    {
        return playerData.A46J;
    }

    public static int Get46S()
    {
        return playerData.A46S;
    }

    public static int GetA471J()
    {
        return playerData.A471J;
    }

    public static int Get471S()
    {
        return playerData.A471S;
    }

    public static int GetA472J()
    {
        return playerData.A472J;
    }

    public static int Get472S()
    {
        return playerData.A472S;
    }

    public static int GetA473J()
    {
        return playerData.A473J;
    }

    public static int Get473S()
    {
        return playerData.A473S;
    }

    public static int GetA481J()
    {
        return playerData.A481J;
    }

    public static int Get481S()
    {
        return playerData.A481S;
    }

    public static int GetA482J()
    {
        return playerData.A482J;
    }

    public static int Get482S()
    {
        return playerData.A482S;
    }

    public static int GetA483J()
    {
        return playerData.A483J;
    }

    public static int Get483S()
    {
        return playerData.A483S;
    }

    public static int GetA491J()
    {
        return playerData.A491J;
    }

    public static int Get491S()
    {
        return playerData.A491S;
    }

    public static int GetA492J()
    {
        return playerData.A492J;
    }

    public static int Get492S()
    {
        return playerData.A492S;
    }

    public static int GetA493J()
    {
        return playerData.A493J;
    }

    public static int Get493S()
    {
        return playerData.A493S;
    }

    public static int GetA410J()
    {
        return playerData.A410J;
    }

    public static int Get410S()
    {
        return playerData.A410S;
    }

    public static int GetA4111J()
    {
        return playerData.A4111J;
    }

    public static int Get4111S()
    {
        return playerData.A4111S;
    }

    public static int GetA4112J()
    {
        return playerData.A4112J;
    }

    public static int Get4112S()
    {
        return playerData.A4112S;
    }

    public static int GetA4113J()
    {
        return playerData.A4113J;
    }

    public static int Get4113S()
    {
        return playerData.A4113S;
    }

    public static int GetA4121J()
    {
        return playerData.A4121J;
    }

    public static int Get4121S()
    {
        return playerData.A4121S;
    }

    public static int GetA4122J()
    {
        return playerData.A4122J;
    }

    public static int Get4122S()
    {
        return playerData.A4122S;
    }

    public static int GetA4123J()
    {
        return playerData.A4123J;
    }

    public static int Get4123S()
    {
        return playerData.A4123S;
    }

    public static int GetA511J()
    {
        return playerData.A511J;
    }

    public static int Get511S()
    {
        return playerData.A511S;
    }

    public static int GetA512J()
    {
        return playerData.A512J;
    }

    public static int Get512S()
    {
        return playerData.A512S;
    }

    public static int GetA513J()
    {
        return playerData.A513J;
    }

    public static int Get513S()
    {
        return playerData.A513S;
    }

    public static int GetA514J()
    {
        return playerData.A514J;
    }

    public static int Get514S()
    {
        return playerData.A514S;
    }

    public static int GetA515J()
    {
        return playerData.A515J;
    }

    public static int Get515S()
    {
        return playerData.A515S;
    }

    public static int GetA516J()
    {
        return playerData.A516J;
    }

    public static int Get516S()
    {
        return playerData.A516S;
    }

    public static int GetA52J()
    {
        return playerData.A52J;
    }

    public static int Get52S()
    {
        return playerData.A52S;
    }

    public static int GetA531J()
    {
        return playerData.A531J;
    }

    public static int Get531S()
    {
        return playerData.A531S;
    }

    public static int GetA532J()
    {
        return playerData.A532J;
    }

    public static int Get532S()
    {
        return playerData.A532S;
    }

    public static int GetA533J()
    {
        return playerData.A533J;
    }

    public static int Get533S()
    {
        return playerData.A533S;
    }

    public static int GetA541J()
    {
        return playerData.A541J;
    }

    public static int Get541S()
    {
        return playerData.A541S;
    }

    public static int GetA542J()
    {
        return playerData.A542J;
    }

    public static int Get542S()
    {
        return playerData.A542S;
    }

    public static int GetA543J()
    {
        return playerData.A543J;
    }

    public static int Get543S()
    {
        return playerData.A543S;
    }

    public static int GetA551J()
    {
        return playerData.A551J;
    }

    public static int Get551S()
    {
        return playerData.A551S;
    }

    public static int GetA552J()
    {
        return playerData.A552J;
    }

    public static int Get552S()
    {
        return playerData.A552S;
    }

    public static int GetA553J()
    {
        return playerData.A553J;
    }

    public static int Get553S()
    {
        return playerData.A553S;
    }

    public static int GetA554J()
    {
        return playerData.A554J;
    }

    public static int Get554S()
    {
        return playerData.A554S;
    }

    public static int GetA56J()
    {
        return playerData.A56J;
    }

    public static int Get56S()
    {
        return playerData.A56S;
    }

    public static int GetA57J()
    {
        return playerData.A57J;
    }

    public static int Get57S()
    {
        return playerData.A57S;
    }

    public static int GetA581J()
    {
        return playerData.A581J;
    }

    public static int Get581S()
    {
        return playerData.A581S;
    }

    public static int GetA582J()
    {
        return playerData.A582J;
    }

    public static int Get582S()
    {
        return playerData.A582S;
    }

    public static int GetA583J()
    {
        return playerData.A583J;
    }

    public static int Get583S()
    {
        return playerData.A583S;
    }

    public static int GetA584J()
    {
        return playerData.A584J;
    }

    public static int Get584S()
    {
        return playerData.A584S;
    }

    public static int GetA59J()
    {
        return playerData.A59J;
    }

    public static int Get59S()
    {
        return playerData.A59S;
    }

    public static int GetA5101J()
    {
        return playerData.A5101J;
    }

    public static int Get5101S()
    {
        return playerData.A5101S;
    }

    public static int GetA5102J()
    {
        return playerData.A5102J;
    }

    public static int Get5102S()
    {
        return playerData.A5102S;
    }

    public static int GetA5103J()
    {
        return playerData.A5103J;
    }

    public static int Get5103S()
    {
        return playerData.A5103S;
    }

    public static int GetA5111J()
    {
        return playerData.A5111J;
    }

    public static int Get5111S()
    {
        return playerData.A5111S;
    }

    public static int GetA5112J()
    {
        return playerData.A5112J;
    }

    public static int Get5112S()
    {
        return playerData.A5112S;
    }

    public static int GetA5113J()
    {
        return playerData.A5113J;
    }

    public static int Get5113S()
    {
        return playerData.A5113S;
    }

    public static int GetA5121J()
    {
        return playerData.A5121J;
    }

    public static int Get5121S()
    {
        return playerData.A5121S;
    }

    public static int GetA5122J()
    {
        return playerData.A5122J;
    }

    public static int Get5122S()
    {
        return playerData.A5122S;
    }

    public static int GetA5123J()
    {
        return playerData.A5123J;
    }

    public static int Get5123S()
    {
        return playerData.A5123S;
    }

    public static int GetA5124J()
    {
        return playerData.A5124J;
    }

    public static int Get5124S()
    {
        return playerData.A5124S;
    }

    public static int GetA611J()
    {
        return playerData.A611J;
    }

    public static int Get611S()
    {
        return playerData.A611S;
    }

    public static int GetA612J()
    {
        return playerData.A612J;
    }

    public static int Get612S()
    {
        return playerData.A612S;
    }

    public static int GetA62J()
    {
        return playerData.A62J;
    }

    public static int Get62S()
    {
        return playerData.A62S;
    }

    public static int GetA631J()
    {
        return playerData.A631J;
    }

    public static int Get631S()
    {
        return playerData.A631S;
    }

    public static int GetA632J()
    {
        return playerData.A632J;
    }

    public static int Get632S()
    {
        return playerData.A632S;
    }

    public static int GetA633J()
    {
        return playerData.A633J;
    }

    public static int Get633S()
    {
        return playerData.A633S;
    }

    public static int GetA634J()
    {
        return playerData.A634J;
    }

    public static int Get634S()
    {
        return playerData.A634S;
    }

    public static int GetA635J()
    {
        return playerData.A635J;
    }

    public static int Get635S()
    {
        return playerData.A635S;
    }

    public static int GetA64J()
    {
        return playerData.A64J;
    }

    public static int Get64S()
    {
        return playerData.A64S;
    }

    public static int GetA642J()
    {
        return playerData.A642J;
    }

    public static int Get642S()
    {
        return playerData.A642S;
    }

    public static int GetA643J()
    {
        return playerData.A642J;
    }

    public static int Get643S()
    {
        return playerData.A642S;
    }

    public static int GetA644J()
    {
        return playerData.A642J;
    }

    public static int Get644S()
    {
        return playerData.A642S;
    }

    public static int GetA645J()
    {
        return playerData.A642J;
    }

    public static int Get645S()
    {
        return playerData.A642S;
    }

    public static int GetA65J()
    {
        return playerData.A65J;
    }

    public static int Get65S()
    {
        return playerData.A65S;
    }

    public static int GetA66J()
    {
        return playerData.A66J;
    }

    public static int Get66S()
    {
        return playerData.A66S;
    }

    public static int GetA671J()
    {
        return playerData.A671J;
    }

    public static int Get671S()
    {
        return playerData.A671S;
    }

    public static int GetA672J()
    {
        return playerData.A672J;
    }

    public static int Get672S()
    {
        return playerData.A672S;
    }

    public static int GetA673J()
    {
        return playerData.A673J;
    }

    public static int Get673S()
    {
        return playerData.A673S;
    }

    public static int GetA674J()
    {
        return playerData.A674J;
    }

    public static int Get674S()
    {
        return playerData.A674S;
    }

    public static int GetA681J()
    {
        return playerData.A681J;
    }

    public static int Get681S()
    {
        return playerData.A681S;
    }

    public static int GetA682J()
    {
        return playerData.A682J;
    }

    public static int Get682S()
    {
        return playerData.A682S;
    }

    public static int GetA683J()
    {
        return playerData.A683J;
    }

    public static int Get683S()
    {
        return playerData.A683S;
    }

    public static int GetA691J()
    {
        return playerData.A691J;
    }

    public static int Get691S()
    {
        return playerData.A691S;
    }

    public static int GetA692J()
    {
        return playerData.A692J;
    }

    public static int Get692S()
    {
        return playerData.A692S;
    }

    public static int GetA693J()
    {
        return playerData.A693J;
    }

    public static int Get693S()
    {
        return playerData.A693S;
    }

    public static int GetA610J()
    {
        return playerData.A610J;
    }

    public static int Get610S()
    {
        return playerData.A610S;
    }

    public static int GetA6102J()
    {
        return playerData.A6102J;
    }

    public static int Get6102S()
    {
        return playerData.A6102S;
    }

    public static int GetA6103J()
    {
        return playerData.A6103J;
    }

    public static int Get6103S()
    {
        return playerData.A6103S;
    }

    public static int GetA6111J()
    {
        return playerData.A6111J;
    }

    public static int Get6111S()
    {
        return playerData.A6111S;
    }

    public static int GetA6112J()
    {
        return playerData.A6112J;
    }

    public static int Get6112S()
    {
        return playerData.A6112S;
    }

    public static int GetA6113J()
    {
        return playerData.A6113J;
    }

    public static int Get6113S()
    {
        return playerData.A6113S;
    }

    public static int GetA6114J()
    {
        return playerData.A6114J;
    }

    public static int Get6114S()
    {
        return playerData.A6114S;
    }

    public static int GetA6121J()
    {
        return playerData.A6121J;
    }

    public static int Get6121S()
    {
        return playerData.A6121S;
    }

    public static int GetA6122J()
    {
        return playerData.A6122J;
    }

    public static int Get6122S()
    {
        return playerData.A6122S;
    }

    public static int GetA6123J()
    {
        return playerData.A6123J;
    }

    public static int Get6123S()
    {
        return playerData.A6123S;
    }

    public static int GetA6124J()
    {
        return playerData.A6124J;
    }

    public static int Get6124S()
    {
        return playerData.A6124S;
    }

    public static int GetA6131J()
    {
        return playerData.A6131J;
    }

    public static int Get6131S()
    {
        return playerData.A6131S;
    }

    public static int GetA6132J()
    {
        return playerData.A6132J;
    }

    public static int Get6132S()
    {
        return playerData.A6132S;
    }

    public static int GetA6133J()
    {
        return playerData.A6133J;
    }

    public static int Get6133S()
    {
        return playerData.A6133S;
    }

    public static int GetA6134J()
    {
        return playerData.A6134J;
    }

    public static int Get6134S()
    {
        return playerData.A6134S;
    }

    public static int GetA6141J()
    {
        return playerData.A6141J;
    }

    public static int Get6141S()
    {
        return playerData.A6141S;
    }

    public static int GetA6142J()
    {
        return playerData.A6142J;
    }

    public static int Get6142S()
    {
        return playerData.A6142S;
    }

    public static int GetA6143J()
    {
        return playerData.A6143J;
    }

    public static int Get6143S()
    {
        return playerData.A6143S;
    }

    public static int GetA6151J()
    {
        return playerData.A6151J;
    }

    public static int Get6151S()
    {
        return playerData.A6151S;
    }

    public static int GetA6152J()
    {
        return playerData.A6152J;
    }

    public static int Get6152S()
    {
        return playerData.A6152S;
    }

    public static int GetA6153J()
    {
        return playerData.A6153J;
    }

    public static int Get6153S()
    {
        return playerData.A6153S;
    }

    public static int GetA6161J()
    {
        return playerData.A6161J;
    }

    public static int Get6161S()
    {
        return playerData.A6161S;
    }

    public static int GetA6162J()
    {
        return playerData.A6162J;
    }

    public static int Get6162S()
    {
        return playerData.A6162S;
    }

    public static int GetA6163J()
    {
        return playerData.A6163J;
    }

    public static int GetA6163S()
    {
        return playerData.A6163S;
    }

    public static int GetA711J()
    {
        return playerData.A711J;
    }

    public static int GetA711S()
    {
        return playerData.A711S;
    }

    public static int GetA712J()
    {
        return playerData.A712J;
    }

    public static int GetA712S()
    {
        return playerData.A712S;
    }

    public static int GetA713J()
    {
        return playerData.A713J;
    }

    public static int GetA713S()
    {
        return playerData.A713S;
    }

    public static int GetA714J()
    {
        return playerData.A714J;
    }

    public static int GetA714S()
    {
        return playerData.A714S;
    }

    public static int GetA715J()
    {
        return playerData.A715J;
    }

    public static int GetA715S()
    {
        return playerData.A715S;
    }

    public static int GetA721J()
    {
        return playerData.A721J;
    }

    public static int GetA721S()
    {
        return playerData.A721S;
    }

    public static int GetA722J()
    {
        return playerData.A722J;
    }

    public static int GetA722S()
    {
        return playerData.A722S;
    }

    public static int GetA723J()
    {
        return playerData.A723J;
    }

    public static int GetA723S()
    {
        return playerData.A723S;
    }

    public static int GetA731J()
    {
        return playerData.A731J;
    }

    public static int GetA731S()
    {
        return playerData.A731S;
    }

    public static int GetA732J()
    {
        return playerData.A732J;
    }

    public static int GetA732S()
    {
        return playerData.A732S;
    }

    public static int GetA733J()
    {
        return playerData.A733J;
    }

    public static int GetA733S()
    {
        return playerData.A733S;
    }

    public static int GetA74J()
    {
        return playerData.A74J;
    }

    public static int GetA74S()
    {
        return playerData.A74S;
    }

    public static int GetA751J()
    {
        return playerData.A751J;
    }

    public static int GetA751S()
    {
        return playerData.A751S;
    }

    public static int GetA752J()
    {
        return playerData.A752J;
    }

    public static int GetA752S()
    {
        return playerData.A752S;
    }

    public static int GetA753J()
    {
        return playerData.A753J;
    }

    public static int GetA753S()
    {
        return playerData.A753S;
    }

    public static int GetA76J()
    {
        return playerData.A76J;
    }

    public static int GetA76S()
    {
        return playerData.A76S;
    }

    public static int GetA771J()
    {
        return playerData.A771J;
    }

    public static int GetA771S()
    {
        return playerData.A771S;
    }

    public static int GetA772J()
    {
        return playerData.A772J;
    }

    public static int GetA772S()
    {
        return playerData.A772S;
    }

    public static int GetA773J()
    {
        return playerData.A773J;
    }

    public static int GetA773S()
    {
        return playerData.A773S;
    }

    public static int GetA79J()
    {
        return playerData.A79J;
    }

    public static int GetA79S()
    {
        return playerData.A79S;
    }

    public static int GetA792J()
    {
        return playerData.A792J;
    }

    public static int GetA792S()
    {
        return playerData.A792S;
    }

    public static int GetA793J()
    {
        return playerData.A793J;
    }

    public static int GetA793S()
    {
        return playerData.A793S;
    }

    public static int GetA7101J()
    {
        return playerData.A7101J;
    }

    public static int GetA7101S()
    {
        return playerData.A7101S;
    }

    public static int GetA7102J()
    {
        return playerData.A7102J;
    }

    public static int GetA7102S()
    {
        return playerData.A7102S;
    }

    public static int GetA7103J()
    {
        return playerData.A7103J;
    }

    public static int GetA7103S()
    {
        return playerData.A7103S;
    }

    public static int GetA25DA()
    {
        return playerData.A25DA;
    }

    public static int GetA25DE()
    {
        return playerData.A25DE;
    }

    public static int GetA25DI()
    {
        return playerData.A25DI;
    }

    public static int GetA25DO()
    {
        return playerData.A25DO;
    }

    public static int GetA25DU()
    {
        return playerData.A25DU;
    }

    public static int GetA25LA()
    {
        return playerData.A25LA;
    }

    public static int GetA25LE()
    {
        return playerData.A25LE;
    }

    public static int GetA25LI()
    {
        return playerData.A25LI;
    }

    public static int GetA25LO()
    {
        return playerData.A25LO;
    }

    public static int GetA25LU()
    {
        return playerData.A25LU;
    }

    public static int GetA25MA()
    {
        return playerData.A25MA;
    }

    public static int GetA25ME()
    {
        return playerData.A25ME;
    }

    public static int GetA25MI()
    {
        return playerData.A25MI;
    }

    public static int GetA25MO()
    {
        return playerData.A25MO;
    }

    public static int GetA25MU()
    {
        return playerData.A25MU;
    }

    public static int GetA25NA()
    {
        return playerData.A25NA;
    }

    public static int GetA25NE()
    {
        return playerData.A25NE;
    }

    public static int GetA25NI()
    {
        return playerData.A25NI;
    }

    public static int GetA25NO()
    {
        return playerData.A25NO;
    }

    public static int GetA25NU()
    {
        return playerData.A25NU;
    }

    public static int GetA25PA()
    {
        return playerData.A25PA;
    }

    public static int GetA25PE()
    {
        return playerData.A25PE;
    }

    public static int GetA25PI()
    {
        return playerData.A25PI;
    }

    public static int GetA25PO()
    {
        return playerData.A25PO;
    }

    public static int GetA25PU()
    {
        return playerData.A25PU;
    }

    public static int GetA25SA()
    {
        return playerData.A25SA;
    }

    public static int GetA25SE()
    {
        return playerData.A25SE;
    }

    public static int GetA25SI()
    {
        return playerData.A25SI;
    }

    public static int GetA25SO()
    {
        return playerData.A25SO;
    }

    public static int GetA25SU()
    {
        return playerData.A25SU;
    }

    public static int GetA31A()
    {
        return playerData.A31A;
    }

    public static int GetA31D()
    {
        return playerData.A31D;
    }

    public static int GetA31E()
    {
        return playerData.A31E;
    }

    public static int GetA31F()
    {
        return playerData.A31F;
    }

    public static int GetA31I()
    {
        return playerData.A31I;
    }

    public static int GetA31L()
    {
        return playerData.A31L;
    }

    public static int GetA31M()
    {
        return playerData.A31M;
    }

    public static int GetA31N()
    {
        return playerData.A31N;
    }

    public static int GetA31O()
    {
        return playerData.A31O;
    }

    public static int GetA31P()
    {
        return playerData.A31P;
    }

    public static int GetA31R()
    {
        return playerData.A31R;
    }

    public static int GetA31S()
    {
        return playerData.A31S;
    }

    public static int GetA31T()
    {
        return playerData.A31T;
    }
    
    public static int GetA31U()
    {
        return playerData.A31U;
    }

    

    public static int GetA321()
    {
        return playerData.A321;
    }

    public static int GetA322()
    {
        return playerData.A322;
    }

    public static int GetA323()
    {
        return playerData.A323;
    }

    public static int GetA324()
    {
        return playerData.A324;
    }

    public static int GetA325()
    {
        return playerData.A325;
    }

    public static int GetA326()
    {
        return playerData.A326;
    }

    public static int GetA327()
    {
        return playerData.A327;
    }

    public static int GetA328()
    {
        return playerData.A328;
    }

    public static int GetA329()
    {
        return playerData.A329;
    }

    public static int GetA3210()
    {
        return playerData.A3210;
    }

    public static int GetA3211()
    {
        return playerData.A3211;
    }

    public static int GetA3212()
    {
        return playerData.A3212;
    }

    public static int GetA3213()
    {
        return playerData.A3213;
    }

    public static int GetA3214()
    {
        return playerData.A3214;
    }

    public static int GetA3215()
    {
        return playerData.A3215;
    }

    public static int GetA781()
    {
        return playerData.A781;
    }

    public static int GetA782()
    {
        return playerData.A782;
    }

    public static int GetA783()
    {
        return playerData.A783;
    }

    public static int GetA784()
    {
        return playerData.A784;
    }

    public static int GetA785()
    {
        return playerData.A785;
    }

    public static int GetA25DAS()
    {
        return playerData.A25DAS;
    }

    public static int GetA25DES()
    {
        return playerData.A25DES;
    }

    public static int GetA25DIS()
    {
        return playerData.A25DIS;
    }

    public static int GetA25DOS()
    {
        return playerData.A25DOS;
    }

    public static int GetA25DUS()
    {
        return playerData.A25DUS;
    }

    public static int GetA25LAS()
    {
        return playerData.A25LAS;
    }

    public static int GetA25LES()
    {
        return playerData.A25LES;
    }

    public static int GetA25LIS()
    {
        return playerData.A25LIS;
    }

    public static int GetA25LOS()
    {
        return playerData.A25LOS;
    }

    public static int GetA25LUS()
    {
        return playerData.A25LUS;
    }

    public static int GetA25MAS()
    {
        return playerData.A25MAS;
    }

    public static int GetA25MES()
    {
        return playerData.A25MES;
    }

    public static int GetA25MIS()
    {
        return playerData.A25MIS;
    }

    public static int GetA25MOS()
    {
        return playerData.A25MOS;
    }

    public static int GetA25MUS()
    {
        return playerData.A25MUS;
    }

    public static int GetA25NAS()
    {
        return playerData.A25NAS;
    }

    public static int GetA25NES()
    {
        return playerData.A25NES;
    }

    public static int GetA25NIS()
    {
        return playerData.A25NIS;
    }

    public static int GetA25NOS()
    {
        return playerData.A25NOS;
    }

    public static int GetA25NUS()
    {
        return playerData.A25NUS;
    }

    public static int GetA25PAS()
    {
        return playerData.A25PAS;
    }

    public static int GetA25PES()
    {
        return playerData.A25PES;
    }

    public static int GetA25PIS()
    {
        return playerData.A25PIS;
    }

    public static int GetA25POS()
    {
        return playerData.A25POS;
    }

    public static int GetA25PUS()
    {
        return playerData.A25PUS;
    }

    public static int GetA25SAS()
    {
        return playerData.A25SAS;
    }

    public static int GetA25SES()
    {
        return playerData.A25SES;
    }

    public static int GetA25SIS()
    {
        return playerData.A25SIS;
    }

    public static int GetA25SOS()
    {
        return playerData.A25SOS;
    }

    public static int GetA25SUS()
    {
        return playerData.A25SUS;
    }

    public static int GetA31AS()
    {
        return playerData.A31AS;
    }

    public static int GetA31DS()
    {
        return playerData.A31DS;
    }

    public static int GetA31ES()
    {
        return playerData.A31ES;
    }

    public static int GetA31FS()
    {
        return playerData.A31FS;
    }

    public static int GetA31IS()
    {
        return playerData.A31IS;
    }

    public static int GetA31LS()
    {
        return playerData.A31LS;
    }

    public static int GetA31MS()
    {
        return playerData.A31MS;
    }

    public static int GetA31NS()
    {
        return playerData.A31NS;
    }

    public static int GetA31OS()
    {
        return playerData.A31OS;
    }

    public static int GetA31PS()
    {
        return playerData.A31PS;
    }

    public static int GetA31RS()
    {
        return playerData.A31RS;
    }

    public static int GetA31SS()
    {
        return playerData.A31SS;
    }

    public static int GetA31TS()
    {
        return playerData.A31TS;
    }
    
    public static int GetA31US()
    {
        return playerData.A31US;
    }

    public static int GetA321S()
    {
        return playerData.A321S;
    }

    public static int GetA322S()
    {
        return playerData.A322S;
    }

    public static int GetA323S()
    {
        return playerData.A323S;
    }

    public static int GetA324S()
    {
        return playerData.A324S;
    }

    public static int GetA325S()
    {
        return playerData.A325S;
    }

    public static int GetA326S()
    {
        return playerData.A326S;
    }

    public static int GetA327S()
    {
        return playerData.A327S;
    }

    public static int GetA328S()
    {
        return playerData.A328S;
    }

    public static int GetA329S()
    {
        return playerData.A329S;
    }

    public static int GetA3210S()
    {
        return playerData.A3210S;
    }

    public static int GetA3211S()
    {
        return playerData.A3211S;
    }

    public static int GetA3212S()
    {
        return playerData.A3212S;
    }

    public static int GetA3213S()
    {
        return playerData.A3213S;
    }

    public static int GetA3214S()
    {
        return playerData.A3214S;
    }

    public static int GetA3215S()
    {
        return playerData.A3215S;
    }

    public static int GetA781S()
    {
        return playerData.A781S;
    }

    public static int GetA782S()
    {
        return playerData.A782S;
    }

    public static int GetA783S()
    {
        return playerData.A783S;
    }

    public static int GetA784S()
    {
        return playerData.A784S;
    }

    public static int GetA785S()
    {
        return playerData.A785S;
    }

    public static int GetA81()
    {
        return playerData.A81;
    }

    public static int GetA82()
    {
        return playerData.A82;
    }

    public static int GetA83()
    {
        return playerData.A83;
    }

    public static int GetA84()
    {
        return playerData.A84;
    }

    public static int GetA85()
    {
        return playerData.A85;
    }

    public static int GetA86()
    {
        return playerData.A86;
    }

    public static int GetA87()
    {
        return playerData.A87;
    }

    public static int GetA88()
    {
        return playerData.A88;
    }

    public static int GetA891()
    {
        return playerData.A891;
    }

    public static int GetA892()
    {
        return playerData.A892;
    }

    public static int GetA893()
    {
        return playerData.A893;
    }

    public static int GetA810()
    {
        return playerData.A810;
    }



    public static void AddCoins(int amount)
    {
        playerData.coins += amount;
        SavePlayerData();
    }

    public static void AddExp(int eamount)
    {
        playerData.exp += eamount;
        playerData.expTotal += eamount;

        if(playerData.etapa <= playerData.etapaMaxima - 1)
        {
            if(playerData.exp >= playerData.requisito)
            {
            playerData.exp -= playerData.requisito;
            playerData.etapa++;
            playerData.requisito = playerData.requisito * 2;
            }
        }
        SavePlayerData();
    }

    public static void A111Jugado(int amount111J)
    {
        playerData.A111J += amount111J;
        SavePlayerData();
    }

    public static void A111Superado(int amount111S)
    {
        playerData.A111S += amount111S;
        SavePlayerData();
    }

    public static void A112Jugado(int amount112J)
    {
        playerData.A112J += amount112J;
        SavePlayerData();
    }

    public static void A112Superado(int amount112S)
    {
        playerData.A112S += amount112S;
        SavePlayerData();
    }

    public static void A113Jugado(int amount113J)
    {
        playerData.A113J += amount113J;
        SavePlayerData();
    }

    public static void A113Superado(int amount113S)
    {
        playerData.A113S += amount113S;
        SavePlayerData();
    }

    public static void A114Jugado(int amount114J)
    {
        playerData.A114J += amount114J;
        SavePlayerData();
    }

    public static void A114Superado(int amount114S)
    {
        playerData.A114S += amount114S;
        SavePlayerData();
    }

    public static void A12Jugado(int amount12J)
    {
        playerData.A12J += amount12J;
        SavePlayerData();
    }

    public static void A12Superado(int amount12S)
    {
        playerData.A12S += amount12S;
        SavePlayerData();
    }

    public static void A13Jugado(int amount13J)
    {
        playerData.A13J += amount13J;
        SavePlayerData();
    }

    public static void A13Superado(int amount13S)
    {
        playerData.A13S += amount13S;
        SavePlayerData();
    }

    public static void A14Jugado(int amount14J)
    {
        playerData.A14J += amount14J;
        SavePlayerData();
    }

    public static void A14Superado(int amount14S)
    {
        playerData.A14S += amount14S;
        SavePlayerData();
    }

    public static void A15Jugado(int amount15J)
    {
        playerData.A15J += amount15J;
        SavePlayerData();
    }

    public static void A15Superado(int amount15S)
    {
        playerData.A15S += amount15S;
        SavePlayerData();
    }

    public static void A1502Jugado(int amount1502J)
    {
        playerData.A1502J += amount1502J;
        SavePlayerData();
    }

    public static void A1502Superado(int amount1502S)
    {
        playerData.A1502S += amount1502S;
        SavePlayerData();
    }

    public static void A161Jugado(int amount161J)
    {
        playerData.A161J += amount161J;
        SavePlayerData();
    }

    public static void A161Superado(int amount161S)
    {
        playerData.A161S += amount161S;
        SavePlayerData();
    }

    public static void A162Jugado(int amount162J)
    {
        playerData.A162J += amount162J;
        SavePlayerData();
    }

    public static void A162Superado(int amount162S)
    {
        playerData.A162S += amount162S;
        SavePlayerData();
    }

    public static void A163Jugado(int amount163J)
    {
        playerData.A163J += amount163J;
        SavePlayerData();
    }

    public static void A163Superado(int amount163S)
    {
        playerData.A163S += amount163S;
        SavePlayerData();
    }

    public static void A17Jugado(int amount17J)
    {
        playerData.A17J += amount17J;
        SavePlayerData();
    }

    public static void A17Superado(int amount17S)
    {
        playerData.A17S += amount17S;
        SavePlayerData();
    }

    public static void A18Jugado(int amount18J)
    {
        playerData.A18J += amount18J;
        SavePlayerData();
    }

    public static void A18Superado(int amount18S)
    {
        playerData.A18S += amount18S;
        SavePlayerData();
    }

    public static void A19Jugado(int amount19J)
    {
        playerData.A19J += amount19J;
        SavePlayerData();
    }

    public static void A19Superado(int amount19S)
    {
        playerData.A19S += amount19S;
        SavePlayerData();
    }

    public static void A110Jugado(int amount110J)
    {
        playerData.A110J += amount110J;
        SavePlayerData();
    }

    public static void A110Superado(int amount110S)
    {
        playerData.A110S += amount110S;
        SavePlayerData();
    }

    public static void A1111Jugado(int amount1111J)
    {
        playerData.A1111J += amount1111J;
        SavePlayerData();
    }

    public static void A1111Superado(int amount1111S)
    {
        playerData.A1111S += amount1111S;
        SavePlayerData();
    }

    public static void A1112Jugado(int amount1112J)
    {
        playerData.A1112J += amount1112J;
        SavePlayerData();
    }

    public static void A1112Superado(int amount1112S)
    {
        playerData.A1112S += amount1112S;
        SavePlayerData();
    }

    public static void A1113Jugado(int amount1113J)
    {
        playerData.A1113J += amount1113J;
        SavePlayerData();
    }

    public static void A1113Superado(int amount1113S)
    {
        playerData.A1113S += amount1113S;
        SavePlayerData();
    }

    public static void A1doceJugado(int amount1doceJ)
    {
        playerData.A1doceJ += amount1doceJ;
        SavePlayerData();
    }

    public static void A1doceSuperado(int amount1doceS)
    {
        playerData.A1doceS += amount1doceS;
        SavePlayerData();
    }

    public static void A1xceJugado(int amount1xceJ)
    {
        playerData.A1xceJ += amount1xceJ;
        SavePlayerData();
    }

    public static void A1xceSuperado(int amount1xceS)
    {
        playerData.A1xceS += amount1xceS;
        SavePlayerData();
    }

    public static void A1catorceJugado(int amount1catorceJ)
    {
        playerData.A1catorceJ += amount1catorceJ;
        SavePlayerData();
    }

    public static void A1catorceSuperado(int amount1catorceS)
    {
        playerData.A1catorceS += amount1catorceS;
        SavePlayerData();
    }

    public static void A1151Jugado(int amount1151J)
    {
        playerData.A1151J += amount1151J;
        SavePlayerData();
    }

    public static void A1151Superado(int amount1151S)
    {
        playerData.A1151S += amount1151S;
        SavePlayerData();
    }

    public static void A1152Jugado(int amount1152J)
    {
        playerData.A1152J += amount1152J;
        SavePlayerData();
    }

    public static void A1152Superado(int amount1152S)
    {
        playerData.A1152S += amount1152S;
        SavePlayerData();
    }

    public static void A1153Jugado(int amount1153J)
    {
        playerData.A1153J += amount1153J;
        SavePlayerData();
    }

    public static void A1153Superado(int amount1153S)
    {
        playerData.A1153S += amount1153S;
        SavePlayerData();
    }

    public static void A211Jugado(int amount211J)
    {
        playerData.A211J += amount211J;
        SavePlayerData();
    }

    public static void A211Superado(int amount211S)
    {
        playerData.A211S += amount211S;
        SavePlayerData();
    }

    public static void A212Jugado(int amount212J)
    {
        playerData.A212J += amount212J;
        SavePlayerData();
    }

    public static void A212Superado(int amount212S)
    {
        playerData.A212S += amount212S;
        SavePlayerData();
    }

    public static void A213Jugado(int amount213J)
    {
        playerData.A213J += amount213J;
        SavePlayerData();
    }

    public static void A213Superado(int amount213S)
    {
        playerData.A213S += amount213S;
        SavePlayerData();
    }

    public static void A214Jugado(int amount214J)
    {
        playerData.A214J += amount214J;
        SavePlayerData();
    }

    public static void A214Superado(int amount214S)
    {
        playerData.A214S += amount214S;
        SavePlayerData();
    }

    public static void A221Jugado(int amount221J)
    {
        playerData.A221J += amount221J;
        SavePlayerData();
    }

    public static void A221Superado(int amount221S)
    {
        playerData.A221S += amount221S;
        SavePlayerData();
    }

    public static void A222Jugado(int amount222J)
    {
        playerData.A222J += amount222J;
        SavePlayerData();
    }

    public static void A222Superado(int amount222S)
    {
        playerData.A222S += amount222S;
        SavePlayerData();
    }

    public static void A223Jugado(int amount223J)
    {
        playerData.A223J += amount223J;
        SavePlayerData();
    }

    public static void A223Superado(int amount223S)
    {
        playerData.A223S += amount223S;
        SavePlayerData();
    }

    public static void A224Jugado(int amount224J)
    {
        playerData.A224J += amount224J;
        SavePlayerData();
    }

    public static void A224Superado(int amount224S)
    {
        playerData.A224S += amount224S;
        SavePlayerData();
    }

    public static void A23Jugado(int amount23J)
    {
        playerData.A23J += amount23J;
        SavePlayerData();
    }

    public static void A23Superado(int amount23S)
    {
        playerData.A23S += amount23S;
        SavePlayerData();
    }

    public static void A241Jugado(int amount241J)
    {
        playerData.A241J += amount241J;
        SavePlayerData();
    }

    public static void A241Superado(int amount241S)
    {
        playerData.A241S += amount241S;
        SavePlayerData();
    }

    public static void A242Jugado(int amount242J)
    {
        playerData.A242J += amount242J;
        SavePlayerData();
    }

    public static void A242Superado(int amount242S)
    {
        playerData.A242S += amount242S;
        SavePlayerData();
    }

    public static void A243Jugado(int amount243J)
    {
        playerData.A243J += amount243J;
        SavePlayerData();
    }

    public static void A243Superado(int amount243S)
    {
        playerData.A243S += amount243S;
        SavePlayerData();
    }

    public static void A26Jugado(int amount26J)
    {
        playerData.A26J += amount26J;
        SavePlayerData();
    }

    public static void A26Superado(int amount26S)
    {
        playerData.A26S += amount26S;
        SavePlayerData();
    }

    public static void A27Jugado(int amount27J)
    {
        playerData.A27J += amount27J;
        SavePlayerData();
    }

    public static void A27Superado(int amount27S)
    {
        playerData.A27S += amount27S;
        SavePlayerData();
    }

    public static void A281Jugado(int amount281J)
    {
        playerData.A281J += amount281J;
        SavePlayerData();
    }

    public static void A281Superado(int amount281S)
    {
        playerData.A281S += amount281S;
        SavePlayerData();
    }

    public static void A282Jugado(int amount282J)
    {
        playerData.A282J += amount282J;
        SavePlayerData();
    }

    public static void A282Superado(int amount282S)
    {
        playerData.A282S += amount282S;
        SavePlayerData();
    }

    public static void A283Jugado(int amount283J)
    {
        playerData.A283J += amount283J;
        SavePlayerData();
    }

    public static void A283Superado(int amount283S)
    {
        playerData.A283S += amount283S;
        SavePlayerData();
    }

    public static void A33Jugado(int amount33J)
    {
        playerData.A33J += amount33J;
        SavePlayerData();
    }

    public static void A33Superado(int amount33S)
    {
        playerData.A33S += amount33S;
        SavePlayerData();
    }

    public static void A34Jugado(int amount34J)
    {
        playerData.A34J += amount34J;
        SavePlayerData();
    }

    public static void A34Superado(int amount34S)
    {
        playerData.A34S += amount34S;
        SavePlayerData();
    }

    public static void A351Jugado(int amount351J)
    {
        playerData.A351J += amount351J;
        SavePlayerData();
    }

    public static void A351Superado(int amount351S)
    {
        playerData.A351S += amount351S;
        SavePlayerData();
    }

    public static void A352Jugado(int amount352J)
    {
        playerData.A352J += amount352J;
        SavePlayerData();
    }

    public static void A352Superado(int amount352S)
    {
        playerData.A352S += amount352S;
        SavePlayerData();
    }

    public static void A353Jugado(int amount353J)
    {
        playerData.A353J += amount353J;
        SavePlayerData();
    }

    public static void A353Superado(int amount353S)
    {
        playerData.A353S += amount353S;
        SavePlayerData();
    }

    public static void A354Jugado(int amount354J)
    {
        playerData.A354J += amount354J;
        SavePlayerData();
    }

    public static void A354Superado(int amount354S)
    {
        playerData.A354S += amount354S;
        SavePlayerData();
    }

    public static void A36Jugado(int amount36J)
    {
        playerData.A36J += amount36J;
        SavePlayerData();
    }

    public static void A36Superado(int amount36S)
    {
        playerData.A36S += amount36S;
        SavePlayerData();
    }

    public static void A37Jugado(int amount37J)
    {
        playerData.A37J += amount37J;
        SavePlayerData();
    }

    public static void A37Superado(int amount37S)
    {
        playerData.A37S += amount37S;
        SavePlayerData();
    }

    public static void A381Jugado(int amount381J)
    {
        playerData.A381J += amount381J;
        SavePlayerData();
    }

    public static void A381Superado(int amount381S)
    {
        playerData.A381S += amount381S;
        SavePlayerData();
    }

    public static void A382Jugado(int amount382J)
    {
        playerData.A382J += amount382J;
        SavePlayerData();
    }

    public static void A382Superado(int amount382S)
    {
        playerData.A382S += amount382S;
        SavePlayerData();
    }

    public static void A383Jugado(int amount383J)
    {
        playerData.A383J += amount383J;
        SavePlayerData();
    }

    public static void A383Superado(int amount383S)
    {
        playerData.A383S += amount383S;
        SavePlayerData();
    }

    public static void A39Jugado(int amount39J)
    {
        playerData.A39J += amount39J;
        SavePlayerData();
    }

    public static void A39Superado(int amount39S)
    {
        playerData.A39S += amount39S;
        SavePlayerData();
    }

    public static void A310Jugado(int amount310J)
    {
        playerData.A310J += amount310J;
        SavePlayerData();
    }

    public static void A310Superado(int amount310S)
    {
        playerData.A310S += amount310S;
        SavePlayerData();
    }

    public static void A41Jugado(int amount41J)
    {
        playerData.A41J += amount41J;
        SavePlayerData();
    }

    public static void A41Superado(int amount41S)
    {
        playerData.A41S += amount41S;
        SavePlayerData();
    }

    public static void A42Jugado(int amount42J)
    {
        playerData.A42J += amount42J;
        SavePlayerData();
    }

    public static void A42Superado(int amount42S)
    {
        playerData.A42S += amount42S;
        SavePlayerData();
    }

    public static void A43Jugado(int amount43J)
    {
        playerData.A43J += amount43J;
        SavePlayerData();
    }

    public static void A43Superado(int amount43S)
    {
        playerData.A43S += amount43S;
        SavePlayerData();
    }

    public static void A44Jugado(int amount44J)
    {
        playerData.A44J += amount44J;
        SavePlayerData();
    }

    public static void A44Superado(int amount44S)
    {
        playerData.A44S += amount44S;
        SavePlayerData();
    }

    public static void A451Jugado(int amount451J)
    {
        playerData.A451J += amount451J;
        SavePlayerData();
    }

    public static void A451Superado(int amount451S)
    {
        playerData.A451S += amount451S;
        SavePlayerData();
    }

    public static void A452Jugado(int amount452J)
    {
        playerData.A452J += amount452J;
        SavePlayerData();
    }

    public static void A452Superado(int amount452S)
    {
        playerData.A452S += amount452S;
        SavePlayerData();
    }

    public static void A453Jugado(int amount453J)
    {
        playerData.A453J += amount453J;
        SavePlayerData();
    }

    public static void A453Superado(int amount453S)
    {
        playerData.A453S += amount453S;
        SavePlayerData();
    }

    public static void A46Jugado(int amount46J)
    {
        playerData.A46J += amount46J;
        SavePlayerData();
    }

    public static void A46Superado(int amount46S)
    {
        playerData.A46S += amount46S;
        SavePlayerData();
    }

    public static void A471Jugado(int amount471J)
    {
        playerData.A471J += amount471J;
        SavePlayerData();
    }

    public static void A471Superado(int amount471S)
    {
        playerData.A471S += amount471S;
        SavePlayerData();
    }

    public static void A472Jugado(int amount472J)
    {
        playerData.A472J += amount472J;
        SavePlayerData();
    }

    public static void A472Superado(int amount472S)
    {
        playerData.A472S += amount472S;
        SavePlayerData();
    }

    public static void A473Jugado(int amount473J)
    {
        playerData.A473J += amount473J;
        SavePlayerData();
    }

    public static void A473Superado(int amount473S)
    {
        playerData.A473S += amount473S;
        SavePlayerData();
    }

    public static void A481Jugado(int amount481J)
    {
        playerData.A481J += amount481J;
        SavePlayerData();
    }

    public static void A481Superado(int amount481S)
    {
        playerData.A481S += amount481S;
        SavePlayerData();
    }

    public static void A482Jugado(int amount482J)
    {
        playerData.A482J += amount482J;
        SavePlayerData();
    }

    public static void A482Superado(int amount482S)
    {
        playerData.A482S += amount482S;
        SavePlayerData();
    }

    public static void A483Jugado(int amount483J)
    {
        playerData.A483J += amount483J;
        SavePlayerData();
    }

    public static void A483Superado(int amount483S)
    {
        playerData.A483S += amount483S;
        SavePlayerData();
    }

    public static void A491Jugado(int amount491J)
    {
        playerData.A491J += amount491J;
        SavePlayerData();
    }

    public static void A491Superado(int amount491S)
    {
        playerData.A491S += amount491S;
        SavePlayerData();
    }

    public static void A492Jugado(int amount492J)
    {
        playerData.A492J += amount492J;
        SavePlayerData();
    }

    public static void A492Superado(int amount492S)
    {
        playerData.A492S += amount492S;
        SavePlayerData();
    }

    public static void A493Jugado(int amount493J)
    {
        playerData.A493J += amount493J;
        SavePlayerData();
    }

    public static void A493Superado(int amount493S)
    {
        playerData.A493S += amount493S;
        SavePlayerData();
    }

    public static void A410Jugado(int amount410J)
    {
        playerData.A410J += amount410J;
        SavePlayerData();
    }

    public static void A410Superado(int amount410S)
    {
        playerData.A410S += amount410S;
        SavePlayerData();
    }

    public static void A4111Jugado(int amount4111J)
    {
        playerData.A4111J += amount4111J;
        SavePlayerData();
    }

    public static void A4111Superado(int amount4111S)
    {
        playerData.A4111S += amount4111S;
        SavePlayerData();
    }

    public static void A4112Jugado(int amount4112J)
    {
        playerData.A4112J += amount4112J;
        SavePlayerData();
    }

    public static void A4112Superado(int amount4112S)
    {
        playerData.A4112S += amount4112S;
        SavePlayerData();
    }

    public static void A4113Jugado(int amount4113J)
    {
        playerData.A4113J += amount4113J;
        SavePlayerData();
    }

    public static void A4113Superado(int amount4113S)
    {
        playerData.A4113S += amount4113S;
        SavePlayerData();
    }

    public static void A4121Jugado(int amount4121J)
    {
        playerData.A4121J += amount4121J;
        SavePlayerData();
    }

    public static void A4121Superado(int amount4121S)
    {
        playerData.A4121S += amount4121S;
        SavePlayerData();
    }

    public static void A4122Jugado(int amount4122J)
    {
        playerData.A4122J += amount4122J;
        SavePlayerData();
    }

    public static void A4122Superado(int amount4122S)
    {
        playerData.A4122S += amount4122S;
        SavePlayerData();
    }

    public static void A4123Jugado(int amount4123J)
    {
        playerData.A4123J += amount4123J;
        SavePlayerData();
    }

    public static void A4123Superado(int amount4123S)
    {
        playerData.A4123S += amount4123S;
        SavePlayerData();
    }

    public static void A511Jugado(int amount511J)
    {
        playerData.A511J += amount511J;
        SavePlayerData();
    }

    public static void A511Superado(int amount511S)
    {
        playerData.A511S += amount511S;
        SavePlayerData();
    }

    public static void A512Jugado(int amount512J)
    {
        playerData.A512J += amount512J;
        SavePlayerData();
    }

    public static void A512Superado(int amount512S)
    {
        playerData.A512S += amount512S;
        SavePlayerData();
    }

    public static void A513Jugado(int amount513J)
    {
        playerData.A513J += amount513J;
        SavePlayerData();
    }

    public static void A513Superado(int amount513S)
    {
        playerData.A513S += amount513S;
        SavePlayerData();
    }

    public static void A514Jugado(int amount514J)
    {
        playerData.A514J += amount514J;
        SavePlayerData();
    }

    public static void A514Superado(int amount514S)
    {
        playerData.A514S += amount514S;
        SavePlayerData();
    }

    public static void A515Jugado(int amount515J)
    {
        playerData.A515J += amount515J;
        SavePlayerData();
    }

    public static void A515Superado(int amount515S)
    {
        playerData.A515S += amount515S;
        SavePlayerData();
    }

    public static void A516Jugado(int amount516J)
    {
        playerData.A516J += amount516J;
        SavePlayerData();
    }

    public static void A516Superado(int amount516S)
    {
        playerData.A516S += amount516S;
        SavePlayerData();
    }

    public static void A52Jugado(int amount52J)
    {
        playerData.A52J += amount52J;
        SavePlayerData();
    }

    public static void A52Superado(int amount52S)
    {
        playerData.A52S += amount52S;
        SavePlayerData();
    }

    public static void A531Jugado(int amount531J)
    {
        playerData.A531J += amount531J;
        SavePlayerData();
    }

    public static void A531Superado(int amount531S)
    {
        playerData.A531S += amount531S;
        SavePlayerData();
    }

    public static void A532Jugado(int amount532J)
    {
        playerData.A532J += amount532J;
        SavePlayerData();
    }

    public static void A532Superado(int amount532S)
    {
        playerData.A532S += amount532S;
        SavePlayerData();
    }

    public static void A533Jugado(int amount533J)
    {
        playerData.A533J += amount533J;
        SavePlayerData();
    }

    public static void A533Superado(int amount533S)
    {
        playerData.A533S += amount533S;
        SavePlayerData();
    }

    public static void A541Jugado(int amount541J)
    {
        playerData.A541J += amount541J;
        SavePlayerData();
    }

    public static void A541Superado(int amount541S)
    {
        playerData.A541S += amount541S;
        SavePlayerData();
    }

    public static void A542Jugado(int amount542J)
    {
        playerData.A542J += amount542J;
        SavePlayerData();
    }

    public static void A542Superado(int amount542S)
    {
        playerData.A542S += amount542S;
        SavePlayerData();
    }

    public static void A543Jugado(int amount543J)
    {
        playerData.A543J += amount543J;
        SavePlayerData();
    }

    public static void A543Superado(int amount543S)
    {
        playerData.A543S += amount543S;
        SavePlayerData();
    }

    public static void A551Jugado(int amount551J)
    {
        playerData.A551J += amount551J;
        SavePlayerData();
    }

    public static void A551Superado(int amount551S)
    {
        playerData.A551S += amount551S;
        SavePlayerData();
    }

    public static void A552Jugado(int amount552J)
    {
        playerData.A552J += amount552J;
        SavePlayerData();
    }

    public static void A552Superado(int amount552S)
    {
        playerData.A552S += amount552S;
        SavePlayerData();
    }

    public static void A553Jugado(int amount553J)
    {
        playerData.A553J += amount553J;
        SavePlayerData();
    }

    public static void A553Superado(int amount553S)
    {
        playerData.A553S += amount553S;
        SavePlayerData();
    }

    public static void A554Jugado(int amount554J)
    {
        playerData.A554J += amount554J;
        SavePlayerData();
    }

    public static void A554Superado(int amount554S)
    {
        playerData.A554S += amount554S;
        SavePlayerData();
    }

    public static void A56Jugado(int amount56J)
    {
        playerData.A56J += amount56J;
        SavePlayerData();
    }

    public static void A56Superado(int amount56S)
    {
        playerData.A56S += amount56S;
        SavePlayerData();
    }

    public static void A57Jugado(int amount57J)
    {
        playerData.A57J += amount57J;
        SavePlayerData();
    }

    public static void A57Superado(int amount57S)
    {
        playerData.A57S += amount57S;
        SavePlayerData();
    }

    public static void A581Jugado(int amount581J)
    {
        playerData.A581J += amount581J;
        SavePlayerData();
    }

    public static void A581Superado(int amount581S)
    {
        playerData.A581S += amount581S;
        SavePlayerData();
    }

    public static void A582Jugado(int amount582J)
    {
        playerData.A582J += amount582J;
        SavePlayerData();
    }

    public static void A582Superado(int amount582S)
    {
        playerData.A582S += amount582S;
        SavePlayerData();
    }

    public static void A583Jugado(int amount583J)
    {
        playerData.A583J += amount583J;
        SavePlayerData();
    }

    public static void A583Superado(int amount583S)
    {
        playerData.A583S += amount583S;
        SavePlayerData();
    }

    public static void A584Jugado(int amount584J)
    {
        playerData.A584J += amount584J;
        SavePlayerData();
    }

    public static void A584Superado(int amount584S)
    {
        playerData.A584S += amount584S;
        SavePlayerData();
    }

    public static void A59Jugado(int amount59J)
    {
        playerData.A59J += amount59J;
        SavePlayerData();
    }

    public static void A59Superado(int amount59S)
    {
        playerData.A59S += amount59S;
        SavePlayerData();
    }

    public static void A5101Jugado(int amount5101J)
    {
        playerData.A5101J += amount5101J;
        SavePlayerData();
    }

    public static void A5101Superado(int amount5101S)
    {
        playerData.A5101S += amount5101S;
        SavePlayerData();
    }

    public static void A5102Jugado(int amount5102J)
    {
        playerData.A5102J += amount5102J;
        SavePlayerData();
    }

    public static void A5102Superado(int amount5102S)
    {
        playerData.A5102S += amount5102S;
        SavePlayerData();
    }

    public static void A5103Jugado(int amount5103J)
    {
        playerData.A5103J += amount5103J;
        SavePlayerData();
    }

    public static void A5103Superado(int amount5103S)
    {
        playerData.A5103S += amount5103S;
        SavePlayerData();
    }

    public static void A5111Jugado(int amount5111J)
    {
        playerData.A5111J += amount5111J;
        SavePlayerData();
    }

    public static void A5111Superado(int amount5111S)
    {
        playerData.A5111S += amount5111S;
        SavePlayerData();
    }

    public static void A5112Jugado(int amount5112J)
    {
        playerData.A5112J += amount5112J;
        SavePlayerData();
    }

    public static void A5112Superado(int amount5112S)
    {
        playerData.A5112S += amount5112S;
        SavePlayerData();
    }

    public static void A5113Jugado(int amount5113J)
    {
        playerData.A5113J += amount5113J;
        SavePlayerData();
    }

    public static void A5113Superado(int amount5113S)
    {
        playerData.A5113S += amount5113S;
        SavePlayerData();
    }

    public static void A5121Jugado(int amount5121J)
    {
        playerData.A5121J += amount5121J;
        SavePlayerData();
    }

    public static void A5121Superado(int amount5121S)
    {
        playerData.A5121S += amount5121S;
        SavePlayerData();
    }

    public static void A5122Jugado(int amount5122J)
    {
        playerData.A5122J += amount5122J;
        SavePlayerData();
    }

    public static void A5122Superado(int amount5122S)
    {
        playerData.A5122S += amount5122S;
        SavePlayerData();
    }

    public static void A5123Jugado(int amount5123J)
    {
        playerData.A5123J += amount5123J;
        SavePlayerData();
    }

    public static void A5123Superado(int amount5123S)
    {
        playerData.A5123S += amount5123S;
        SavePlayerData();
    }

    public static void A5124Jugado(int amount5124J)
    {
        playerData.A5124J += amount5124J;
        SavePlayerData();
    }

    public static void A5124Superado(int amount5124S)
    {
        playerData.A5124S += amount5124S;
        SavePlayerData();
    }

    public static void A611Jugado(int amount611J)
    {
        playerData.A611J += amount611J;
        SavePlayerData();
    }

    public static void A611Superado(int amount611S)
    {
        playerData.A611S += amount611S;
        SavePlayerData();
    }

    public static void A612Jugado(int amount612J)
    {
        playerData.A612J += amount612J;
        SavePlayerData();
    }

    public static void A612Superado(int amount612S)
    {
        playerData.A612S += amount612S;
        SavePlayerData();
    }

    public static void A62Jugado(int amount62J)
    {
        playerData.A62J += amount62J;
        SavePlayerData();
    }

    public static void A62Superado(int amount62S)
    {
        playerData.A62S += amount62S;
        SavePlayerData();
    }

    public static void A631Jugado(int amount631J)
    {
        playerData.A631J += amount631J;
        SavePlayerData();
    }

    public static void A631Superado(int amount631S)
    {
        playerData.A631S += amount631S;
        SavePlayerData();
    }

    public static void A632Jugado(int amount632J)
    {
        playerData.A632J += amount632J;
        SavePlayerData();
    }

    public static void A632Superado(int amount632S)
    {
        playerData.A632S += amount632S;
        SavePlayerData();
    }

    public static void A633Jugado(int amount633J)
    {
        playerData.A633J += amount633J;
        SavePlayerData();
    }

    public static void A633Superado(int amount633S)
    {
        playerData.A633S += amount633S;
        SavePlayerData();
    }

    public static void A634Jugado(int amount634J)
    {
        playerData.A634J += amount634J;
        SavePlayerData();
    }

    public static void A634Superado(int amount634S)
    {
        playerData.A634S += amount634S;
        SavePlayerData();
    }

    public static void A635Jugado(int amount635J)
    {
        playerData.A635J += amount635J;
        SavePlayerData();
    }

    public static void A635Superado(int amount635S)
    {
        playerData.A635S += amount635S;
        SavePlayerData();
    }

    public static void A64Jugado(int amount64J)
    {
        playerData.A64J += amount64J;
        SavePlayerData();
    }

    public static void A64Superado(int amount64S)
    {
        playerData.A64S += amount64S;
        SavePlayerData();
    }

    public static void A642Jugado(int amount642J)
    {
        playerData.A642J += amount642J;
        SavePlayerData();
    }

    public static void A642Superado(int amount642S)
    {
        playerData.A642S += amount642S;
        SavePlayerData();
    }

    public static void A643Jugado(int amount643J)
    {
        playerData.A643J += amount643J;
        SavePlayerData();
    }

    public static void A643Superado(int amount643S)
    {
        playerData.A643S += amount643S;
        SavePlayerData();
    }

    public static void A644Jugado(int amount644J)
    {
        playerData.A644J += amount644J;
        SavePlayerData();
    }

    public static void A644Superado(int amount644S)
    {
        playerData.A644S += amount644S;
        SavePlayerData();
    }

    public static void A645Jugado(int amount645J)
    {
        playerData.A645J += amount645J;
        SavePlayerData();
    }

    public static void A645Superado(int amount645S)
    {
        playerData.A645S += amount645S;
        SavePlayerData();
    }

    public static void A65Jugado(int amount65J)
    {
        playerData.A65J += amount65J;
        SavePlayerData();
    }

    public static void A65Superado(int amount65S)
    {
        playerData.A65S += amount65S;
        SavePlayerData();
    }

    public static void A66Jugado(int amount66J)
    {
        playerData.A66J += amount66J;
        SavePlayerData();
    }

    public static void A66Superado(int amount66S)
    {
        playerData.A66S += amount66S;
        SavePlayerData();
    }

    public static void A671Jugado(int amount671J)
    {
        playerData.A671J += amount671J;
        SavePlayerData();
    }

    public static void A671Superado(int amount671S)
    {
        playerData.A671S += amount671S;
        SavePlayerData();
    }

    public static void A672Jugado(int amount672J)
    {
        playerData.A672J += amount672J;
        SavePlayerData();
    }

    public static void A672Superado(int amount672S)
    {
        playerData.A672S += amount672S;
        SavePlayerData();
    }

    public static void A673Jugado(int amount673J)
    {
        playerData.A673J += amount673J;
        SavePlayerData();
    }

    public static void A673Superado(int amount673S)
    {
        playerData.A673S += amount673S;
        SavePlayerData();
    }

    public static void A674Jugado(int amount674J)
    {
        playerData.A674J += amount674J;
        SavePlayerData();
    }

    public static void A674Superado(int amount674S)
    {
        playerData.A674S += amount674S;
        SavePlayerData();
    }

    public static void A681Jugado(int amount681J)
    {
        playerData.A681J += amount681J;
        SavePlayerData();
    }

    public static void A681Superado(int amount681S)
    {
        playerData.A681S += amount681S;
        SavePlayerData();
    }

    public static void A682Jugado(int amount682J)
    {
        playerData.A682J += amount682J;
        SavePlayerData();
    }

    public static void A682Superado(int amount682S)
    {
        playerData.A682S += amount682S;
        SavePlayerData();
    }

    public static void A683Jugado(int amount683J)
    {
        playerData.A683J += amount683J;
        SavePlayerData();
    }

    public static void A683Superado(int amount683S)
    {
        playerData.A683S += amount683S;
        SavePlayerData();
    }

    public static void A691Jugado(int amount691J)
    {
        playerData.A691J += amount691J;
        SavePlayerData();
    }

    public static void A691Superado(int amount691S)
    {
        playerData.A691S += amount691S;
        SavePlayerData();
    }

    public static void A692Jugado(int amount692J)
    {
        playerData.A692J += amount692J;
        SavePlayerData();
    }

    public static void A692Superado(int amount692S)
    {
        playerData.A692S += amount692S;
        SavePlayerData();
    }

    public static void A693Jugado(int amount693J)
    {
        playerData.A693J += amount693J;
        SavePlayerData();
    }

    public static void A693Superado(int amount693S)
    {
        playerData.A693S += amount693S;
        SavePlayerData();
    }

    public static void A610Jugado(int amount610J)
    {
        playerData.A610J += amount610J;
        SavePlayerData();
    }

    public static void A610Superado(int amount610S)
    {
        playerData.A610S += amount610S;
        SavePlayerData();
    }

    public static void A6102Jugado(int amount6102J)
    {
        playerData.A6102J += amount6102J;
        SavePlayerData();
    }

    public static void A6102Superado(int amount6102S)
    {
        playerData.A6102S += amount6102S;
        SavePlayerData();
    }

    public static void A6103Jugado(int amount6103J)
    {
        playerData.A6103J += amount6103J;
        SavePlayerData();
    }

    public static void A6103Superado(int amount6103S)
    {
        playerData.A6103S += amount6103S;
        SavePlayerData();
    }

    public static void A6111Jugado(int amount6111J)
    {
        playerData.A6111J += amount6111J;
        SavePlayerData();
    }

    public static void A6111Superado(int amount6111S)
    {
        playerData.A6111S += amount6111S;
        SavePlayerData();
    }

    public static void A6112Jugado(int amount6112J)
    {
        playerData.A6112J += amount6112J;
        SavePlayerData();
    }

    public static void A6112Superado(int amount6112S)
    {
        playerData.A6112S += amount6112S;
        SavePlayerData();
    }

    public static void A6113Jugado(int amount6113J)
    {
        playerData.A6113J += amount6113J;
        SavePlayerData();
    }

    public static void A6113Superado(int amount6113S)
    {
        playerData.A6113S += amount6113S;
        SavePlayerData();
    }

    public static void A6114Jugado(int amount6114J)
    {
        playerData.A6114J += amount6114J;
        SavePlayerData();
    }

    public static void A6114Superado(int amount6114S)
    {
        playerData.A6114S += amount6114S;
        SavePlayerData();
    }

    public static void A6121Jugado(int amount6121J)
    {
        playerData.A6121J += amount6121J;
        SavePlayerData();
    }

    public static void A6121Superado(int amount6121S)
    {
        playerData.A6121S += amount6121S;
        SavePlayerData();
    }

    public static void A6122Jugado(int amount6122J)
    {
        playerData.A6122J += amount6122J;
        SavePlayerData();
    }

    public static void A6122Superado(int amount6122S)
    {
        playerData.A6122S += amount6122S;
        SavePlayerData();
    }

     public static void A6123Jugado(int amount6123J)
    {
        playerData.A6123J += amount6123J;
        SavePlayerData();
    }

    public static void A6123Superado(int amount6123S)
    {
        playerData.A6123S += amount6123S;
        SavePlayerData();
    }

    public static void A6124Jugado(int amount6124J)
    {
        playerData.A6124J += amount6124J;
        SavePlayerData();
    }

    public static void A6124Superado(int amount6124S)
    {
        playerData.A6124S += amount6124S;
        SavePlayerData();
    }

    public static void A6131Jugado(int amount6131J)
    {
        playerData.A6131J += amount6131J;
        SavePlayerData();
    }

    public static void A6131Superado(int amount6131S)
    {
        playerData.A6131S += amount6131S;
        SavePlayerData();
    }

    public static void A6132Jugado(int amount6132J)
    {
        playerData.A6132J += amount6132J;
        SavePlayerData();
    }

    public static void A6132Superado(int amount6132S)
    {
        playerData.A6132S += amount6132S;
        SavePlayerData();
    }

    public static void A6133Jugado(int amount6133J)
    {
        playerData.A6133J += amount6133J;
        SavePlayerData();
    }

    public static void A6133Superado(int amount6133S)
    {
        playerData.A6133S += amount6133S;
        SavePlayerData();
    }

    public static void A6134Jugado(int amount6134J)
    {
        playerData.A6134J += amount6134J;
        SavePlayerData();
    }

    public static void A6134Superado(int amount6134S)
    {
        playerData.A6134S += amount6134S;
        SavePlayerData();
    }

    public static void A6141Jugado(int amount6141J)
    {
        playerData.A6141J += amount6141J;
        SavePlayerData();
    }

    public static void A6141Superado(int amount6141S)
    {
        playerData.A6141S += amount6141S;
        SavePlayerData();
    }

    public static void A6142Jugado(int amount6142J)
    {
        playerData.A6142J += amount6142J;
        SavePlayerData();
    }

    public static void A6142Superado(int amount6142S)
    {
        playerData.A6142S += amount6142S;
        SavePlayerData();
    }

    public static void A6143Jugado(int amount6143J)
    {
        playerData.A6143J += amount6143J;
        SavePlayerData();
    }

    public static void A6143Superado(int amount6143S)
    {
        playerData.A6143S += amount6143S;
        SavePlayerData();
    }

    public static void A6151Jugado(int amount6151J)
    {
        playerData.A6151J += amount6151J;
        SavePlayerData();
    }

    public static void A6151Superado(int amount6151S)
    {
        playerData.A6151S += amount6151S;
        SavePlayerData();
    }

    public static void A6152Jugado(int amount6152J)
    {
        playerData.A6152J += amount6152J;
        SavePlayerData();
    }

    public static void A6152Superado(int amount6152S)
    {
        playerData.A6152S += amount6152S;
        SavePlayerData();
    }

    public static void A6153Jugado(int amount6153J)
    {
        playerData.A6153J += amount6153J;
        SavePlayerData();
    }

    public static void A6153Superado(int amount6153S)
    {
        playerData.A6153S += amount6153S;
        SavePlayerData();
    }

    public static void A6161Jugado(int amount6161J)
    {
        playerData.A6161J += amount6161J;
        SavePlayerData();
    }

    public static void A6161Superado(int amount6161S)
    {
        playerData.A6161S += amount6161S;
        SavePlayerData();
    }

    public static void A6162Jugado(int amount6162J)
    {
        playerData.A6162J += amount6162J;
        SavePlayerData();
    }

    public static void A6162Superado(int amount6162S)
    {
        playerData.A6162S += amount6162S;
        SavePlayerData();
    }

    public static void A6163Jugado(int amount6163J)
    {
        playerData.A6163J += amount6163J;
        SavePlayerData();
    }

    public static void A6163Superado(int amount6163S)
    {
        playerData.A6163S += amount6163S;
        SavePlayerData();
    }

    public static void A711Jugado(int amount711J)
    {
        playerData.A711J += amount711J;
        SavePlayerData();
    }

    public static void A711Superado(int amount711S)
    {
        playerData.A711S += amount711S;
        SavePlayerData();
    }

    public static void A712Jugado(int amount712J)
    {
        playerData.A712J += amount712J;
        SavePlayerData();
    }

    public static void A712Superado(int amount712S)
    {
        playerData.A712S += amount712S;
        SavePlayerData();
    }

    public static void A713Jugado(int amount713J)
    {
        playerData.A713J += amount713J;
        SavePlayerData();
    }

    public static void A713Superado(int amount713S)
    {
        playerData.A713S += amount713S;
        SavePlayerData();
    }

    public static void A714Jugado(int amount714J)
    {
        playerData.A714J += amount714J;
        SavePlayerData();
    }

    public static void A714Superado(int amount714S)
    {
        playerData.A714S += amount714S;
        SavePlayerData();
    }

    public static void A715Jugado(int amount715J)
    {
        playerData.A715J += amount715J;
        SavePlayerData();
    }

    public static void A715Superado(int amount715S)
    {
        playerData.A715S += amount715S;
        SavePlayerData();
    }

    public static void A721Jugado(int amount721J)
    {
        playerData.A721J += amount721J;
        SavePlayerData();
    }

    public static void A721Superado(int amount721S)
    {
        playerData.A721S += amount721S;
        SavePlayerData();
    }

    public static void A722Jugado(int amount722J)
    {
        playerData.A722J += amount722J;
        SavePlayerData();
    }

    public static void A722Superado(int amount722S)
    {
        playerData.A722S += amount722S;
        SavePlayerData();
    }

    public static void A723Jugado(int amount723J)
    {
        playerData.A723J += amount723J;
        SavePlayerData();
    }

    public static void A723Superado(int amount723S)
    {
        playerData.A723S += amount723S;
        SavePlayerData();
    }


    public static void A731Jugado(int amount731J)
    {
        playerData.A731J += amount731J;
        SavePlayerData();
    }

    public static void A731Superado(int amount731S)
    {
        playerData.A731S += amount731S;
        SavePlayerData();
    }

    public static void A732Jugado(int amount732J)
    {
        playerData.A732J += amount732J;
        SavePlayerData();
    }

    public static void A732Superado(int amount732S)
    {
        playerData.A732S += amount732S;
        SavePlayerData();
    }

    public static void A733Jugado(int amount733J)
    {
        playerData.A733J += amount733J;
        SavePlayerData();
    }

    public static void A733Superado(int amount733S)
    {
        playerData.A733S += amount733S;
        SavePlayerData();
    }

    public static void A74Jugado(int amount74J)
    {
        playerData.A74J += amount74J;
        SavePlayerData();
    }

    public static void A74Superado(int amount74S)
    {
        playerData.A74S += amount74S;
        SavePlayerData();
    }

    public static void A751Jugado(int amount751J)
    {
        playerData.A751J += amount751J;
        SavePlayerData();
    }

    public static void A751Superado(int amount751S)
    {
        playerData.A751S += amount751S;
        SavePlayerData();
    }

    public static void A752Jugado(int amount752J)
    {
        playerData.A752J += amount752J;
        SavePlayerData();
    }

    public static void A752Superado(int amount752S)
    {
        playerData.A752S += amount752S;
        SavePlayerData();
    }

    public static void A753Jugado(int amount753J)
    {
        playerData.A753J += amount753J;
        SavePlayerData();
    }

    public static void A753Superado(int amount753S)
    {
        playerData.A753S += amount753S;
        SavePlayerData();
    }

    public static void A76Jugado(int amount76J)
    {
        playerData.A76J += amount76J;
        SavePlayerData();
    }

    public static void A76Superado(int amount76S)
    {
        playerData.A76S += amount76S;
        SavePlayerData();
    }

    public static void A771Jugado(int amount771J)
    {
        playerData.A771J += amount771J;
        SavePlayerData();
    }

    public static void A771Superado(int amount771S)
    {
        playerData.A771S += amount771S;
        SavePlayerData();
    }

    public static void A772Jugado(int amount772J)
    {
        playerData.A772J += amount772J;
        SavePlayerData();
    }

    public static void A772Superado(int amount772S)
    {
        playerData.A772S += amount772S;
        SavePlayerData();
    }

    public static void A773Jugado(int amount773J)
    {
        playerData.A773J += amount773J;
        SavePlayerData();
    }

    public static void A773Superado(int amount773S)
    {
        playerData.A773S += amount773S;
        SavePlayerData();
    }

    public static void A79Jugado(int amount79J)
    {
        playerData.A79J += amount79J;
        SavePlayerData();
    }

    public static void A79Superado(int amount79S)
    {
        playerData.A79S += amount79S;
        SavePlayerData();
    }

    public static void A792Jugado(int amount792J)
    {
        playerData.A792J += amount792J;
        SavePlayerData();
    }

    public static void A792Superado(int amount792S)
    {
        playerData.A792S += amount792S;
        SavePlayerData();
    }

    public static void A793Jugado(int amount793J)
    {
        playerData.A793J += amount793J;
        SavePlayerData();
    }

    public static void A793Superado(int amount793S)
    {
        playerData.A793S += amount793S;
        SavePlayerData();
    }

    public static void A7101Jugado(int amount7101J)
    {
        playerData.A7101J += amount7101J;
        SavePlayerData();
    }

    public static void A7101Superado(int amount7101S)
    {
        playerData.A7101S += amount7101S;
        SavePlayerData();
    }

    public static void A7102Jugado(int amount7102J)
    {
        playerData.A7102J += amount7102J;
        SavePlayerData();
    }

    public static void A7102Superado(int amount7102S)
    {
        playerData.A7102S += amount7102S;
        SavePlayerData();
    }

    public static void A7103Jugado(int amount7103J)
    {
        playerData.A7103J += amount7103J;
        SavePlayerData();
    }

    public static void A7103Superado(int amount7103S)
    {
        playerData.A7103S += amount7103S;
        SavePlayerData();
    }

    public static void A25DAJugado(int amount25DA)
    {
        playerData.A25DA += amount25DA;
        SavePlayerData();
    }

    public static void A25DEJugado(int amount25DE)
    {
        playerData.A25DE += amount25DE;
        SavePlayerData();
    }

    public static void A25DIJugado(int amount25DI)
    {
        playerData.A25DI += amount25DI;
        SavePlayerData();
    }

    public static void A25DOJugado(int amount25DO)
    {
        playerData.A25DO += amount25DO;
        SavePlayerData();
    }

    public static void A25DUJugado(int amount25DU)
    {
        playerData.A25DU += amount25DU;
        SavePlayerData();
    }

    public static void A25LAJugado(int amount25LA)
    {
        playerData.A25LA += amount25LA;
        SavePlayerData();
    }

    public static void A25LEJugado(int amount25LE)
    {
        playerData.A25LE += amount25LE;
        SavePlayerData();
    }

    public static void A25LIJugado(int amount25LI)
    {
        playerData.A25LI += amount25LI;
        SavePlayerData();
    }

    public static void A25LOJugado(int amount25LO)
    {
        playerData.A25LO += amount25LO;
        SavePlayerData();
    }

    public static void A25LUJugado(int amount25LU)
    {
        playerData.A25LU += amount25LU;
        SavePlayerData();
    }

    public static void A25MAJugado(int amount25MA)
    {
        playerData.A25MA += amount25MA;
        SavePlayerData();
    }

    public static void A25MEJugado(int amount25ME)
    {
        playerData.A25ME += amount25ME;
        SavePlayerData();
    }

    public static void A25MIJugado(int amount25MI)
    {
        playerData.A25MI += amount25MI;
        SavePlayerData();
    }

    public static void A25MOJugado(int amount25MO)
    {
        playerData.A25MO += amount25MO;
        SavePlayerData();
    }

    public static void A25MUJugado(int amount25MU)
    {
        playerData.A25MU += amount25MU;
        SavePlayerData();
    }

    public static void A25NAJugado(int amount25NA)
    {
        playerData.A25NA += amount25NA;
        SavePlayerData();
    }

    public static void A25NEJugado(int amount25NE)
    {
        playerData.A25NE += amount25NE;
        SavePlayerData();
    }

    public static void A25NIJugado(int amount25NI)
    {
        playerData.A25NI += amount25NI;
        SavePlayerData();
    }

    public static void A25NOJugado(int amount25NO)
    {
        playerData.A25NO += amount25NO;
        SavePlayerData();
    }

    public static void A25NUJugado(int amount25NU)
    {
        playerData.A25NU += amount25NU;
        SavePlayerData();
    }

    public static void A25PAJugado(int amount25PA)
    {
        playerData.A25PA += amount25PA;
        SavePlayerData();
    }

    public static void A25PEJugado(int amount25PE)
    {
        playerData.A25PE += amount25PE;
        SavePlayerData();
    }

    public static void A25PIJugado(int amount25PI)
    {
        playerData.A25PI += amount25PI;
        SavePlayerData();
    }

    public static void A25POJugado(int amount25PO)
    {
        playerData.A25PO += amount25PO;
        SavePlayerData();
    }

    public static void A25PUJugado(int amount25PU)
    {
        playerData.A25PU += amount25PU;
        SavePlayerData();
    }

    public static void A25SAJugado(int amount25SA)
    {
        playerData.A25SA += amount25SA;
        SavePlayerData();
    }

    public static void A25SEJugado(int amount25SE)
    {
        playerData.A25SE += amount25SE;
        SavePlayerData();
    }

    public static void A25SIJugado(int amount25SI)
    {
        playerData.A25SI += amount25SI;
        SavePlayerData();
    }

    public static void A25SOJugado(int amount25SO)
    {
        playerData.A25SO += amount25SO;
        SavePlayerData();
    }

    public static void A25SUJugado(int amount25SU)
    {
        playerData.A25SU += amount25SU;
        SavePlayerData();
    }

    public static void A31AJugado(int amount31A)
    {
        playerData.A31A += amount31A;
        SavePlayerData();
    }

    public static void A31DJugado(int amount31D)
    {
        playerData.A31D += amount31D;
        SavePlayerData();
    }

    public static void A31EJugado(int amount31E)
    {
        playerData.A31E += amount31E;
        SavePlayerData();
    }

    public static void A31FJugado(int amount31F)
    {
        playerData.A31F += amount31F;
        SavePlayerData();
    }

    public static void A31IJugado(int amount31I)
    {
        playerData.A31I += amount31I;
        SavePlayerData();
    }

    public static void A31LJugado(int amount31L)
    {
        playerData.A31L += amount31L;
        SavePlayerData();
    }

    public static void A31MJugado(int amount31M)
    {
        playerData.A31M += amount31M;
        SavePlayerData();
    }

    public static void A31NJugado(int amount31N)
    {
        playerData.A31N += amount31N;
        SavePlayerData();
    }

    public static void A31OJugado(int amount31O)
    {
        playerData.A31O += amount31O;
        SavePlayerData();
    }

    public static void A31PJugado(int amount31P)
    {
        playerData.A31P += amount31P;
        SavePlayerData();
    }

    public static void A31RJugado(int amount31R)
    {
        playerData.A31R += amount31R;
        SavePlayerData();
    }

    public static void A31SJugado(int amount31S)
    {
        playerData.A31S += amount31S;
        SavePlayerData();
    }

    public static void A31TJugado(int amount31T)
    {
        playerData.A31T += amount31T;
        SavePlayerData();
    }

    public static void A31UJugado(int amount31U)
    {
        playerData.A31U += amount31U;
        SavePlayerData();
    }

    public static void A321Jugado(int amount321)
    {
        playerData.A321 += amount321;
        SavePlayerData();
    }

    public static void A322Jugado(int amount322)
    {
        playerData.A322 += amount322;
        SavePlayerData();
    }

    public static void A323Jugado(int amount323)
    {
        playerData.A323 += amount323;
        SavePlayerData();
    }

    public static void A324Jugado(int amount324)
    {
        playerData.A324 += amount324;
        SavePlayerData();
    }

    public static void A325Jugado(int amount325)
    {
        playerData.A325 += amount325;
        SavePlayerData();
    }

    public static void A326Jugado(int amount326)
    {
        playerData.A326 += amount326;
        SavePlayerData();
    }

    public static void A327Jugado(int amount327)
    {
        playerData.A327 += amount327;
        SavePlayerData();
    }

    public static void A328Jugado(int amount328)
    {
        playerData.A328 += amount328;
        SavePlayerData();
    }

    public static void A329Jugado(int amount329)
    {
        playerData.A329 += amount329;
        SavePlayerData();
    }

    public static void A3210Jugado(int amount3210)
    {
        playerData.A3210 += amount3210;
        SavePlayerData();
    }

    public static void A3211Jugado(int amount3211)
    {
        playerData.A3211 += amount3211;
        SavePlayerData();
    }

    public static void A3212Jugado(int amount3212)
    {
        playerData.A3212 += amount3212;
        SavePlayerData();
    }

    public static void A3213Jugado(int amount3213)
    {
        playerData.A3213 += amount3213;
        SavePlayerData();
    }

    public static void A3214Jugado(int amount3214)
    {
        playerData.A3214 += amount3214;
        SavePlayerData();
    }

    public static void A3215Jugado(int amount3215)
    {
        playerData.A3215 += amount3215;
        SavePlayerData();
    }

    public static void A781Jugado(int amount781)
    {
        playerData.A781 += amount781;
        SavePlayerData();
    }

    public static void A782Jugado(int amount782)
    {
        playerData.A782 += amount782;
        SavePlayerData();
    }

    public static void A783Jugado(int amount783)
    {
        playerData.A783 += amount783;
        SavePlayerData();
    }

    public static void A784Jugado(int amount784)
    {
        playerData.A784 += amount784;
        SavePlayerData();
    }

    public static void A785Jugado(int amount785)
    {
        playerData.A785 += amount785;
        SavePlayerData();
    }

    public static void A25DAS(int amount25DAS)
    {
        playerData.A25DAS += amount25DAS;
        SavePlayerData();
    }

    public static void A25DES(int amount25DES)
    {
        playerData.A25DES += amount25DES;
        SavePlayerData();
    }

    public static void A25DIS(int amount25DIS)
    {
        playerData.A25DIS += amount25DIS;
        SavePlayerData();
    }

    public static void A25DOS(int amount25DOS)
    {
        playerData.A25DOS += amount25DOS;
        SavePlayerData();
    }

    public static void A25DUS(int amount25DUS)
    {
        playerData.A25DUS += amount25DUS;
        SavePlayerData();
    }

    public static void A25LAS(int amount25LAS)
    {
        playerData.A25LAS += amount25LAS;
        SavePlayerData();
    }

    public static void A25LES(int amount25LES)
    {
        playerData.A25LES += amount25LES;
        SavePlayerData();
    }

    public static void A25LIS(int amount25LIS)
    {
        playerData.A25LIS += amount25LIS;
        SavePlayerData();
    }

    public static void A25LOS(int amount25LOS)
    {
        playerData.A25LOS += amount25LOS;
        SavePlayerData();
    }

    public static void A25LUS(int amount25LUS)
    {
        playerData.A25LUS += amount25LUS;
        SavePlayerData();
    }

    public static void A25MAS(int amount25MAS)
    {
        playerData.A25MAS += amount25MAS;
        SavePlayerData();
    }

    public static void A25MES(int amount25MES)
    {
        playerData.A25MES += amount25MES;
        SavePlayerData();
    }

    public static void A25MIS(int amount25MIS)
    {
        playerData.A25MIS += amount25MIS;
        SavePlayerData();
    }

    public static void A25MOS(int amount25MOS)
    {
        playerData.A25MOS += amount25MOS;
        SavePlayerData();
    }

    public static void A25MUS(int amount25MUS)
    {
        playerData.A25MUS += amount25MUS;
        SavePlayerData();
    }

    public static void A25NAS(int amount25NAS)
    {
        playerData.A25NAS += amount25NAS;
        SavePlayerData();
    }

    public static void A25NES(int amount25NES)
    {
        playerData.A25NES += amount25NES;
        SavePlayerData();
    }

    public static void A25NIS(int amount25NIS)
    {
        playerData.A25NIS += amount25NIS;
        SavePlayerData();
    }

    public static void A25NOS(int amount25NOS)
    {
        playerData.A25NOS += amount25NOS;
        SavePlayerData();
    }

    public static void A25NUS(int amount25NUS)
    {
        playerData.A25NUS += amount25NUS;
        SavePlayerData();
    }

    public static void A25PAS(int amount25PAS)
    {
        playerData.A25PAS += amount25PAS;
        SavePlayerData();
    }

    public static void A25PES(int amount25PES)
    {
        playerData.A25PES += amount25PES;
        SavePlayerData();
    }

    public static void A25PIS(int amount25PIS)
    {
        playerData.A25PIS += amount25PIS;
        SavePlayerData();
    }

    public static void A25POS(int amount25POS)
    {
        playerData.A25POS += amount25POS;
        SavePlayerData();
    }

    public static void A25PUS(int amount25PUS)
    {
        playerData.A25PUS += amount25PUS;
        SavePlayerData();
    }

    public static void A25SAS(int amount25SAS)
    {
        playerData.A25SAS += amount25SAS;
        SavePlayerData();
    }

    public static void A25SES(int amount25SES)
    {
        playerData.A25SES += amount25SES;
        SavePlayerData();
    }

    public static void A25SIS(int amount25SIS)
    {
        playerData.A25SIS += amount25SIS;
        SavePlayerData();
    }

    public static void A25SOS(int amount25SOS)
    {
        playerData.A25SOS += amount25SOS;
        SavePlayerData();
    }

    public static void A25SUS(int amount25SUS)
    {
        playerData.A25SUS += amount25SUS;
        SavePlayerData();
    }

    public static void A31AS(int amount31AS)
    {
        playerData.A31AS += amount31AS;
        SavePlayerData();
    }

    public static void A31DS(int amount31DS)
    {
        playerData.A31DS += amount31DS;
        SavePlayerData();
    }

    public static void A31ES(int amount31ES)
    {
        playerData.A31ES += amount31ES;
        SavePlayerData();
    }

    public static void A31FS(int amount31FS)
    {
        playerData.A31FS += amount31FS;
        SavePlayerData();
    }

    public static void A31IS(int amount31IS)
    {
        playerData.A31IS += amount31IS;
        SavePlayerData();
    }

    public static void A31LS(int amount31LS)
    {
        playerData.A31LS += amount31LS;
        SavePlayerData();
    }

    public static void A31MS(int amount31MS)
    {
        playerData.A31MS += amount31MS;
        SavePlayerData();
    }

    public static void A31NS(int amount31NS)
    {
        playerData.A31NS += amount31NS;
        SavePlayerData();
    }

    public static void A31OS(int amount31OS)
    {
        playerData.A31OS += amount31OS;
        SavePlayerData();
    }

    public static void A31PS(int amount31PS)
    {
        playerData.A31PS += amount31PS;
        SavePlayerData();
    }

    public static void A31RS(int amount31RS)
    {
        playerData.A31RS += amount31RS;
        SavePlayerData();
    }

    public static void A31SS(int amount31SS)
    {
        playerData.A31SS += amount31SS;
        SavePlayerData();
    }

    public static void A31TS(int amount31TS)
    {
        playerData.A31TS += amount31TS;
        SavePlayerData();
    }

    public static void A31US(int amount31US)
    {
        playerData.A31US += amount31US;
        SavePlayerData();
    }

    public static void A321S(int amount321S)
    {
        playerData.A321S += amount321S;
        SavePlayerData();
    }

    public static void A322S(int amount322S)
    {
        playerData.A322S += amount322S;
        SavePlayerData();
    }

    public static void A323S(int amount323S)
    {
        playerData.A323S += amount323S;
        SavePlayerData();
    }

    public static void A324S(int amount324S)
    {
        playerData.A324S += amount324S;
        SavePlayerData();
    }

    public static void A325S(int amount325S)
    {
        playerData.A325S += amount325S;
        SavePlayerData();
    }

    public static void A326S(int amount326S)
    {
        playerData.A326S += amount326S;
        SavePlayerData();
    }

    public static void A327S(int amount327S)
    {
        playerData.A327S += amount327S;
        SavePlayerData();
    }

    public static void A328S(int amount328S)
    {
        playerData.A328S += amount328S;
        SavePlayerData();
    }

    public static void A329S(int amount329S)
    {
        playerData.A329S += amount329S;
        SavePlayerData();
    }

    public static void A3210S(int amount3210S)
    {
        playerData.A3210S += amount3210S;
        SavePlayerData();
    }

    public static void A3211S(int amount3211S)
    {
        playerData.A3211S += amount3211S;
        SavePlayerData();
    }

    public static void A3212S(int amount3212S)
    {
        playerData.A3212S += amount3212S;
        SavePlayerData();
    }

    public static void A3213S(int amount3213S)
    {
        playerData.A3213S += amount3213S;
        SavePlayerData();
    }

    public static void A3214S(int amount3214S)
    {
        playerData.A3214S += amount3214S;
        SavePlayerData();
    }

    public static void A3215S(int amount3215S)
    {
        playerData.A3215S += amount3215S;
        SavePlayerData();
    }

    public static void A781S(int amount781S)
    {
        playerData.A781S += amount781S;
        SavePlayerData();
    }

    public static void A782S(int amount782S)
    {
        playerData.A782S += amount782S;
        SavePlayerData();
    }

    public static void A783S(int amount783S)
    {
        playerData.A783S += amount783S;
        SavePlayerData();
    }

    public static void A784S(int amount784S)
    {
        playerData.A784S += amount784S;
        SavePlayerData();
    }

    public static void A785S(int amount785S)
    {
        playerData.A785S += amount785S;
        SavePlayerData();
    }

    public static void A81Jugado(int amount81)
    {
        playerData.A81 += amount81;
        SavePlayerData();
    }

    public static void A82Jugado(int amount82)
    {
        playerData.A82 += amount82;
        SavePlayerData();
    }

    public static void A83Jugado(int amount83)
    {
        playerData.A83 += amount83;
        SavePlayerData();
    }

    public static void A84Jugado(int amount84)
    {
        playerData.A84 += amount84;
        SavePlayerData();
    }

    public static void A85Jugado(int amount85)
    {
        playerData.A85 += amount85;
        SavePlayerData();
    }

    public static void A86Jugado(int amount86)
    {
        playerData.A86 += amount86;
        SavePlayerData();
    }

    public static void A87Jugado(int amount87)
    {
        playerData.A87 += amount87;
        SavePlayerData();
    }

    public static void A88Jugado(int amount88)
    {
        playerData.A88 += amount88;
        SavePlayerData();
    }

    public static void A891Jugado(int amount891)
    {
        playerData.A891 += amount891;
        SavePlayerData();
    }

    public static void A892Jugado(int amount892)
    {
        playerData.A892 += amount892;
        SavePlayerData();
    }

    public static void A893Jugado(int amount893)
    {
        playerData.A893 += amount893;
        SavePlayerData();
    }

    public static void A810Jugado(int amount810)
    {
        playerData.A810 += amount810;
        SavePlayerData();
    }




    






    public static bool CanSpendCoins(int amount)
    {
        return (playerData.coins >= amount);
    }
    

    public static void SpendCoins(int amount)
    {
        playerData.coins -= amount;
        SavePlayerData();
    }

    static void LoadPlayerData()
    {
        playerData = BinarySerializer.Load<PlayerData> ("player-data.txt");
        UnityEngine.Debug.Log ("color=green>[PlayerData] Loaded.</color>");
    }

    static void SavePlayerData()
    {
        BinarySerializer.Save (playerData, "player-data.txt");
        UnityEngine.Debug.Log ("color=magenta>[PlayerData] Saved.</color>");
        
        

    }

    public static void AddPurchasedCharacter(int characterIndex)
    {
        charactersShopData.purchasedCharactersIndexes.Add (characterIndex);
        SaveCharactersShopData();

    }

    public static void AddPurchasedCharacter2(int characterIndex2)
    {
        charactersShopData2.purchasedCharactersIndexes2.Add (characterIndex2);
        SaveCharactersShopData2();

    }

    public static List<int> GetAllPurchasedCharacter()
    {
        return charactersShopData.purchasedCharactersIndexes;

    }

    public static List<int> GetAllPurchasedCharacter2()
    {
        return charactersShopData2.purchasedCharactersIndexes2;

    }

    public static int GetPurchasedCharacter(int index)
    {
        return charactersShopData.purchasedCharactersIndexes [index];

    }

    public static int GetPurchasedCharacter2(int index)
    {
        return charactersShopData2.purchasedCharactersIndexes2 [index];

    }

    static void LoadCharactersShopData()
    {
        charactersShopData  = BinarySerializer.Load<CharactersShopData> ("shop-data.txt");
        UnityEngine.Debug.Log ("color=green>[CharactersShopData] Loaded.</color>");
    }

    static void LoadCharactersShopData2()
    {
        charactersShopData2  = BinarySerializer.Load<CharactersShopData2> ("shop-data2.txt");
        UnityEngine.Debug.Log ("color=green>[CharactersShopData2] Loaded.</color>");
    }

    static void SaveCharactersShopData()
    {
        BinarySerializer.Save (charactersShopData , "shop-data.txt");
        UnityEngine.Debug.Log ("color=magenta>[CharactersShopData] Saved.</color>");

    }

    static void SaveCharactersShopData2()
    {
        BinarySerializer.Save (charactersShopData2 , "shop-data2.txt");
        UnityEngine.Debug.Log ("color=magenta>[CharactersShopData2] Saved.</color>");

    }
  
}
