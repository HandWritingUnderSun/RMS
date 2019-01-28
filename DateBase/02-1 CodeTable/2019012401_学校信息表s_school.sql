--����S_School��ѧУ�������¼ѧУ��𣬰�����is985��985ԺУ��is211:211ԺУ��iszg���й�ԺУ��isbs������ԺУ
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[S_School]') AND type in (N'U'))
DROP TABLE [dbo].[S_School]
GO
CREATE TABLE S_School (
  dmcod varchar(50) NOT NULL,
  dmcpt varchar(500) NOT NULL,
  dmabr1 varchar(200) DEFAULT NULL,
  dmhnd varchar(50) DEFAULT NULL,
  inpfrq varchar(50) DEFAULT NULL,
  IS985 TINYINT NOT NULL,
  IS211 TINYINT NOT NULL,
  ISZG TINYINT NOT NULL,
  ISBS TINYINT NOT NULL,
  ISForeign TINYINT NOT NULL
  PRIMARY KEY (dmcod)
) 
GO 


DELETE FROM S_School
GO
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('001', '�й���ѧԺ��ѧ�����ƴ�', '�й���ѧԺ��ѧ�����ƴ�', '', '1', '0', '0', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('002', '�й���ѧ������ѧ', '�й���ѧ������ѧ', '', '2', '1', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('003', '������ѧ', '������ѧ', '', '3', '1', '1', '1', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('004', '�й������ѧ', '�й������ѧ', '', '4', '1', '1', '1', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('005', '�廪��ѧ', '�廪��ѧ', '', '5', '1', '1', '1', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('006', '��������ѧԺ', '��������ѧԺ', '', '6', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('007', '����Ϸ��ѧԺ', '����Ϸ��ѧԺ', '', '7', '0', '0', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('008', '��������ѧԺ', '��������ѧԺ', '', '8', '0', '0', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('009', '������ҵ��ѧ', '������ҵ��ѧ', '', '9', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('010', '������ͨ��ѧ', '������ͨ��ѧ', '', '10', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('011', '����������ѧ', '����������ѧ', '', '11', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('012', '�й�������ѧ', '�й�������ѧ', '', '12', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('013', '�й���ý��ѧ', '�й���ý��ѧ', '', '13', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('014', '������ҽҩ��ѧ', '������ҽҩ��ѧ', '', '14', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('015', '�������Դ�ѧ', '�������Դ�ѧ', '', '15', '0', '0', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('016', '����ʦ����ѧ', '����ʦ����ѧ', '', '16', '1', '1', '1', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('017', '���⾭��ó�״�ѧ', '���⾭��ó�״�ѧ', '', '17', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('018', '����������ѧ', '����������ѧ', '', '18', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('019', '�����ʵ��ѧ', '�����ʵ��ѧ', '', '19', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('020', '�й����ʴ�ѧ��������', '�й����ʴ�ѧ��������', '', '20', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('021', '����������ѧ', '����������ѧ', '', '21', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('022', '����ƾ���ѧ', '����ƾ���ѧ', '', '22', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('023', '�й���ҵ��ѧ��������', '�й���ҵ��ѧ��������', '', '23', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('024', '�й�ũҵ��ѧ', '�й�ũҵ��ѧ', '', '24', '1', '1', '1', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('025', '�����Ƽ���ѧ', '�����Ƽ���ѧ', '', '25', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('026', '�й�ʯ�ʹ�ѧ��������', '�й�ʯ�ʹ�ѧ��������', '', '26', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('027', '���ʹ�ϵѧԺ������������', '���ʹ�ϵѧԺ������������', '', '27', '0', '0', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('028', '�Ͽ���ѧ', '�Ͽ���ѧ', '', '28', '1', '1', '1', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('029', '����ѧ', '����ѧ', '', '29', '1', '1', '1', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('030', '������ѧ', '������ѧ', '', '30', '1', '1', '1', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('031', '�Ϻ���ͨ��ѧ', '�Ϻ���ͨ��ѧ', '', '31', '1', '1', '1', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('032', 'ͬ�ô�ѧ', 'ͬ�ô�ѧ', '', '32', '1', '1', '1', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('033', '�Ϻ��ƾ���ѧ', '�Ϻ��ƾ���ѧ', '', '33', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('034', '��������ѧ', '��������ѧ', '', '34', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('035', '������ѧ', '������ѧ', '', '35', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('036', '�Ϻ�������ѧ', '�Ϻ�������ѧ', '', '36', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('037', '����ʦ����ѧ', '����ʦ����ѧ', '', '37', '1', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('038', '�Ͼ�ũҵ��ѧ', '�Ͼ�ũҵ��ѧ', '', '38', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('039', '�й���ҵ��ѧ', '�й���ҵ��ѧ', '', '39', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('040', '���ϴ�ѧ', '���ϴ�ѧ', '', '40', '1', '1', '1', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('041', '�Ӻ���ѧ', '�Ӻ���ѧ', '', '41', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('042', '�й�ҩ�ƴ�ѧ', '�й�ҩ�ƴ�ѧ', '', '42', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('043', '���ϴ�ѧ', '���ϴ�ѧ', '', '43', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('044', '�Ͼ���ѧ', '�Ͼ���ѧ', '', '44', '1', '1', '1', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('045', '�人��ѧ', '�人��ѧ', '', '45', '1', '1', '1', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('046', '����ʦ����ѧ', '����ʦ����ѧ', '', '46', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('047', '����ũҵ��ѧ', '����ũҵ��ѧ', '', '47', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('048', '���ϲƾ�������ѧ', '���ϲƾ�������ѧ', '', '48', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('049', '�人����ѧ', '�人����ѧ', '', '49', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('050', '���пƼ���ѧ', '���пƼ���ѧ', '', '50', '1', '1', '1', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('051', '�й����ʴ�ѧ���人��', '�й����ʴ�ѧ���人��', '', '51', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('052', '������ѧ', '������ѧ', '', '52', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('053', '������ͨ��ѧ', '������ͨ��ѧ', '', '53', '1', '1', '1', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('054', '����ũ�ֿƼ���ѧ', '����ũ�ֿƼ���ѧ', '', '54', '1', '1', '1', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('055', '����ʦ����ѧ', '����ʦ����ѧ', '', '55', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('056', '�������ӿƼ���ѧ', '�������ӿƼ���ѧ', '', '56', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('057', '�Ĵ���ѧ', '�Ĵ���ѧ', '', '57', '1', '1', '1', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('058', '���Ͻ�ͨ��ѧ', '���Ͻ�ͨ��ѧ', '', '58', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('059', '���ӿƼ���ѧ', '���ӿƼ���ѧ', '', '59', '1', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('060', '���ϲƾ���ѧ', '���ϲƾ���ѧ', '', '60', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('061', 'ɽ����ѧ', 'ɽ����ѧ', '', '61', '1', '1', '1', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('062', '�й������ѧ', '�й������ѧ', '', '62', '1', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('063', '�й�ʯ�ʹ�ѧ��������', '�й�ʯ�ʹ�ѧ��������', '', '63', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('064', '���ִ�ѧ', '���ִ�ѧ', '', '64', '1', '1', '1', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('065', '����ʦ����ѧ', '����ʦ����ѧ', '', '65', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('066', '��ɽ��ѧ', '��ɽ��ѧ', '', '66', '1', '1', '1', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('067', '��������ѧ', '��������ѧ', '', '67', '1', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('068', '������ѧ', '������ѧ', '', '68', '1', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('069', '��������ѧ', '��������ѧ', '', '69', '1', '1', '1', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('070', '���ϴ�ѧ', '���ϴ�ѧ ', '', '70', '1', '1', '1', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('071', '���ϴ�ѧ', '���ϴ�ѧ', '', '71', '1', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('072', '�����ѧ', '�����ѧ', '', '72', '1', '1', '1', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('073', '���ϴ�ѧ', '���ϴ�ѧ', '', '73', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('074', '������ҵ��ѧ', '������ҵ��ѧ', '', '74', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('075', '�Ϸʹ�ҵ��ѧ', '�Ϸʹ�ҵ��ѧ', '', '75', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('076', '�㽭��ѧ', '�㽭��ѧ', '', '76', '1', '1', '1', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('077', '���ݴ�ѧ', '���ݴ�ѧ', '', '77', '1', '1', '1', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('078', '���Ŵ�ѧ', '���Ŵ�ѧ', '', '78', '1', '1', '1', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('079', '���ȴ�ѧ', '���ȴ�ѧ', '', '79', '0', '0', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('080', '���ϴ�ѧ', '���ϴ�ѧ', '', '80', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('081', '��������ѧ', '��������ѧ', '', '81', '1', '1', '1', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('082', '�������պ����ѧ', '�������պ����ѧ', '', '82', '1', '1', '1', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('083', '�Ͼ�����ѧ', '�Ͼ�����ѧ', '', '83', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('084', '�Ͼ����պ����ѧ', '�Ͼ����պ����ѧ', '', '84', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('085', '��������ҵ��ѧ', '��������ҵ��ѧ', '', '85', '1', '1', '1', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('086', '���������̴�ѧ', '���������̴�ѧ', '', '86', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('087', '������ҵ��ѧ', '������ҵ��ѧ', '', '87', '1', '1', '1', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('088', '������ѧ', '������ѧ', '', '88', '0', '0', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('089', '������ѧ������ѧ', '������ѧ������ѧ', '', '89', '1', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('090', '���������ѧ', '���������ѧ', '', '90', '1', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('091', '���������ѧ', '���������ѧ', '', '91', '0', '0', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('092', '���������ѧ', '���������ѧ', '', '92', '0', '0', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('093', '���������ѧ', '���������ѧ', '', '93', '0', '0', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('094', '���������ѧ', '���������ѧ', '', '94', '0', '0', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('095', '��������ѧԺ', '��������ѧԺ', '', '95', '0', '0', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('096', '�й����񹫰���ѧ', '�й����񹫰���ѧ', '', '96', '0', '0', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('097', '�й����¾���ѧԺ', '�й����¾���ѧԺ', '', '97', '0', '0', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('098', '�й�������װ���첿��ѧԺ�����ۣ�', '�й�������װ���첿��ѧԺ�����ۣ�', '', '98', '0', '0', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('099', '��������ѧԺ', '��������ѧԺ', '', '99', '0', '0', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('100', '��������ѧԺ�����ۣ�', '��������ѧԺ�����ۣ�', '', '100', '0', '0', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('101', '�������´�ѧ', '�������´�ѧ', '', '101', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('102', '�й���������ѧԺ', '�й���������ѧԺ', '', '102', '0', '0', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('103', '�⽻ѧԺ', '�⽻ѧԺ', '', '103', '0', '0', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('104', '����˾������ѧԺ', '����˾������ѧԺ', '', '104', '0', '0', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('105', '����Э��ҽѧԺ', '����Э��ҽѧԺ', '', '105', '0', '0', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('106', '����������ѧ', '����������ѧ', '', '106', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('107', '�������ӿƼ�ѧԺ', '�������ӿƼ�ѧԺ', '', '107', '0', '0', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('108', '�й��Ͷ���ϵѧԺ', '�й��Ͷ���ϵѧԺ', '', '108', '0', '0', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('109', '�л�Ů��ѧԺ', '�л�Ů��ѧԺ', '', '109', '0', '0', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('110', '�й��񺽴�ѧ', '�й��񺽴�ѧ', '', '110', '0', '0', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('111', '�й����ú��շ���ѧԺ', '�й����ú��շ���ѧԺ', '', '111', '0', '0', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('112', '������ְҵ����ѧԺ', '������ְҵ����ѧԺ', '', '112', '0', '0', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('113', '�����Ƽ�ѧԺ', '�����Ƽ�ѧԺ', '', '113', '0', '0', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('114', '���ֿƼ�ѧԺ', '���ֿƼ�ѧԺ', '', '114', '0', '0', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('115', '�Ϻ�����ѧԺ', '�Ϻ�����ѧԺ', '', '115', '0', '0', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('116', '�Ͼ�ɭ�־���ѧԺ', '�Ͼ�ɭ�־���ѧԺ', '', '116', '0', '0', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('212', '�й��Ƽ���ѧ', '�й��Ƽ���ѧ', '', '212', '0', '0', '1', '0', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('301', '���ҽ�ƴ�ѧ', '���ҽ�ƴ�ѧ', '', '301', '0', '1', '0', '0', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('302', '���ݴ�ѧ', '���ݴ�ѧ', '', '302', '0', '1', '0', '0', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('303', '�ӱ���ҵ��ѧ', '�ӱ���ҵ��ѧ', '', '303', '0', '1', '0', '0', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('304', '������ҵ��ѧ', '������ҵ��ѧ', '', '304', '0', '1', '0', '0', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('305', '�Ϻ���ѧ', '�Ϻ���ѧ', '', '305', '0', '1', '0', '0', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('306', '�Ͼ�ʦ����ѧ', '�Ͼ�ʦ����ѧ', '', '306', '0', '1', '0', '0', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('307', '������ѧ', '������ѧ', '', '307', '0', '1', '0', '0', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('308', '������ѧ', '������ѧ', '', '308', '0', '1', '0', '0', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('309', '����ʦ����ѧ', '����ʦ����ѧ', '', '309', '0', '1', '0', '0', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('310', '���ݴ�ѧ', '���ݴ�ѧ', '', '310', '0', '1', '0', '0', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('311', '���ϴ�ѧ', '���ϴ�ѧ', '', '311', '0', '1', '0', '0', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('312', '̫ԭ����ѧ', '̫ԭ����ѧ', '', '312', '0', '1', '0', '0', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('313', '����ʦ����ѧ', '����ʦ����ѧ', '', '313', '0', '1', '0', '0', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('314', '���մ�ѧ', '���մ�ѧ', '', '314', '0', '1', '0', '0', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('315', '����ũҵ��ѧ', '����ũҵ��ѧ', '', '315', '0', '1', '0', '0', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('316', '������ѧ', '������ѧ', '', '316', '0', '1', '0', '0', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('317', '�ϲ���ѧ', '�ϲ���ѧ', '', '317', '0', '1', '0', '0', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('318', '�ӱߴ�ѧ', '�ӱߴ�ѧ', '', '318', '0', '1', '0', '0', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('319', '���ɹŴ�ѧ', '���ɹŴ�ѧ', '', '319', '0', '1', '0', '0', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('320', '�Ĵ�ũҵ��ѧ', '�Ĵ�ũҵ��ѧ', '', '320', '0', '1', '0', '0', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('321', '���ϴ�ѧ', '���ϴ�ѧ', '', '321', '0', '1', '0', '0', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('322', '���ݴ�ѧ', '���ݴ�ѧ', '', '322', '0', '1', '0', '0', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('323', '֣�ݴ�ѧ', '֣�ݴ�ѧ', '', '323', '0', '1', '0', '0', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('324', '�½���ѧ', '�½���ѧ', '', '324', '0', '1', '0', '0', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('325', '���Ĵ�ѧ', '���Ĵ�ѧ', '', '325', '0', '1', '0', '0', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('326', 'ʯ���Ӵ�ѧ', 'ʯ���Ӵ�ѧ', '', '326', '0', '1', '0', '0', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('327', '�ຣ��ѧ', '�ຣ��ѧ', '', '327', '0', '1', '0', '0', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('328', '�ڶ���ҽ��ѧ', '�ڶ���ҽ��ѧ', '', '328', '0', '1', '0', '0', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('329', '���ľ�ҽ��ѧ', '���ľ�ҽ��ѧ', '', '329', '0', '1', '0', '0', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('330', '����������ѧ��������', '����������ѧ��������', '', '330', '0', '1', '0', '0', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('331', '���ش�ѧ', '���ش�ѧ', '', '331', '0', '1', '0', '0', '0');
