//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Target.Application.DTOs;
//using Target.Application.Interfaces.Common;

//namespace Target.Application.Interfaces.Services
//{
//    public class CustomeMapper : ICustomMapper
//    {
//        private const string ar = "ar-YE";
//        private const string nothing = "";




//        //======= Adding for sitex conference ======================= 13/11/2022 =====================================


//        //====== AxlesDto ====================
//        public AxlesViewDto DtoToView(AxlesDto dto, string lang = "ar-YE")
//        {
//            var axlex= new AxlesViewDto
//            {
//                Id = dto.Id,               
//                Image = dto.Image,
//            };
//            if(lang == ar)
//            {
//                axlex.Name = dto.ArName ?? dto.EnName ?? nothing;
//                axlex.Descrption = dto.ArDescrption ?? dto.EnDescrption ?? nothing;
//            }
//            else
//            {
//                axlex.Name = dto.EnName ?? dto.ArName ?? nothing;
//                axlex.Descrption = dto.EnDescrption ?? dto.ArDescrption ?? nothing;
//            }
           
//            return axlex;
//        }
//        public IEnumerable<AxlesViewDto> DtoToView(IEnumerable<AxlesDto> dtoList, string lang = "ar-YE")
//        {
//            IEnumerable<AxlesViewDto> axlesViewDtos = new List<AxlesViewDto>();
//            foreach (AxlesDto dto in dtoList)
//            {
//                axlesViewDtos = axlesViewDtos.Append(DtoToView(dto, lang));
//            }
//            return axlesViewDtos;
//        }


//        //====== ExhDataDto ====================
//        public ExhDataViewDto DtoToView(ExhDataDto dto, string lang = "ar-YE")
//        {
//            var exhDataView = new ExhDataViewDto
//            {
//                Id = dto.Id,
//                HeaderImage = dto.HeaderImage,
//                EndDate = dto.EndDate,
//                StartDate = dto.StartDate,
//                Logo = dto.Logo,

//            };
//            if(lang == ar)
//            {
//                exhDataView.Name = dto.ArName ?? dto.EnName ?? nothing;
//                exhDataView.Location = dto.ArLocation ?? dto.EnLocation ?? nothing; 
//                exhDataView.Introduction = dto.ArIntroduction ?? dto.EnIntroduction ?? nothing;
//                exhDataView.SubTitle = dto.ArSubTitle ?? dto.EnSubTitle ?? nothing;
//            }
//            else
//            {
//                exhDataView.Name = dto.EnName ?? dto.ArName ?? nothing;
//                exhDataView.Location = dto.EnLocation ?? dto.ArLocation ?? nothing;
//                exhDataView.Introduction = dto.EnIntroduction ?? dto.ArIntroduction ?? nothing;
//                exhDataView.SubTitle = dto.EnSubTitle ?? dto.ArSubTitle ?? nothing;
//            }

//            return exhDataView;
//        }
//        public IEnumerable<ExhDataViewDto> DtoToView(IEnumerable<ExhDataDto> dtoList, string lang = "ar-YE")
//        {
//            IEnumerable<ExhDataViewDto> exhDataViewDtos = new List<ExhDataViewDto>();
//            foreach (ExhDataDto dto in dtoList)
//            {
//                exhDataViewDtos = exhDataViewDtos.Append(DtoToView(dto, lang));
//            }

//            return exhDataViewDtos;
//        }


//        //====== ConferenceDto ====================
//        public ConferenceViewDto DtoToView(ConferenceDto dto, string lang = "ar-YE")
//        {
//            var conferenceView = new ConferenceViewDto
//            {
//                Id = dto.Id,
//                EndDate = dto.EndDate,
//                StartDate = dto.StartDate,
//                Logo = dto.Logo,
                
                
//            };
//            if (lang == ar)
//            {
//                conferenceView.Name = dto.ArName ?? dto.EnName ?? nothing;
//                conferenceView.Location = dto.ArLocation ?? dto.EnLocation ?? nothing;
//                conferenceView.Introduction = dto.ArIntroduction ?? dto.EnIntroduction ?? nothing;
//                conferenceView.SubTitle = dto.ArSubTitle ?? dto.EnSubTitle ?? nothing;
//            }
//            else
//            {
//                conferenceView.Name = dto.EnName ?? dto.ArName ?? nothing;
//                conferenceView.Location = dto.EnLocation ?? dto.ArLocation ?? nothing;
//                conferenceView.Introduction = dto.EnIntroduction ?? dto.ArIntroduction ?? nothing;
//                conferenceView.SubTitle = dto.EnSubTitle ?? dto.ArSubTitle ?? nothing;
//            }

