Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic.CompilerServices

Public Class Form1
    Dim draw As System.Drawing.Graphics
    Dim viewer(2) As Integer
    Dim light(2) As Integer
    Dim sap1 As New Sphere
    Dim mir1 As New Mirror

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        draw = PictureBoxScreen.CreateGraphics()
        sap1.r = 25

        'center of sphere coordinate
        sap1.center(0) = 0
        sap1.center(1) = 0
        sap1.center(2) = 0

        'mirror coordinate
        'mir1.p1(0) = -50
        'mir1.p1(1) = -100
        'mir1.p1(2) = -50
        'mir1.p2(0) = 50
        'mir1.p2(1) = -100
        'mir1.p2(2) = -50
        'mir1.p3(0) = 50
        'mir1.p3(1) = -100
        'mir1.p3(2) = 50
        'mir1.p4(0) = -50
        'mir1.p4(1) = -100
        'mir1.p4(2) = 50


        'viewer coordinate
        viewer(0) = 0
        viewer(1) = 0
        viewer(2) = 200


    End Sub

    Function normalisation(ByVal arr As Double()) As Double()
        Dim temp(2) As Double
        Dim tot As Double = Math.Sqrt((arr(0) ^ 2) + (arr(1) ^ 2) + (arr(2) ^ 2))
        temp(0) = arr(0) * 1 / tot
        temp(1) = arr(1) * 1 / tot
        temp(2) = arr(2) * 1 / tot
        Return temp
    End Function

    '  Sub setrowmatrix(ByRef m(,) As Double, ByRef row As Integer, ByRef a As Double, ByRef b As Double, ByRef c As Double, ByRef d As Double)
    '     m(row, 0) = a
    '    m(row, 1) = b
    '   m(row, 2) = c
    '  m(row, 3) = d
    ' End Sub

    Function sin(ByVal a As Double) As Double
        Dim res As Double
        a = a * 3.14 / 180
        res = Math.Sin(a)
        Return res
    End Function

    Function cos(ByVal a As Double) As Double
        Dim res As Double
        a = a * 3.14 / 180
        res = Math.Cos(a)
        Return res
    End Function

    ' Function mulmatrix(ByRef a(,) As Double, ByRef b(,) As Double, ByRef n As Integer) As Double()
    'Dim res(4) As Double
    '   res(0) = a(n, 0) * b(0, 0) + a(n, 1) * b(1, 0) + a(n, 2) * b(2, 0) + a(n, 3) * b(3, 0)
    '  res(1) = a(n, 0) * b(0, 1) + a(n, 1) * b(1, 1) + a(n, 2) * b(2, 1) + a(n, 3) * b(3, 1)
    ' res(2) = a(n, 0) * b(0, 2) + a(n, 1) * b(1, 2) + a(n, 2) * b(2, 2) + a(n, 3) * b(3, 2)
    'res(3) = a(n, 0) * b(0, 3) + a(n, 1) * b(1, 3) + a(n, 2) * b(2, 3) + a(n, 3) * b(3, 3)
    'Return res
    'End Function

    Function dot(ByVal arr1 As Double(), ByVal arr2 As Double()) As Double
        Dim tot As Double = arr1(0) * arr2(0) + arr1(1) * arr2(1) + arr1(2) * arr2(2)
        Return tot
    End Function

    Sub DrawGraph()
        light(0) = CInt(TextBox1.Text)
        light(1) = -CInt(TextBox2.Text)
        light(2) = CInt(TextBox3.Text)
        PictureBoxScreen.Refresh()
        Dim s(2), rd(2) As Double
        Dim d2, t, td As Double
        Dim ka, kd, ks, kr As Double
        Dim Li As Double = 1
        Dim paint As New Color
        Dim kn As Double = CDbl(TextBox11.Text)
        Dim resp1(2), resp2(2), resp3(2), resp4(2) As Double
        ka = CDbl(TextBox4.Text)
        kd = CDbl(TextBox5.Text)
        ks = CDbl(TextBox6.Text)
        kr = CDbl(TextBox10.Text)
        sap1.center(0) = CInt(TextBoxSCX.Text)
        sap1.center(1) = -CInt(TextBoxSCY.Text)
        sap1.center(2) = CInt(TextBoxSCZ.Text)
        mir1.p1(0) = -50 + CInt(TextBox7.Text)
        mir1.p1(1) = CInt(TextBox8.Text)
        mir1.p1(2) = -50 + CInt(TextBox9.Text)
        mir1.p2(0) = 50 + CInt(TextBox7.Text)
        mir1.p2(1) = CInt(TextBox8.Text)
        mir1.p2(2) = -50 + CInt(TextBox9.Text)
        mir1.p3(0) = 50 + CInt(TextBox7.Text)
        mir1.p3(1) = CInt(TextBox8.Text)
        mir1.p3(2) = 50 + CInt(TextBox9.Text)
        mir1.p4(0) = -50 + CInt(TextBox7.Text)
        mir1.p4(1) = CInt(TextBox8.Text)
        mir1.p4(2) = 50 + CInt(TextBox9.Text)

        viewer(0) = 0
        viewer(1) = 0
        viewer(2) = 200
        s(0) = sap1.center(0) - viewer(0)
        s(1) = sap1.center(1) - viewer(1)
        s(2) = sap1.center(2) - viewer(2)

        sap1.center(0) = CInt(TextBoxSCX.Text)
        sap1.center(1) = -CInt(TextBoxSCY.Text)
        sap1.center(2) = CInt(TextBoxSCZ.Text)
        mir1.p1(0) = -50 + CInt(TextBox7.Text)
        mir1.p1(1) = CInt(TextBox8.Text)
        mir1.p1(2) = -50 + CInt(TextBox9.Text)
        mir1.p2(0) = 50 + CInt(TextBox7.Text)
        mir1.p2(1) = CInt(TextBox8.Text)
        mir1.p2(2) = -50 + CInt(TextBox9.Text)
        mir1.p3(0) = 50 + CInt(TextBox7.Text)
        mir1.p3(1) = CInt(TextBox8.Text)
        mir1.p3(2) = 50 + CInt(TextBox9.Text)
        mir1.p4(0) = -50 + CInt(TextBox7.Text)
        mir1.p4(1) = CInt(TextBox8.Text)
        mir1.p4(2) = 50 + CInt(TextBox9.Text)

        If (CDbl(TextBox12.Text) < 0 Or CDbl(TextBox12.Text) > 0) Then 'Kondisi dibawah ini untuk rotasi mirror di sumbu X :
            resp1(0) = (mir1.p1(0) * 1) + (mir1.p1(1) * 0) + (mir1.p1(2) * 0) + (1 * 0)
            resp1(1) = (mir1.p1(0) * 0) + (mir1.p1(1) * cos(CDbl(TextBox12.Text))) + (mir1.p1(2) * sin(CDbl(TextBox12.Text))) + (1 * 0)
            resp1(2) = (mir1.p1(0) * 0) + (mir1.p1(1) * -sin(CDbl(TextBox12.Text))) + (mir1.p1(2) * cos(CDbl(TextBox12.Text))) + (1 * 0)

            resp2(0) = (mir1.p2(0) * 1) + (mir1.p2(1) * 0) + (mir1.p2(2) * 0) + (1 * 0)
            resp2(1) = (mir1.p2(0) * 0) + (mir1.p2(1) * cos(CDbl(TextBox12.Text))) + (mir1.p2(2) * sin(CDbl(TextBox12.Text))) + (1 * 0)
            resp2(2) = (mir1.p2(0) * 0) + (mir1.p2(1) * -sin(CDbl(TextBox12.Text))) + (mir1.p2(2) * cos(CDbl(TextBox12.Text))) + (1 * 0)

            resp3(0) = (mir1.p3(0) * 1) + (mir1.p3(1) * 0) + (mir1.p3(2) * 0) + (1 * 0)
            resp3(1) = (mir1.p3(0) * 0) + (mir1.p3(1) * cos(CDbl(TextBox12.Text))) + (mir1.p3(2) * sin(CDbl(TextBox12.Text))) + (1 * 0)
            resp3(2) = (mir1.p3(0) * 0) + (mir1.p3(1) * -sin(CDbl(TextBox12.Text))) + (mir1.p3(2) * cos(CDbl(TextBox12.Text))) + (1 * 0)

            resp4(0) = (mir1.p4(0) * 1) + (mir1.p4(1) * 0) + (mir1.p4(2) * 0) + (1 * 0)
            resp4(1) = (mir1.p4(0) * 0) + (mir1.p4(1) * cos(CDbl(TextBox12.Text))) + (mir1.p4(2) * sin(CDbl(TextBox12.Text))) + (1 * 0)
            resp4(2) = (mir1.p4(0) * 0) + (mir1.p4(1) * -sin(CDbl(TextBox12.Text))) + (mir1.p4(2) * cos(CDbl(TextBox12.Text))) + (1 * 0)

            mir1.p1(0) = resp1(0)
            mir1.p1(1) = resp1(1)
            mir1.p1(2) = resp1(2)
            mir1.p2(0) = resp2(0)
            mir1.p2(1) = resp2(1)
            mir1.p2(2) = resp2(2)
            mir1.p3(0) = resp3(0)
            mir1.p3(1) = resp3(1)
            mir1.p3(2) = resp3(2)
            mir1.p4(0) = resp4(0)
            mir1.p4(1) = resp4(1)
            mir1.p4(2) = resp4(2)

        ElseIf (CDbl(TextBox13.Text) < 0 Or CDbl(TextBox13.Text) > 0) Then 'Kondisi dibawah ini untuk rotasi mirror di sumbu Y :
            resp1(0) = (mir1.p1(0) * cos(CDbl(TextBox13.Text))) + (mir1.p1(1) * 0) + (mir1.p1(2) * sin(CDbl(TextBox13.Text))) + (1 * 0)
            resp1(1) = (mir1.p1(0) * 0) + (mir1.p1(1) * 1) + (mir1.p1(2) * 0) + (1 * 0)
            resp1(2) = (mir1.p1(0) * -sin(CDbl(TextBox13.Text))) + (mir1.p1(1) * 0) + (mir1.p1(2) * cos(CDbl(TextBox13.Text))) + (1 * 0)

            resp2(0) = (mir1.p2(0) * cos(CDbl(TextBox13.Text))) + (mir1.p2(1) * 0) + (mir1.p2(2) * sin(CDbl(TextBox13.Text))) + (1 * 0)
            resp2(1) = (mir1.p2(0) * 0) + (mir1.p2(1) * 1) + (mir1.p2(2) * 0) + (1 * 0)
            resp2(2) = (mir1.p2(0) * -sin(CDbl(TextBox13.Text))) + (mir1.p2(1) * 0) + (mir1.p2(2) * cos(CDbl(TextBox13.Text))) + (1 * 0)

            resp3(0) = (mir1.p3(0) * cos(CDbl(TextBox13.Text))) + (mir1.p3(1) * 0) + (mir1.p3(2) * sin(CDbl(TextBox13.Text))) + (1 * 0)
            resp3(1) = (mir1.p3(0) * 0) + (mir1.p3(1) * 1) + (mir1.p3(2) * 0) + (1 * 0)
            resp3(2) = (mir1.p3(0) * -sin(CDbl(TextBox13.Text))) + (mir1.p3(1) * 0) + (mir1.p3(2) * cos(CDbl(TextBox13.Text))) + (1 * 0)

            resp4(0) = (mir1.p4(0) * cos(CDbl(TextBox13.Text))) + (mir1.p4(1) * 0) + (mir1.p4(2) * sin(CDbl(TextBox13.Text))) + (1 * 0)
            resp4(1) = (mir1.p4(0) * 0) + (mir1.p4(1) * 1) + (mir1.p4(2) * 0) + (1 * 0)
            resp4(2) = (mir1.p4(0) * -sin(CDbl(TextBox13.Text))) + (mir1.p4(1) * 0) + (mir1.p4(2) * cos(CDbl(TextBox13.Text))) + (1 * 0)
            mir1.p1(0) = resp1(0)
            mir1.p1(1) = resp1(1)
            mir1.p1(2) = resp1(2)
            mir1.p2(0) = resp2(0)
            mir1.p2(1) = resp2(1)
            mir1.p2(2) = resp2(2)
            mir1.p3(0) = resp3(0)
            mir1.p3(1) = resp3(1)
            mir1.p3(2) = resp3(2)
            mir1.p4(0) = resp4(0)
            mir1.p4(1) = resp4(1)
            mir1.p4(2) = resp4(2)

        ElseIf (CDbl(TextBox14.Text) < 0 Or CDbl(TextBox14.Text) > 0) Then 'Kondisi dibawah ini untuk rotasi mirror di sumbu Z :
            resp1(0) = (mir1.p1(0) * cos(CDbl(TextBox14.Text))) + (mir1.p1(1) * sin(CDbl(TextBox14.Text))) + (mir1.p1(2) * 0) + (1 * 0)
            resp1(1) = (mir1.p1(0) * -sin(CDbl(TextBox14.Text))) + (mir1.p1(1) * cos(CDbl(TextBox14.Text))) + (mir1.p1(2) * 0) + (1 * 0)
            resp1(2) = (mir1.p1(0) * 0) + (mir1.p1(1) * 0) + (mir1.p1(2) * 1) + (1 * 0)

            resp2(0) = (mir1.p2(0) * cos(CDbl(TextBox14.Text))) + (mir1.p2(1) * sin(CDbl(TextBox14.Text))) + (mir1.p2(2) * 0) + (1 * 0)
            resp2(1) = (mir1.p2(0) * -sin(CDbl(TextBox14.Text))) + (mir1.p2(1) * cos(CDbl(TextBox14.Text))) + (mir1.p2(2) * 0) + (1 * 0)
            resp2(2) = (mir1.p2(0) * 0) + (mir1.p2(1) * 0) + (mir1.p2(2) * 1) + (1 * 0)

            resp3(0) = (mir1.p3(0) * cos(CDbl(TextBox14.Text))) + (mir1.p3(1) * sin(CDbl(TextBox14.Text))) + (mir1.p3(2) * 0) + (1 * 0)
            resp3(1) = (mir1.p3(0) * -sin(CDbl(TextBox14.Text))) + (mir1.p3(1) * cos(CDbl(TextBox14.Text))) + (mir1.p3(2) * 0) + (1 * 0)
            resp3(2) = (mir1.p3(0) * 0) + (mir1.p3(1) * 0) + (mir1.p3(2) * 1) + (1 * 0)

            resp4(0) = (mir1.p4(0) * cos(CDbl(TextBox14.Text))) + (mir1.p4(1) * sin(CDbl(TextBox14.Text))) + (mir1.p4(2) * 0) + (1 * 0)
            resp4(1) = (mir1.p4(0) * -sin(CDbl(TextBox14.Text))) + (mir1.p4(1) * cos(CDbl(TextBox14.Text))) + (mir1.p4(2) * 0) + (1 * 0)
            resp4(2) = (mir1.p4(0) * 0) + (mir1.p4(1) * 0) + (mir1.p4(2) * 1) + (1 * 0)

            mir1.p1(0) = resp1(0)
            mir1.p1(1) = resp1(1)
            mir1.p1(2) = resp1(2)
            mir1.p2(0) = resp2(0)
            mir1.p2(1) = resp2(1)
            mir1.p2(2) = resp2(2)
            mir1.p3(0) = resp3(0)
            mir1.p3(1) = resp3(1)
            mir1.p3(2) = resp3(2)
            mir1.p4(0) = resp4(0)
            mir1.p4(1) = resp4(1)
            mir1.p4(2) = resp4(2)
        End If

        'scs to wcs
        For i = 0 To 399
            For j = 0 To 399
                Dim x, y As Double
                x = i - 200
                y = j - 200
                rd(0) = x - viewer(0)
                rd(1) = y - viewer(1)
                rd(2) = -viewer(2)
                rd = normalisation(rd)
                td = s(0) * rd(0) + s(1) * rd(1) + s(2) * rd(2)
                d2 = (s(0) * s(0) + s(1) * s(1) + s(2) * s(2)) - (td ^ 2)
                Dim Q(2), D, tplane, Nplane(2) As Double
                Dim Xvector1(2), Xvector2(2) As Double
                Xvector1(0) = mir1.p2(0) - mir1.p3(0)
                Xvector1(1) = mir1.p2(1) - mir1.p3(1)
                Xvector1(2) = mir1.p2(2) - mir1.p3(2)
                Xvector2(0) = mir1.p1(0) - mir1.p2(0)
                Xvector2(1) = mir1.p1(1) - mir1.p2(1)
                Xvector2(2) = mir1.p1(2) - mir1.p2(2)

                Nplane(0) = Xvector1(1) * Xvector2(2) - Xvector1(2) * Xvector2(1)
                Nplane(1) = Xvector1(2) * Xvector2(0) - Xvector1(0) * Xvector2(2)
                Nplane(2) = Xvector1(0) * Xvector2(1) - Xvector1(1) * Xvector2(0)

                D = mir1.p1(0) * Nplane(0) + mir1.p1(1) * Nplane(1) + mir1.p1(2) * Nplane(2)  ' bakal berubah kalau mirror dirotate
                tplane = -(Nplane(0) * viewer(0) + Nplane(1) * viewer(1) + Nplane(2) * viewer(2) + D) / (Nplane(0) * rd(0) + Nplane(1) * rd(1) + Nplane(2) * rd(2))
                Q(0) = viewer(0) + rd(0) * tplane
                Q(1) = viewer(1) + rd(1) * tplane
                Q(2) = viewer(2) + rd(2) * tplane

                'barrycentric (mirror)
                Dim v0(2), v2(2), v1(2) As Double
                v0(0) = mir1.p2(0) - mir1.p1(0)
                v0(1) = mir1.p2(1) - mir1.p1(1)
                v0(2) = mir1.p2(2) - mir1.p1(2)
                v1(0) = mir1.p3(0) - mir1.p1(0)
                v1(1) = mir1.p3(1) - mir1.p1(1)
                v1(2) = mir1.p3(2) - mir1.p1(2)
                v2(0) = Q(0) - mir1.p1(0)
                v2(1) = Q(1) - mir1.p1(1)
                v2(2) = Q(2) - mir1.p1(2)

                Dim C, n1, n2, n3 As Double
                C = (dot(v0, v0) * dot(v1, v1)) - ((dot(v0, v1)) ^ 2)
                n2 = ((dot(v1, v1) * dot(v2, v0)) - (dot(v0, v1) * dot(v2, v1))) / C
                n3 = ((dot(v0, v0) * dot(v2, v1)) - (dot(v0, v1) * dot(v2, v0))) / C
                n1 = 1 - n2 - n3

                If (n1 >= 0 And n1 <= 1) And (n2 >= 0 And n2 <= 1) And (n3 >= 0 And n3 <= 1) Then
                    Dim Rf(2), CS(2), CTd, Cd2, Ref(2) As Double
                    Rf(0) = light(0) - Q(0)
                    Rf(1) = light(1) - Q(1)
                    Rf(2) = light(2) - Q(2)
                    Rf = normalisation(Rf)
                    CS(0) = sap1.center(0) - Q(0)
                    CS(1) = sap1.center(1) - Q(1)
                    CS(2) = sap1.center(2) - Q(2)
                    CTd = Rf(0) * CS(0) + Rf(1) * CS(1) + Rf(2) * CS(2)
                    Cd2 = (CS(0) * CS(0) + CS(1) * CS(1) + CS(2) * CS(2)) - (CTd ^ 2)
                    Dim Lr(2), Nr(2), Vr(2), Rr(2) As Double
                    Lr(0) = light(0) - Q(0)
                    Lr(1) = light(1) - Q(1)
                    Lr(2) = light(2) - Q(2)
                    Lr = normalisation(Lr)
                    Nr(0) = Nplane(0)
                    Nr(1) = Nplane(1)
                    Nr(2) = Nplane(2)
                    Nr = normalisation(Nr)
                    Vr(0) = viewer(0) - Q(0)
                    Vr(1) = viewer(1) - Q(1)
                    Vr(2) = viewer(2) - Q(2)
                    Vr = normalisation(Vr)
                    Rr(0) = (2 * dot(Lr, Nr)) * Nr(0) - Lr(0)
                    Rr(1) = (2 * dot(Lr, Nr)) * Nr(1) - Lr(1)
                    Rr(2) = (2 * dot(Lr, Nr)) * Nr(2) - Lr(2)
                    Rr = normalisation(Rr)
                    Dim ridiff(2) As Double
                    ridiff(0) = (255) * kd * dot(Lr, Nr)
                    ridiff(1) = (255) * kd * dot(Lr, Nr)
                    ridiff(2) = (255) * kd * dot(Lr, Nr)
                    Dim riamb(2) As Double
                    riamb(0) = (255) * ka
                    riamb(1) = (255) * ka
                    riamb(2) = (255) * ka
                    Dim rispec(2) As Double
                    rispec(0) = 255 * ks * (dot(Vr, Rr) ^ kn) '1 adalah n = koefisien spec
                    rispec(1) = 255 * ks * (dot(Vr, Rr) ^ kn)
                    rispec(2) = 255 * ks * (dot(Vr, Rr) ^ kn)
                    Dim ritot(2) As Double
                    ritot(0) = riamb(0) + ridiff(0) + rispec(0)
                    ritot(1) = riamb(1) + ridiff(1) + rispec(1)
                    ritot(2) = riamb(2) + ridiff(2) + rispec(2)
                    Ref(0) = ((2 * (dot(Vr, Nr))) * Nr(0)) - Vr(0)
                    Ref(1) = ((2 * (dot(Vr, Nr))) * Nr(1)) - Vr(1)
                    Ref(2) = ((2 * (dot(Vr, Nr))) * Nr(2)) - Vr(2)
                    Ref = normalisation(Ref)
                    Dim Rd2, Rtd As Double
                    Rtd = Ref(0) * CS(0) + Ref(1) * CS(1) + Ref(2) * CS(2)
                    Rd2 = (CS(0) * CS(0) + CS(1) * CS(1) + CS(2) * CS(2)) - (Rtd ^ 2)

                    If Cd2 > (sap1.r ^ 2) Then
                        If Rd2 < (sap1.r ^ 2) Then
                            Dim P(2) As Double
                            t = Rtd - Math.Sqrt((sap1.r ^ 2) - Rd2)
                            P(0) = Q(0) + Ref(0) * t
                            P(1) = Q(1) + Ref(1) * t
                            P(2) = Q(2) + Ref(2) * t

                            Dim L(2), N(2), V(2), R(2) As Double
                            L(0) = light(0) - P(0)
                            L(1) = light(1) - P(1)
                            L(2) = light(2) - P(2)
                            L = normalisation(L)
                            N(0) = P(0) - sap1.center(0)
                            N(1) = P(1) - sap1.center(1)
                            N(2) = P(2) - sap1.center(2)
                            N = normalisation(N)
                            V(0) = viewer(0) - P(0)
                            V(1) = viewer(1) - P(1)
                            V(2) = viewer(2) - P(2)
                            V = normalisation(V)
                            R(0) = (2 * dot(L, N)) * N(0) - L(0)
                            R(1) = (2 * dot(L, N)) * N(1) - L(1)
                            R(2) = (2 * dot(L, N)) * N(2) - L(2)
                            R = normalisation(R)
                            ritot(0) = riamb(0) + ridiff(0) + rispec(0)
                            ritot(1) = riamb(1) + ridiff(1) + rispec(1)
                            ritot(2) = riamb(2) + ridiff(2) + rispec(2)
                            Dim ridiff2(2) As Double

                            Dim riamb2(2) As Double

                            Dim rispec2(2) As Double

                            Dim ritot2(2) As Double
                            ridiff2(0) = (255) * kd * dot(L, N)
                            ridiff2(1) = (255) * kd * dot(L, N)
                            ridiff2(2) = (255) * kd * dot(L, N)

                            riamb2(0) = (255) * ka
                            riamb2(1) = (0) * ka
                            riamb2(2) = (0) * ka

                            rispec2(0) = (255) * ks * (dot(V, R) ^ kn) '1 adalah n = koefisien spec
                            rispec2(1) = (255) * ks * (dot(V, R) ^ kn)
                            rispec2(2) = (255) * ks * (dot(V, R) ^ kn)

                            ritot2(0) = riamb2(0) + ridiff2(0) + rispec2(0)
                            ritot2(1) = riamb2(1) + ridiff2(1) + rispec2(1)
                            ritot2(2) = riamb2(2) + ridiff2(2) + rispec2(2)
                            ritot(0) += kr * (ritot2(0))
                            ritot(1) += kr * (ritot2(1))
                            ritot(2) += kr * (ritot2(2))
                            For k = 0 To 2
                                If ritot(k) > 255 Then
                                    ritot(k) = 255

                                ElseIf ritot(k) < 0 Then
                                    ritot(k) = 0

                                End If
                            Next
                            paint = Color.FromArgb((ritot(0)), (ritot(1)), (ritot(2)))
                            draw.DrawLine(New Pen(paint), CSng(i), CSng(j), CSng(i) + 1, CSng(j) + 1)
                        Else
                            paint = Color.FromArgb((riamb(0)), (riamb(1)), (riamb(2)))
                            draw.DrawLine(New Pen(paint), CSng(i), CSng(j), CSng(i) + 1, CSng(j) + 1)
                        End If

                    Else
                        For k = 0 To 2
                            If ritot(k) > 255 Then
                                ritot(k) = 255

                            ElseIf ritot(k) < 0 Then
                                ritot(k) = 0

                            End If
                        Next
                        paint = Color.FromArgb((ritot(0)), (ritot(1)), (ritot(2)))
                        draw.DrawLine(New Pen(paint), CSng(i), CSng(j), CSng(i) + 1, CSng(j) + 1)
                    End If
                Else
                    v0(0) = mir1.p4(0) - mir1.p1(0)
                    v0(1) = mir1.p4(1) - mir1.p1(1)
                    v0(2) = mir1.p4(2) - mir1.p1(2)
                    v1(0) = mir1.p3(0) - mir1.p1(0)
                    v1(1) = mir1.p3(1) - mir1.p1(1)
                    v1(2) = mir1.p3(2) - mir1.p1(2)
                    v2(0) = Q(0) - mir1.p1(0)
                    v2(1) = Q(1) - mir1.p1(1)
                    v2(2) = Q(2) - mir1.p1(2)
                    C = (dot(v0, v0) * dot(v1, v1)) - ((dot(v0, v1)) ^ 2)
                    n2 = ((dot(v1, v1) * dot(v2, v0)) - (dot(v0, v1) * dot(v2, v1))) / C
                    n3 = ((dot(v0, v0) * dot(v2, v1)) - (dot(v0, v1) * dot(v2, v0))) / C
                    n1 = 1 - n2 - n3
                    If (n1 >= 0 And n1 <= 1) And (n2 >= 0 And n2 <= 1) And (n3 >= 0 And n3 <= 1) Then
                        Dim Rf(2), CS(2), CTd, Cd2, Ref(2) As Double
                        Rf(0) = light(0) - Q(0)
                        Rf(1) = light(1) - Q(1)
                        Rf(2) = light(2) - Q(2)
                        Rf = normalisation(Rf)
                        CS(0) = sap1.center(0) - Q(0)
                        CS(1) = sap1.center(1) - Q(1)
                        CS(2) = sap1.center(2) - Q(2)
                        CTd = Rf(0) * CS(0) + Rf(1) * CS(1) + Rf(2) * CS(2)
                        Cd2 = (CS(0) * CS(0) + CS(1) * CS(1) + CS(2) * CS(2)) - (CTd ^ 2)

                        Dim Lr(2), Nr(2), Vr(2), Rr(2) As Double
                        Lr(0) = light(0) - Q(0)
                        Lr(1) = light(1) - Q(1)
                        Lr(2) = light(2) - Q(2)
                        Lr = normalisation(Lr)
                        Nr(0) = 0
                        Nr(1) = 1
                        Nr(2) = 0
                        Nr = normalisation(Nr)
                        Vr(0) = viewer(0) - Q(0)
                        Vr(1) = viewer(1) - Q(1)
                        Vr(2) = viewer(2) - Q(2)
                        Vr = normalisation(Vr)
                        Rr(0) = (2 * dot(Lr, Nr)) * Nr(0) - Lr(0)
                        Rr(1) = (2 * dot(Lr, Nr)) * Nr(1) - Lr(1)
                        Rr(2) = (2 * dot(Lr, Nr)) * Nr(2) - Lr(2)
                        Rr = normalisation(Rr)
                        Dim ridiff(2) As Double
                        ridiff(0) = (255) * kd * dot(Lr, Nr)
                        ridiff(1) = (255) * kd * dot(Lr, Nr)
                        ridiff(2) = (255) * kd * dot(Lr, Nr)
                        Dim riamb(2) As Double
                        riamb(0) = (255) * ka
                        riamb(1) = (255) * ka
                        riamb(2) = (255) * ka
                        Dim rispec(2) As Double
                        rispec(0) = 255 * ks * (dot(Vr, Rr) ^ kn) '1 adalah n = koefisien spec
                        rispec(1) = 255 * ks * (dot(Vr, Rr) ^ kn)
                        rispec(2) = 255 * ks * (dot(Vr, Rr) ^ kn)
                        Dim ritot(2) As Double
                        ritot(0) = riamb(0) + ridiff(0) + rispec(0)
                        ritot(1) = riamb(1) + ridiff(1) + rispec(1)
                        ritot(2) = riamb(2) + ridiff(2) + rispec(2)
                        Ref(0) = ((2 * (dot(Vr, Nr))) * Nr(0)) - Vr(0)
                        Ref(1) = ((2 * (dot(Vr, Nr))) * Nr(1)) - Vr(1)
                        Ref(2) = ((2 * (dot(Vr, Nr))) * Nr(2)) - Vr(2)
                        Ref = normalisation(Ref)
                        Dim Rd2, Rtd As Double
                        Rtd = Ref(0) * CS(0) + Ref(1) * CS(1) + Ref(2) * CS(2)
                        Rd2 = (CS(0) * CS(0) + CS(1) * CS(1) + CS(2) * CS(2)) - (Rtd ^ 2)

                        'no shadow and no reflection
                        If Cd2 > (sap1.r ^ 2) Then
                            If Rd2 < (sap1.r ^ 2) Then
                                Dim P(2) As Double
                                t = Rtd - Math.Sqrt((sap1.r ^ 2) - Rd2)
                                P(0) = Q(0) + Ref(0) * t
                                P(1) = Q(1) + Ref(1) * t
                                P(2) = Q(2) + Ref(2) * t

                                Dim L(2), N(2), V(2), R(2) As Double
                                L(0) = light(0) - P(0)
                                L(1) = light(1) - P(1)
                                L(2) = light(2) - P(2)
                                L = normalisation(L)
                                N(0) = P(0) - sap1.center(0)
                                N(1) = P(1) - sap1.center(1)
                                N(2) = P(2) - sap1.center(2)
                                N = normalisation(N)
                                V(0) = viewer(0) - P(0)
                                V(1) = viewer(1) - P(1)
                                V(2) = viewer(2) - P(2)
                                V = normalisation(V)
                                R(0) = (2 * dot(L, N)) * N(0) - L(0)
                                R(1) = (2 * dot(L, N)) * N(1) - L(1)
                                R(2) = (2 * dot(L, N)) * N(2) - L(2)
                                R = normalisation(R)
                                ritot(0) = riamb(0) + ridiff(0) + rispec(0)
                                ritot(1) = riamb(1) + ridiff(1) + rispec(1)
                                ritot(2) = riamb(2) + ridiff(2) + rispec(2)
                                Dim ridiff2(2) As Double

                                Dim riamb2(2) As Double

                                Dim rispec2(2) As Double

                                Dim ritot2(2) As Double
                                ridiff2(0) = (255) * kd * dot(L, N)
                                ridiff2(1) = (255) * kd * dot(L, N)
                                ridiff2(2) = (255) * kd * dot(L, N)

                                riamb2(0) = (255) * ka
                                riamb2(1) = (0) * ka
                                riamb2(2) = (0) * ka

                                rispec2(0) = (255) * ks * (dot(V, R) ^ kn) '1 adalah n = koefisien spec
                                rispec2(1) = (255) * ks * (dot(V, R) ^ kn)
                                rispec2(2) = (255) * ks * (dot(V, R) ^ kn)

                                ritot2(0) = riamb2(0) + ridiff2(0) + rispec2(0)
                                ritot2(1) = riamb2(1) + ridiff2(1) + rispec2(1)
                                ritot2(2) = riamb2(2) + ridiff2(2) + rispec2(2)

                                ritot(0) += kr * (ritot2(0))
                                ritot(1) += kr * (ritot2(1))
                                ritot(2) += kr * (ritot2(2))
                                For k = 0 To 2
                                    If ritot(k) > 255 Then
                                        ritot(k) = 255

                                    ElseIf ritot(k) < 0 Then
                                        ritot(k) = 0

                                    End If
                                Next
                                paint = Color.FromArgb((ritot(0)), (ritot(1)), (ritot(2)))
                                draw.DrawLine(New Pen(paint), CSng(i), CSng(j), CSng(i) + 1, CSng(j) + 1)
                            Else
                                paint = Color.FromArgb((riamb(0)), (riamb(1)), (riamb(2)))
                                draw.DrawLine(New Pen(paint), CSng(i), CSng(j), CSng(i) + 1, CSng(j) + 1)
                            End If
                        Else
                            For k = 0 To 2
                                If ritot(k) > 255 Then
                                    ritot(k) = 255

                                ElseIf ritot(k) < 0 Then
                                    ritot(k) = 0

                                End If
                            Next
                            paint = Color.FromArgb((ritot(0)), (ritot(1)), (ritot(2)))
                            draw.DrawLine(New Pen(paint), CSng(i), CSng(j), CSng(i) + 1, CSng(j) + 1)
                        End If

                    Else

                    End If
                End If

                'sphere
                If d2 <= (sap1.r ^ 2) Then
                    Dim P(2) As Double
                    t = td - Math.Sqrt((sap1.r ^ 2) - d2)
                    P(0) = viewer(0) + rd(0) * t
                    P(1) = viewer(1) + rd(1) * t
                    P(2) = viewer(2) + rd(2) * t

                    Dim L(2), N(2), V(2), R(2) As Double
                    L(0) = light(0) - P(0)
                    L(1) = light(1) - P(1)
                    L(2) = light(2) - P(2)
                    L = normalisation(L)
                    N(0) = P(0) - sap1.center(0)
                    N(1) = P(1) - sap1.center(1)
                    N(2) = P(2) - sap1.center(2)
                    N = normalisation(N)
                    V(0) = viewer(0) - P(0)
                    V(1) = viewer(1) - P(1)
                    V(2) = viewer(2) - P(2)
                    V = normalisation(V)
                    R(0) = (2 * dot(L, N)) * N(0) - L(0)
                    R(1) = (2 * dot(L, N)) * N(1) - L(1)
                    R(2) = (2 * dot(L, N)) * N(2) - L(2)
                    R = normalisation(R)

                    Dim ridiff(2) As Double
                    ridiff(0) = (255) * kd * dot(L, N)
                    ridiff(1) = (255) * kd * dot(L, N)
                    ridiff(2) = (255) * kd * dot(L, N)
                    Dim riamb(2) As Double
                    riamb(0) = (255) * ka
                    riamb(1) = (0) * ka
                    riamb(2) = (0) * ka
                    Dim rispec(2) As Double
                    rispec(0) = (255) * ks * (dot(V, R) ^ kn) '1 adalah n = koefisien spec
                    rispec(1) = (255) * ks * (dot(V, R) ^ kn)
                    rispec(2) = (255) * ks * (dot(V, R) ^ kn)
                    Dim ritot(2) As Double
                    ritot(0) = riamb(0) + ridiff(0) + rispec(0)
                    ritot(1) = riamb(1) + ridiff(1) + rispec(1)
                    ritot(2) = riamb(2) + ridiff(2) + rispec(2)
                    For k = 0 To 2
                        If ritot(k) > 255 Then
                            ritot(k) = 255

                        ElseIf ritot(k) < 0 Then
                            ritot(k) = 0

                        End If
                    Next
                    paint = Color.FromArgb((ritot(0)), (ritot(1)), (ritot(2)))
                    draw.DrawLine(New Pen(paint), CSng(i), CSng(j), CSng(i) + 1, CSng(j) + 1)
                End If
            Next
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DrawGraph()

    End Sub

End Class