--创建S_School表，学校代码表，记录学校类别，包含：is985：985院校；is211:211院校；iszg：中管院校；isbs：部属院校
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
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('001', '中国科学院大学（国科大）', '中国科学院大学（国科大）', '', '1', '0', '0', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('002', '中国科学技术大学', '中国科学技术大学', '', '2', '1', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('003', '北京大学', '北京大学', '', '3', '1', '1', '1', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('004', '中国人民大学', '中国人民大学', '', '4', '1', '1', '1', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('005', '清华大学', '清华大学', '', '5', '1', '1', '1', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('006', '中央音乐学院', '中央音乐学院', '', '6', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('007', '中央戏剧学院', '中央戏剧学院', '', '7', '0', '0', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('008', '中央美术学院', '中央美术学院', '', '8', '0', '0', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('009', '北京林业大学', '北京林业大学', '', '9', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('010', '北京交通大学', '北京交通大学', '', '10', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('011', '北京外国语大学', '北京外国语大学', '', '11', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('012', '中国政法大学', '中国政法大学', '', '12', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('013', '中国传媒大学', '中国传媒大学', '', '13', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('014', '北京中医药大学', '北京中医药大学', '', '14', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('015', '北京语言大学', '北京语言大学', '', '15', '0', '0', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('016', '北京师范大学', '北京师范大学', '', '16', '1', '1', '1', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('017', '对外经济贸易大学', '对外经济贸易大学', '', '17', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('018', '北京化工大学', '北京化工大学', '', '18', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('019', '北京邮电大学', '北京邮电大学', '', '19', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('020', '中国地质大学（北京）', '中国地质大学（北京）', '', '20', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('021', '华北电力大学', '华北电力大学', '', '21', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('022', '中央财经大学', '中央财经大学', '', '22', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('023', '中国矿业大学（北京）', '中国矿业大学（北京）', '', '23', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('024', '中国农业大学', '中国农业大学', '', '24', '1', '1', '1', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('025', '北京科技大学', '北京科技大学', '', '25', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('026', '中国石油大学（北京）', '中国石油大学（北京）', '', '26', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('027', '国际关系学院（教育部管理）', '国际关系学院（教育部管理）', '', '27', '0', '0', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('028', '南开大学', '南开大学', '', '28', '1', '1', '1', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('029', '天津大学', '天津大学', '', '29', '1', '1', '1', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('030', '复旦大学', '复旦大学', '', '30', '1', '1', '1', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('031', '上海交通大学', '上海交通大学', '', '31', '1', '1', '1', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('032', '同济大学', '同济大学', '', '32', '1', '1', '1', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('033', '上海财经大学', '上海财经大学', '', '33', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('034', '华东理工大学', '华东理工大学', '', '34', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('035', '东华大学', '东华大学', '', '35', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('036', '上海外国语大学', '上海外国语大学', '', '36', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('037', '华东师范大学', '华东师范大学', '', '37', '1', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('038', '南京农业大学', '南京农业大学', '', '38', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('039', '中国矿业大学', '中国矿业大学', '', '39', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('040', '东南大学', '东南大学', '', '40', '1', '1', '1', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('041', '河海大学', '河海大学', '', '41', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('042', '中国药科大学', '中国药科大学', '', '42', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('043', '江南大学', '江南大学', '', '43', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('044', '南京大学', '南京大学', '', '44', '1', '1', '1', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('045', '武汉大学', '武汉大学', '', '45', '1', '1', '1', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('046', '华中师范大学', '华中师范大学', '', '46', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('047', '华中农业大学', '华中农业大学', '', '47', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('048', '中南财经政法大学', '中南财经政法大学', '', '48', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('049', '武汉理工大学', '武汉理工大学', '', '49', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('050', '华中科技大学', '华中科技大学', '', '50', '1', '1', '1', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('051', '中国地质大学（武汉）', '中国地质大学（武汉）', '', '51', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('052', '长安大学', '长安大学', '', '52', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('053', '西安交通大学', '西安交通大学', '', '53', '1', '1', '1', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('054', '西北农林科技大学', '西北农林科技大学', '', '54', '1', '1', '1', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('055', '陕西师范大学', '陕西师范大学', '', '55', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('056', '西安电子科技大学', '西安电子科技大学', '', '56', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('057', '四川大学', '四川大学', '', '57', '1', '1', '1', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('058', '西南交通大学', '西南交通大学', '', '58', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('059', '电子科技大学', '电子科技大学', '', '59', '1', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('060', '西南财经大学', '西南财经大学', '', '60', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('061', '山东大学', '山东大学', '', '61', '1', '1', '1', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('062', '中国海洋大学', '中国海洋大学', '', '62', '1', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('063', '中国石油大学（华东）', '中国石油大学（华东）', '', '63', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('064', '吉林大学', '吉林大学', '', '64', '1', '1', '1', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('065', '东北师范大学', '东北师范大学', '', '65', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('066', '中山大学', '中山大学', '', '66', '1', '1', '1', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('067', '华南理工大学', '华南理工大学', '', '67', '1', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('068', '东北大学', '东北大学', '', '68', '1', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('069', '大连理工大学', '大连理工大学', '', '69', '1', '1', '1', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('070', '中南大学', '中南大学 ', '', '70', '1', '1', '1', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('071', '湖南大学', '湖南大学', '', '71', '1', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('072', '重庆大学', '重庆大学', '', '72', '1', '1', '1', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('073', '西南大学', '西南大学', '', '73', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('074', '东北林业大学', '东北林业大学', '', '74', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('075', '合肥工业大学', '合肥工业大学', '', '75', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('076', '浙江大学', '浙江大学', '', '76', '1', '1', '1', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('077', '兰州大学', '兰州大学', '', '77', '1', '1', '1', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('078', '厦门大学', '厦门大学', '', '78', '1', '1', '1', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('079', '华侨大学', '华侨大学', '', '79', '0', '0', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('080', '暨南大学', '暨南大学', '', '80', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('081', '北京理工大学', '北京理工大学', '', '81', '1', '1', '1', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('082', '北京航空航天大学', '北京航空航天大学', '', '82', '1', '1', '1', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('083', '南京理工大学', '南京理工大学', '', '83', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('084', '南京航空航天大学', '南京航空航天大学', '', '84', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('085', '哈尔滨工业大学', '哈尔滨工业大学', '', '85', '1', '1', '1', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('086', '哈尔滨工程大学', '哈尔滨工程大学', '', '86', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('087', '西北工业大学', '西北工业大学', '', '87', '1', '1', '1', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('088', '国防大学', '国防大学', '', '88', '0', '0', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('089', '国防科学技术大学', '国防科学技术大学', '', '89', '1', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('090', '中央民族大学', '中央民族大学', '', '90', '1', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('091', '中南民族大学', '中南民族大学', '', '91', '0', '0', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('092', '西南民族大学', '西南民族大学', '', '92', '0', '0', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('093', '西北民族大学', '西北民族大学', '', '93', '0', '0', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('094', '北方民族大学', '北方民族大学', '', '94', '0', '0', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('095', '大连民族学院', '大连民族学院', '', '95', '0', '0', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('096', '中国人民公安大学', '中国人民公安大学', '', '96', '0', '0', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('097', '中国刑事警察学院', '中国刑事警察学院', '', '97', '0', '0', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('098', '中国人民武装警察部队学院（现役）', '中国人民武装警察部队学院（现役）', '', '98', '0', '0', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('099', '铁道警察学院', '铁道警察学院', '', '99', '0', '0', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('100', '公安海警学院（现役）', '公安海警学院（现役）', '', '100', '0', '0', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('101', '大连海事大学', '大连海事大学', '', '101', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('102', '中国青年政治学院', '中国青年政治学院', '', '102', '0', '0', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('103', '外交学院', '外交学院', '', '103', '0', '0', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('104', '中央司法警官学院', '中央司法警官学院', '', '104', '0', '0', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('105', '北京协和医学院', '北京协和医学院', '', '105', '0', '0', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('106', '北京体育大学', '北京体育大学', '', '106', '0', '1', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('107', '北京电子科技学院', '北京电子科技学院', '', '107', '0', '0', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('108', '中国劳动关系学院', '中国劳动关系学院', '', '108', '0', '0', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('109', '中华女子学院', '中华女子学院', '', '109', '0', '0', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('110', '中国民航大学', '中国民航大学', '', '110', '0', '0', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('111', '中国民用航空飞行学院', '中国民用航空飞行学院', '', '111', '0', '0', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('112', '广州民航职业技术学院', '广州民航职业技术学院', '', '112', '0', '0', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('113', '华北科技学院', '华北科技学院', '', '113', '0', '0', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('114', '防灾科技学院', '防灾科技学院', '', '114', '0', '0', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('115', '上海海关学院', '上海海关学院', '', '115', '0', '0', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('116', '南京森林警察学院', '南京森林警察学院', '', '116', '0', '0', '0', '1', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('212', '中国科技大学', '中国科技大学', '', '212', '0', '0', '1', '0', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('301', '天津医科大学', '天津医科大学', '', '301', '0', '1', '0', '0', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('302', '苏州大学', '苏州大学', '', '302', '0', '1', '0', '0', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('303', '河北工业大学', '河北工业大学', '', '303', '0', '1', '0', '0', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('304', '北京工业大学', '北京工业大学', '', '304', '0', '1', '0', '0', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('305', '上海大学', '上海大学', '', '305', '0', '1', '0', '0', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('306', '南京师范大学', '南京师范大学', '', '306', '0', '1', '0', '0', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('307', '西北大学', '西北大学', '', '307', '0', '1', '0', '0', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('308', '广西大学', '广西大学', '', '308', '0', '1', '0', '0', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('309', '湖南师范大学', '湖南师范大学', '', '309', '0', '1', '0', '0', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('310', '福州大学', '福州大学', '', '310', '0', '1', '0', '0', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('311', '云南大学', '云南大学', '', '311', '0', '1', '0', '0', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('312', '太原理工大学', '太原理工大学', '', '312', '0', '1', '0', '0', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('313', '华南师范大学', '华南师范大学', '', '313', '0', '1', '0', '0', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('314', '安徽大学', '安徽大学', '', '314', '0', '1', '0', '0', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('315', '东北农业大学', '东北农业大学', '', '315', '0', '1', '0', '0', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('316', '辽宁大学', '辽宁大学', '', '316', '0', '1', '0', '0', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('317', '南昌大学', '南昌大学', '', '317', '0', '1', '0', '0', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('318', '延边大学', '延边大学', '', '318', '0', '1', '0', '0', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('319', '内蒙古大学', '内蒙古大学', '', '319', '0', '1', '0', '0', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('320', '四川农业大学', '四川农业大学', '', '320', '0', '1', '0', '0', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('321', '海南大学', '海南大学', '', '321', '0', '1', '0', '0', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('322', '贵州大学', '贵州大学', '', '322', '0', '1', '0', '0', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('323', '郑州大学', '郑州大学', '', '323', '0', '1', '0', '0', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('324', '新疆大学', '新疆大学', '', '324', '0', '1', '0', '0', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('325', '宁夏大学', '宁夏大学', '', '325', '0', '1', '0', '0', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('326', '石河子大学', '石河子大学', '', '326', '0', '1', '0', '0', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('327', '青海大学', '青海大学', '', '327', '0', '1', '0', '0', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('328', '第二军医大学', '第二军医大学', '', '328', '0', '1', '0', '0', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('329', '第四军医大学', '第四军医大学', '', '329', '0', '1', '0', '0', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('330', '华北电力大学（保定）', '华北电力大学（保定）', '', '330', '0', '1', '0', '0', '0');
INSERT INTO S_School (dmcod, dmcpt, dmabr1, dmhnd, inpfrq, IS985, IS211, ISZG, ISBS, ISForeign) VALUES ('331', '西藏大学', '西藏大学', '', '331', '0', '1', '0', '0', '0');