//            return conferenceView;
//        }
//        public IEnumerable<ConferenceViewDto> DtoToView(IEnumerable<ConferenceDto> dtoList, string lang = "ar-YE")
//        {
//            IEnumerable<ConferenceViewDto> conferenceViewDtos = new List<ConferenceViewDto>();
//            foreach (ConferenceDto dto in dtoList)
//            {
//                conferenceViewDtos = conferenceViewDtos.Append(DtoToView(dto,lang));
//            }
//            return conferenceViewDtos;
//        }

//        //====== RequestDto ====================
//        public RequestViewDto DtoToView(RequestDto dto, string lang = "ar-YE")
//        {
//            return new RequestViewDto
//            {
//                Company = dto.Company,
//                Email = dto.Email,
//                Id = dto.Id,
//                Name = dto.Name,
//                Others = dto.Others,
//                Phone = dto.Phone,
//                Reason = dto.Reason,
//            };
//        }
//        public IEnumerable<RequestViewDto> DtoToView(IEnumerable<RequestDto> dtoList, string lang = "ar-YE")
//        {
//            IEnumerable<RequestViewDto> requestViewDtos = new List<RequestViewDto>();
//            foreach(RequestDto dto in dtoList)
//            {
//                requestViewDtos = requestViewDtos.Append(DtoToView(dto, lang));
//            }
//            return requestViewDtos;
//        }

//        //====== WorksheetsDto ====================
//        public WorksheetsViewDto DtoToView(WorksheetsDto dto, string lang = "ar-YE")
//        {
//            return new WorksheetsViewDto
//            {
//                Name = dto.Name,
//                Id = dto.Id,
//                AboutAuthor = dto.AboutAuthor,
//                AuthorImage = dto.AuthorImage,
//                AuthorName = dto.AuthorName,
//                AutorJobTitle = dto.AutorJobTitle,
//                VideoLink = dto.VideoLink,
//                Other = dto.Other,
//                Url = dto.Url,                
//            };
//        }
//        public IEnumerable<WorksheetsViewDto> DtoToView(IEnumerable<WorksheetsDto> dtoList, string lang = "ar-YE")
//        {
//            IEnumerable<WorksheetsViewDto> worksheetsViewDtos = new List<WorksheetsViewDto>();
//            foreach(WorksheetsDto dto in dtoList)
//            {
//                worksheetsViewDtos = worksheetsViewDtos.Append(DtoToView(dto,lang));
//            }
//            return worksheetsViewDtos;
//        }


//        //====== SponsorTypeFeaturesDto ====================
//        public SponsorTypeFeaturesViewDto DtoToView(SponsorTypeFeaturesDto dto, string lang = "ar-YE")
//        {
//            var typeFeatures = new SponsorTypeFeaturesViewDto
//            {
//                ExhibitionId = dto.ExhibitionId,
//                Id = dto.Id,
//                Image = dto.Image,
//                SponsorTypeId = dto.SponsorTypeId,
//            };

//            if(lang == ar)
//            {
//                typeFeatures.Content = dto.ArContent ?? dto.EnContent ?? nothing;
//            }
//            else
//            {
//                typeFeatures.Content = dto.EnContent ?? dto.ArContent ?? nothing;
//            }

//            return typeFeatures;
//        }
//        public IEnumerable<SponsorTypeFeaturesViewDto> DtoToView(IEnumerable<SponsorTypeFeaturesDto> dtoList, string lang = "ar-YE")
//        {
//            IEnumerable<SponsorTypeFeaturesViewDto> sponsorTypeFeaturesViewDtos = new List<SponsorTypeFeaturesViewDto>();
//            foreach(SponsorTypeFeaturesDto dto in dtoList)
//            {
//                sponsorTypeFeaturesViewDtos = sponsorTypeFeaturesViewDtos.Append(DtoToView(dto,lang));
//            }

//            return sponsorTypeFeaturesViewDtos;
//        }

//        //----------------------------------------------------------------------------------------------------------------


//        //====================  AdsViewDto  ====================================
//        public AdsViewDto DtoToView(AdsDto dto, string lang = ar)
//        {
//            return new AdsViewDto
//            {
//                Id = dto.Id,
//                Title = dto.Title,
//                Description = dto.Description,
//                ExhibitionId = dto.ExhibitionId,
//                Importance = dto.Importance,
//                IsPublic = dto.IsPublic,
//                Link = dto.Link,
//                Period = dto.Period,
//                State = dto.State,
//                ViewsNumber = dto.ViewsNumber,
//            };
//        }

//        public IEnumerable<AdsViewDto> DtoToView(IEnumerable<AdsDto> dtoList, string lang = ar)
//        {
//            IEnumerable<AdsViewDto> adsViewDtos = new List<AdsViewDto>();
//            foreach (var dto in dtoList)
//            {
//                adsViewDtos= adsViewDtos.Append(DtoToView(dto, lang));
//            }

//            return adsViewDtos; 
//        }


//        //====================  AboutSectionViewDto  ====================================
//        public AboutSectionViewDto DtoToView(AboutSectionDto dto, string lang = ar)
//        {
//            var aboutSection = new AboutSectionViewDto
//            {
//                Id = dto.Id,
//                Image = dto.Image,
//                Order = dto.Order,
//                State = dto.State,
//                IsInHome = dto.IsInHome,
//            };
//            if (lang == ar)
//            {
//                aboutSection.Title = dto.ArTitle ?? dto.EnTitle ?? nothing;
//                aboutSection.Introduction = dto.ArIntroduction ?? dto.EnIntroduction ?? nothing;
//            }
//            else
//            {
//                aboutSection.Title = dto.EnTitle ?? dto.ArTitle ?? nothing;
//                aboutSection.Introduction = dto.EnIntroduction ?? dto.ArIntroduction ?? nothing;
//            }

//            return aboutSection;
//        }

//        public IEnumerable<AboutSectionViewDto> DtoToView(IEnumerable<AboutSectionDto> dtoList, string lang = ar)
//        {
//            IEnumerable<AboutSectionViewDto> aboutSectionViewDtos = new List<AboutSectionViewDto>();
//            foreach (AboutSectionDto dto in dtoList)
//            {
//                aboutSectionViewDtos = aboutSectionViewDtos.Append(DtoToView(dto, lang));
//            }

//            return aboutSectionViewDtos;
//        }


//        //====================  AboutSectionItemViewDto  ====================================
//        public AboutSectionItemViewDto DtoToView(AboutSectionItemDto dto, string lang = ar)
//        {
//            var aboutSectionItemViewDto = new AboutSectionItemViewDto
//            {
//                Id = dto.Id,
//                Numeric = dto.Numeric,
//                Order = dto.Order,
//                State = dto.State,
//                AboutSectionId = dto.AboutSectionId,
//            };

//            if (lang == ar)
//            {
//                aboutSectionItemViewDto.Content = dto.ArContent ?? dto.EnContent ?? nothing;

//            }
//            else
//            {
//                aboutSectionItemViewDto.Content = dto.EnContent ?? dto.ArContent ?? nothing;
//            }

//            return aboutSectionItemViewDto;
//        }

//        public IEnumerable<AboutSectionItemViewDto> DtoToView(IEnumerable<AboutSectionItemDto> dtoList, string lang = ar)
//        {
//            IEnumerable<AboutSectionItemViewDto> aboutSectionItemViewDtos = new List<AboutSectionItemViewDto>();
//            foreach (AboutSectionItemDto dto in dtoList)
//            {
//                aboutSectionItemViewDtos = aboutSectionItemViewDtos.Append(DtoToView(dto, lang));
//            }

//            return aboutSectionItemViewDtos;
//        }

//        //====================  AvailableAreaViewDto  ====================================
//        public AvailableAreaViewDto DtoToView(AvailableAreaDto dto, string lang = ar)
//        {
//            var availableArea = new AvailableAreaViewDto
//            {
//                Id = dto.Id,
//                Image = dto.Image,
//                Price = dto.Price,
//                Description = dto.Description,
//                Name = dto.Name,
//                State = dto.State,
//                Symbol = dto.Symbol
//            };
//            return availableArea; 
//        }

//        public IEnumerable<AvailableAreaViewDto> DtoToView(IEnumerable<AvailableAreaDto> dtoList, string lang = ar)
//        {
//            IEnumerable<AvailableAreaViewDto> availableAreaViewDtos = new List<AvailableAreaViewDto>();
//            foreach (var dto in dtoList)
//            {
//               availableAreaViewDtos= availableAreaViewDtos.Append(DtoToView(dto,lang));
//            }

//            return availableAreaViewDtos ;
//        }


//        //====================  ExhConfigViewDto  ====================================
//        public ExhConfigViewDto DtoToView(ExhConfigDto dto, string lang = ar)
//        {
//            var exhConfig = new ExhConfigViewDto
//            {
//                Id = dto.Id,
//                State = dto.State,
//                PrimaryColor = dto.PrimaryColor,
//                Other = dto.Other,
//                ExhibitionId = dto.ExhibitionId,
//                ThirdColor = dto.ThirdColor,
//                SecondaryColor = dto.SecondaryColor,
//            };

//            return exhConfig;
//        }

//        public IEnumerable<ExhConfigViewDto> DtoToView(IEnumerable<ExhConfigDto> dtoList, string lang = ar)
//        {
//            IEnumerable<ExhConfigViewDto> exhConfigViewDtos = new List<ExhConfigViewDto>();
//            foreach(ExhConfigDto dto in dtoList)
//            {
//                exhConfigViewDtos.Append(DtoToView(dto,lang));
//            }

//            return exhConfigViewDtos ;
//        }


//        //====================  ExhibitionViewDto  ====================================
//        public ExhibitionViewDto DtoToView(ExhibitionDto dto, string lang = ar)
//        {
//            var exhibition = new ExhibitionViewDto
//            {
//                EndDate = dto.EndDate,
//                Id = dto.Id,
//                Location = dto.Location,
//                Logo = dto.Logo,
//                Link = dto.Link,
//                PreviousId = dto.PreviousId.GetValueOrDefault(),
//                StartDate = dto.StartDate,
//                State = dto.State,
//                Version = dto.Version.GetValueOrDefault(),
//            };

//            if (lang == ar)
//            {
//                exhibition.Name = dto.ArName ?? dto.EnName ?? nothing;
//                exhibition.Introduction = dto.ArIntroduction ?? dto.EnIntroduction ?? nothing;
//                exhibition.SubTitle = dto.ArSubTitle ?? dto.EnSubTitle ?? nothing;
//            }
//            else
//            {
//                exhibition.Name = dto.EnName ?? dto.ArName ?? nothing;
//                exhibition.Introduction = dto.EnIntroduction ?? dto.ArIntroduction ?? nothing;
//                exhibition.SubTitle = dto.EnSubTitle ?? dto.ArSubTitle ?? nothing;
//            }

//            return exhibition;
//        }

//        public IEnumerable<ExhibitionViewDto> DtoToView(IEnumerable<ExhibitionDto> dtoList, string lang = ar)
//        {
//            IEnumerable<ExhibitionViewDto> exhibitionViewDtos = new List<ExhibitionViewDto>();
//            foreach (ExhibitionDto dto in dtoList)
//            {
//                exhibitionViewDtos = exhibitionViewDtos.Append(DtoToView(dto, lang));
//            }

//            return exhibitionViewDtos;
//        }


//        //====================  ExhSectionViewDto  ====================================
//        public ExhSectionViewDto DtoToView(ExhSectionDto dto, string lang = ar)
//        {
//            var exhSection = new ExhSectionViewDto
//            {
//                ExhibitionId = dto.ExhibitionId,
//                Id = dto.Id,
//                Name = dto.Name,
//                Image = dto.Image,
//                Order = dto.Order,
//                State = dto.State,
//            };

//            if(lang == ar)
//            {
//                exhSection.Title = dto.ArTitle ?? dto.EnTitle ?? nothing;
//                exhSection.Introduction = dto.ArIntroduction ?? dto.EnIntroduction ?? nothing;  
//            }
//            else
//            {
//                exhSection.Title = dto.EnTitle ?? dto.ArTitle ?? nothing;
//                exhSection.Introduction = dto.EnIntroduction ?? dto.ArIntroduction ?? nothing;
//            }

//            return exhSection;
//        }

//        public IEnumerable<ExhSectionViewDto> DtoToView(IEnumerable<ExhSectionDto> dtoList, string lang = ar)
//        {
//            IEnumerable<ExhSectionViewDto> exhSectionViewDtos = new List<ExhSectionViewDto>();
//            foreach(ExhSectionDto dto in dtoList)
//            {
//                exhSectionViewDtos= exhSectionViewDtos.Append(DtoToView(dto,lang));
//            }

//            return exhSectionViewDtos;  
//        }


//        //====================  ExhSectionItemViewDto  ====================================
//        public ExhSectionItemViewDto DtoToView(ExhSectionItemDto dto, string lang = ar)
//        {
//            var exSecItem = new ExhSectionItemViewDto
//            {
//                Id = dto.Id,
//                ExhSectionId = dto.ExhSectionId,
//                Image = dto.Image,
//                Order = dto.Order,
//                Numeric = dto.Numeric,
//                State = dto.State,
//            };

//            if (lang == ar)
//            {
//                exSecItem.Content = dto.ArContent ?? dto.EnContent ?? nothing;                
//            }
//            else
//            {
//                exSecItem.Content = dto.EnContent ?? dto.ArContent ?? nothing;
//            }

//            return exSecItem;
//        }

//        public IEnumerable<ExhSectionItemViewDto> DtoToView(IEnumerable<ExhSectionItemDto> dtoList, string lang = ar)
//        {
//            IEnumerable<ExhSectionItemViewDto> exhSectionItemViewDtos = new List<ExhSectionItemViewDto>();
//            foreach (var dto in dtoList)
//            {
//                exhSectionItemViewDtos=exhSectionItemViewDtos.Append(DtoToView(dto,lang)); 
//            }
//            return exhSectionItemViewDtos;
//        }


//        //====================  ExhSocialMediaViewDto  ====================================
//        public ExhSocialMediaViewDto DtoToView(ExhSocialMediaDto dto, string lang = ar)
//        {
//            throw new NotImplementedException();
//        }

//        public IEnumerable<ExhSocialMediaViewDto> DtoToView(IEnumerable<ExhSocialMediaDto> dtoList, string lang = ar)
//        {
//            throw new NotImplementedException();
//        }


//      // ========================== News View Dto ===========================================
//        public NewsViewDto DtoToView(NewsDto dto, string lang = ar)
//        {
//            NewsViewDto newsViewDto = new NewsViewDto
//            {
//                Id = dto.Id,
//                Image = dto.Image,
//                State = dto.State,
//            };
//            if (lang == ar)
//            {
//                newsViewDto.Title = dto.ArTitle ?? dto.EnTitle ?? nothing;
//                newsViewDto.Content = dto.ArContent ?? dto.EnContent ?? nothing;
//            }
//            else
//            {
//                newsViewDto.Title = dto.EnTitle ?? dto.ArTitle ?? nothing;
//                newsViewDto.Content = dto.EnContent ?? dto.ArContent ?? nothing;
//            }
//            return newsViewDto;

//        }

        
//        public IEnumerable<NewsViewDto> DtoToView(IEnumerable<NewsDto> dtoList, string lang = ar)
//        {
//            IEnumerable<NewsViewDto> newsViewDtos = new List<NewsViewDto>();
//            foreach (NewsDto dto in dtoList)
//            {
//                newsViewDtos = newsViewDtos.Append(DtoToView(dto, lang));
//            }
//            return newsViewDtos;
//        }

//        public ReservedAreaViewDto DtoToView(ReservedAreaDto dto, string lang = ar)
//        {
//            throw new NotImplementedException();
//        }

//        public IEnumerable<ReservedAreaViewDto> DtoToView(IEnumerable<ReservedAreaDto> dtoList, string lang = ar)
//        {
//            throw new NotImplementedException();
//        }

//        // ========================== Slide View Dto ================================================================
//        public SlideViewDto DtoToView(SlideDto dto, string lang = ar)
//        {
//            SlideViewDto slideViewDto = new SlideViewDto
//            {
//                Id = dto.Id,
//                Image = dto.Image,
//                Link = dto.Link,
//                Order = dto.Order,
//                State = dto.State,

//            };
//            if (lang == ar)
//            {
//                slideViewDto.Title = dto.ArTitle ?? dto.EnTitle ?? nothing;
//                slideViewDto.Description = dto.ArDescription ?? dto.EnDescription ?? nothing;
//            }
//            else
//            {
//                slideViewDto.Title = dto.EnTitle ?? dto.ArTitle ?? nothing;
//                slideViewDto.Description = dto.EnDescription ?? dto.ArDescription ?? nothing;
//            }

//            return slideViewDto;
//        }

//        public IEnumerable<SlideViewDto> DtoToView(IEnumerable<SlideDto> dtoList, string lang = ar)
//        {
//            IEnumerable<SlideViewDto> slideViewDtos = new List<SlideViewDto>();
//            foreach (SlideDto dto in dtoList)
//            {
//                slideViewDtos = slideViewDtos.Append(DtoToView(dto, lang));
//            }
//            return slideViewDtos;
//        }

//        public SocialMediaViewDto DtoToView(SocialMediaDto dto, string lang = ar)
//        {
//            throw new NotImplementedException();
//        }

//        public IEnumerable<SocialMediaViewDto> DtoToView(IEnumerable<SocialMediaDto> dtoList, string lang = ar)
//        {
//            throw new NotImplementedException();
//        }

//        public SponsorViewDto DtoToView(SponsorDto dto, string lang = ar)
//        {
//            var spvd = new SponsorViewDto
//            {
//                ExhibitionId = dto.ExhibitionId,
//                Id = dto.Id,
//                Image = dto.Image,
//                Logo = dto.Logo,
//                SponsorTypeId = dto.SponsorTypeId,
//                State = dto.State,
//                Location = dto.Location,
//            };
//            if(lang == ar)
//            {
//                spvd.Name = dto.ArName ?? dto.EnName ?? nothing;
//                spvd.Introduction = dto.ArIntroduction ?? dto.EnIntroduction ?? nothing;
//            }
//            else
//            {
//                spvd.Name = dto.EnName ?? dto.ArName ?? nothing;
//                spvd.Introduction = dto.EnIntroduction ?? dto.ArIntroduction ?? nothing;
//            }

//            return spvd;
//        }

//        public IEnumerable<SponsorViewDto> DtoToView(IEnumerable<SponsorDto> dtoList, string lang = ar)
//        {
//            IEnumerable<SponsorViewDto> sponsorViewDtos = new List<SponsorViewDto>();
//            foreach(var dto in dtoList)
//            {
//                sponsorViewDtos = sponsorViewDtos.Append(DtoToView(dto,lang));
//            }
//            return sponsorViewDtos;
//        }

//        public SponsorProductViewDto DtoToView(SponsorProductDto dto, string lang = ar)
//        {
//            throw new NotImplementedException();
//        }

//        public IEnumerable<SponsorProductViewDto> DtoToView(IEnumerable<SponsorProductDto> dtoList, string lang = ar)
//        {
//            throw new NotImplementedException();
//        }

//        public VisitViewDto DtoToView(VisitDto dto, string lang = ar)
//        {
//            throw new NotImplementedException();
//        }

//        public IEnumerable<VisitViewDto> DtoToView(IEnumerable<VisitDto> dtoList, string lang = ar)
//        {
//            throw new NotImplementedException();
//        }

//        public SponsorTypeViewDto DtoToView(SponsorTypeDto dto, string lang = "ar-YE")
//        {
//            throw new NotImplementedException();
//        }

//        public IEnumerable<SponsorTypeViewDto> DtoToView(IEnumerable<SponsorTypeDto> dtoList, string lang = "ar-YE")
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
